FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk AS publish
WORKDIR /src
COPY . .
RUN dotnet restore "Root/Root.csproj"
WORKDIR "/src/Root"
RUN dotnet publish "Root.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "HDI.Corredores.Cotizacion.ServicioVehiculo.Root.dll"]
