﻿/*FROM mcr.microsoft.com/dotnet/sdk:8.0 as build-env
WORKDIR /App
COPY . ./

RUN dotnet restore
RUN dotnet publich -c Release -o out -r linux-x64

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /App
COPY --from=build-env /App/out .

EXPOSE 8090

ENTRYPOINT ["dotnet", "AWSDockerApp.dll"]*/
