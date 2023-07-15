FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["DDDConcept/DDDConcept.csproj", "DDDConcept/"]
RUN dotnet restore "DDDConcept/DDDConcept.csproj"
COPY . .
WORKDIR "/src/DDDConcept"
RUN dotnet build "DDDConcept.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DDDConcept.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DDDConcept.dll"]
