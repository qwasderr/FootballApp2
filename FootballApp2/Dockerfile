#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["FootballApp2/FootballApp2.csproj", "FootballApp2/"]
RUN dotnet restore "FootballApp2/FootballApp2.csproj"
COPY . .
WORKDIR "/src/FootballApp2"
RUN dotnet build "FootballApp2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FootballApp2.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FootballApp2.dll"]