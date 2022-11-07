FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["EasyCation/EasyCation.csproj", "EasyCation/"]
RUN dotnet restore "EasyCation/EasyCation.csproj"
COPY . .
WORKDIR "/src/EasyCation"
RUN dotnet build "EasyCation.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EasyCation.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EasyCation.dll"]
