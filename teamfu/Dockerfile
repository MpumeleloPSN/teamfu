# https://hub.docker.com/_/microsoft-dotnet
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY src/com.teamfu.be/myfirstapi/myfirstapi.csproj ./
RUN dotnet restore myfirstapi.csproj 

# copy everything else and build app
COPY src/com.teamfu.be/myfirstapi/. /app/myfirstapi/
WORKDIR /app/myfirstapi
RUN mkdir /publishedApp
RUN dotnet publish myfirstapi.csproj -c release -o /publishedApp

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build /publishedApp .
ENTRYPOINT ["dotnet", "myfirstapi.dll"]