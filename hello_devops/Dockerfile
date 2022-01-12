#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["hello_devops/hello_devops.csproj", "hello_devops/"]
RUN dotnet restore "hello_devops/hello_devops.csproj"
COPY . .
WORKDIR "/src/hello_devops"
RUN dotnet build "hello_devops.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "hello_devops.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "hello_devops.dll"]