FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Operators/Operators.csproj", "Operators/"]
RUN dotnet restore "Operators/Operators.csproj"
COPY . .
WORKDIR "/src/Operators"
RUN dotnet build "Operators.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Operators.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Operators.dll"]
