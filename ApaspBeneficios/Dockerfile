FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["EscolaLumiart/EscolaLumiart.csproj", "EscolaLumiart/"]
RUN dotnet restore "EscolaLumiart/EscolaLumiart.csproj"
COPY . .
WORKDIR "/src/EscolaLumiart"
RUN dotnet build "EscolaLumiart.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "EscolaLumiart.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "EscolaLumiart.dll"]