# https://hub.docker.com/_/microsoft-dotnet
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /source

# copy csproj and restore as distinct layers
COPY *.sln .
COPY SimpleWebAPI/*.csproj ./SimpleWebAPI/
RUN dotnet restore

# copy everything else and build app
COPY SimpleWebAPI/. ./SimpleWebAPI/
WORKDIR /source/SimpleWebAPI
RUN dotnet publish -c release -o /SimpleWebAPI --no-restore

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /SimpleWebAPI
COPY --from=build /SimpleWebAPI ./
ENTRYPOINT ["dotnet", "SimpleWebAPI.dll"]