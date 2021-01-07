#FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
FROM mcr.microsoft.com/dotnet/sdk:5.0
ENV DOTNET_USE_POLLING_FILE_WATCHER 1

WORKDIR /app

COPY DockerSample.Web/. .
#COPY DockerSample.Web/bin/Debug/net5.0/DockerSample.Web.runtimeconfig.json .
#COPY DockerSample.Web/bin/Debug/net5.0/DockerSample.Web.runtimeconfig.dev.json .

ENTRYPOINT ["dotnet", "watch", "run", "--urls", "https://0.0.0.0:5000"]