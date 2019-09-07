FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY ApiServer  .
WORKDIR /app/ApiServer
RUN pwd; ls -la 
RUN dotnet restore
RUN dotnet publish -c Release -o publish

COPY ApiServer/ApiServer/static  publish/static

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2 AS runtime
WORKDIR /app/ApiServer/publish
COPY --from=build /app/ApiServer/publish ./
RUN pwd; ls -la .
ENTRYPOINT ["dotnet", "ApiServer.dll"]

