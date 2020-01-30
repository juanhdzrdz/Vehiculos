using Autofac;
using Autofac.Extensions.DependencyInjection;
using HDI.Framework.Integration.EventBus.Brokers.RabbitMQ;
using HDI.Framework.Integration.EventBus.Core;
using HDI.Framework.Integration.EventBus.Core.Enums;
using HDI.Framework.Integration.EventBus.Core.Interfaces;
using HDI.Corredores.Cotizacion.ServicioVehiculo.AccesoDatos;
using HDI.Corredores.Cotizacion.ServicioVehiculo.BaseDatos;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Configuracion;
using HDI.Corredores.Cotizacion.ServicioVehiculo.EventosIntegracion.Events;
using HDI.Corredores.Cotizacion.ServicioVehiculo.EventosIntegracion.Events.Handlers;
using HDI.Corredores.Cotizacion.ServicioVehiculo.Negocio;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
// TODO 04: Si desea implementar HTTPS, agregue el using a Microsoft.AspNetCore.HttpsPolicy
//using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using System;
using HDI.Framework.EntityFrameworkCore;
using HDI.Corredores.Cotizacion.ServicioVehiculo.EventosIntegracion.Proxy;
using HDI.Corredores.Cotizacion.ServicioVehiculo.AccesoDatos;

namespace HDI.Corredores.Cotizacion.ServicioVehiculo.Root
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public ILifetimeScope AutofacContainer { get; private set; }

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddEnvironmentVariables();

            Configuration = builder.Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            AddEnviromentVariablesService(services);

            AddLayerContextServices(services);

            AddEventBusServices(services);

            AddSwaggerService(services);

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            AddDbContextService(services);

            services.AddOptions();
        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule(new AutofacModule());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // TODO 05: Si es necesario habilitar comunicación segura, agregue el uso de HSTS
                //app.UseHsts();
            }

            ConfigureSwagger(app);

            ConfigureAutofac(app);

            // TODO 06: Si es necesario habilitar comunicación segura, agregue el uso de HTTPS REDIRECTION
            //app.UseHttpsRedirection();
            app.UseMvc();

            //ConfigureEventBus(app);
        }

        private void AddEnviromentVariablesService(IServiceCollection services)
        {
            services.Configure<ServiceConfiguration>(Configuration);
        }

        private void AddLayerContextServices(IServiceCollection services)
        {
            // TODO 07: Defina el tiempo de vida del servicio agregando AddTransient, AddScoped o AddSingleton dependiendo de la funcionalidad. 
            // Para mayor informaciòn consulte la siguiente documentacion https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-2.2#service-lifetimes
            //services.AddScoped<IBusinessContext, BusinessContext>();
            //services.AddSingleton<IBusinessContext, BusinessContext>();

            services.AddTransient<IBusinessContext, BusinessContext>();
            services.AddTransient<IDataContext, DataContext>();
            services.AddTransient<INegocioVehiculo, NegocioVehiculo>();
            services.AddTransient<IDatosVehiculo, DatosVehiculo>();
            services.AddTransient<IServicioConfiguracionNT, ServicioConfiguracionNT>();
            services.AddTransient<INegocioSuma, NegocioSuma>();
            services.AddTransient<INegocioMarca, NegocioMarca>();
            services.AddTransient<IDataMarca, DataMarca>();
            

        }

        private void AddEventBusServices(IServiceCollection services)
        {
            services.AddSingleton<IEventBusConnection>(sp =>
            {
                string hostName = Environment.GetEnvironmentVariable("RabbitHostName");
                string userName = Environment.GetEnvironmentVariable("RabbitUserName");
                string password = Environment.GetEnvironmentVariable("RabbitPassword");
                string virtualHost = Environment.GetEnvironmentVariable("RabbitVirtualHost");

                int port = int.Parse(Environment.GetEnvironmentVariable("RabbitPort"));

                return new ConnectionRabbitMQ(hostName, port, userName, password, virtualHost);
            });

            services.AddSingleton<IEventBusSubscriptionsManager, EventBusSubscriptionsManager>();

            services.AddSingleton<IEventBus, EventBusRabbitMQ>(sp =>
             {
                 IEventBusConnection rabbitMQConnection = sp.GetRequiredService<IEventBusConnection>();
                 IEventBusSubscriptionsManager eventBusSubscriptionManager = sp.GetRequiredService<IEventBusSubscriptionsManager>();
                 ILifetimeScope lifetimeScope = sp.GetRequiredService<ILifetimeScope>();

                 string exchangeName = Environment.GetEnvironmentVariable("RabbitExchangeName");
                 ExchangeType exchangeType = (ExchangeType)int.Parse(Environment.GetEnvironmentVariable("RabbitExchangeType"));
                 bool exchangeIsDurable = bool.Parse(Environment.GetEnvironmentVariable("RabbitExchangeIsDurable"));
                 bool exchangeIsAutoDelete = bool.Parse(Environment.GetEnvironmentVariable("RabbitExchangeIsAutoDelete"));

                 EventBusExchange exchange = new EventBusExchange(exchangeName, exchangeType, exchangeIsDurable, exchangeIsAutoDelete, null);

                 string queueName = Environment.GetEnvironmentVariable("RabbitQueueName");
                 bool queueIsDurable = bool.Parse(Environment.GetEnvironmentVariable("RabbitQueueIsDurable"));
                 bool queueIsExclusive = bool.Parse(Environment.GetEnvironmentVariable("RabbitQueueIsExclusive"));
                 bool queueIsAutoDelete = bool.Parse(Environment.GetEnvironmentVariable("RabbitQueueIsAutoDelete"));

                 EventBusQueue queue = new EventBusQueue(queueName, queueIsDurable, queueIsExclusive, queueIsAutoDelete, null);

                 return new EventBusRabbitMQ(rabbitMQConnection, eventBusSubscriptionManager, lifetimeScope, exchange, queue);
             });

            services.AddTransient<SendLogMessageEventHandler>();
        }

        private void AddSwaggerService(IServiceCollection services)
        {
            // TODO 08: Las siguientes líneas habilitan la generación de documentación de Swagger, comentarlas en caso de no requerirlo
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "Servicio" });
            });
        }

        private void AddDbContextService(IServiceCollection services)
        {
            services.AddDbContext<LogDbContext>(options =>
            {
                options.UseSqlServer(Environment.GetEnvironmentVariable("LogConnectionStringSQL"));
            });
        }

        private void ConfigureSwagger(IApplicationBuilder app)
        {
            // TODO 09: Las siguientes líneas habilitan mostrar la interfaz de Swagger, comentarlas en caso de no requerirlo
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Servicio");
                c.RoutePrefix = string.Empty;
            });
        }

        private void ConfigureAutofac(IApplicationBuilder app)
        {
            this.AutofacContainer = app.ApplicationServices.GetAutofacRoot();
        }

        private void ConfigureEventBus(IApplicationBuilder app)
        {
            IEventBus eventBus = app.ApplicationServices.GetRequiredService<IEventBus>();

            eventBus.Subscribe<SendLogMessageEvent, SendLogMessageEventHandler>();
        }
    }
}
