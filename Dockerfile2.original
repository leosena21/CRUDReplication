FROM microsoft/aspnetcore:2.0-stretch AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0-stretch AS build
WORKDIR /src
COPY ["crudmysql.csproj", "./"]
RUN dotnet restore "/crudmysql.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "crudmysql.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "crudmysql.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "crudmysql.dll"]
