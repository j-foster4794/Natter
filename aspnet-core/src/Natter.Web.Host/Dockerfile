FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/Natter.Web.Host/Natter.Web.Host.csproj", "src/Natter.Web.Host/"]
COPY ["src/Natter.Web.Core/Natter.Web.Core.csproj", "src/Natter.Web.Core/"]
COPY ["src/Natter.Application/Natter.Application.csproj", "src/Natter.Application/"]
COPY ["src/Natter.Core/Natter.Core.csproj", "src/Natter.Core/"]
COPY ["src/Natter.EntityFrameworkCore/Natter.EntityFrameworkCore.csproj", "src/Natter.EntityFrameworkCore/"]
WORKDIR "/src/src/Natter.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/Natter.Web.Host", "src/Natter.Web.Host"]
COPY ["src/Natter.Web.Core", "src/Natter.Web.Core"]
COPY ["src/Natter.Application", "src/Natter.Application"]
COPY ["src/Natter.Core", "src/Natter.Core"]
COPY ["src/Natter.EntityFrameworkCore", "src/Natter.EntityFrameworkCore"]
WORKDIR "/src/src/Natter.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "Natter.Web.Host.dll"]
