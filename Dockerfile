FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

COPY ["PortfolioAlexander.csproj", "./"]
RUN dotnet restore "PortfolioAlexander.csproj"

COPY . .
RUN dotnet publish "PortfolioAlexander.csproj" \
    --configuration Release \
    --output /app/publish \
    /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app

ENV ASPNETCORE_HTTP_PORTS=8080
EXPOSE 8080

COPY --from=build /app/publish .
USER app

ENTRYPOINT ["dotnet", "PortfolioAlexander.dll"]

