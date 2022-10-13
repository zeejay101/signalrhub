#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 9007

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["SignallRHub/SignallRHub.csproj", "SignallRHub/"]
RUN dotnet restore "SignallRHub/SignallRHub.csproj"
COPY . .
WORKDIR "/src/SignallRHub"
RUN dotnet build "SignallRHub.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SignallRHub.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SignallRHub.dll"]