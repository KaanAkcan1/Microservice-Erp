# Kullanılacak temel imaj
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app
EXPOSE 80

# Uygulama derleme aşaması
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY ["YARP.Gateway/YARP.Gateway.csproj", "YARP.Gateway/"]
RUN dotnet restore "YARP.Gateway/YARP.Gateway.csproj"
COPY . .
WORKDIR "/src/YARP.Gateway"
RUN dotnet build "YARP.Gateway.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "YARP.Gateway.csproj" -c Release -o /app/publish

# Çalıştırılacak uygulama
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "YARP.Gateway.dll"]
