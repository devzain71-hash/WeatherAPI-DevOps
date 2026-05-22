FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src
COPY ["WeatherAPI.csproj", "."]
RUN dotnet restore "WeatherAPI.csproj"
COPY . .
RUN dotnet build "WeatherAPI.csproj" -c Release -o /app/build

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS runtime
WORKDIR /app
COPY --from=build /app/build .
EXPOSE 5000
ENV ASPNETCORE_HTTP_PORTS=5000
ENTRYPOINT ["dotnet", "WeatherAPI.dll"]