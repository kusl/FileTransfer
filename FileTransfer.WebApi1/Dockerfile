#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["FileTransfer.WebApi1/FileTransfer.WebApi1.csproj", "FileTransfer.WebApi1/"]
RUN dotnet restore "FileTransfer.WebApi1/FileTransfer.WebApi1.csproj"
COPY . .
WORKDIR "/src/FileTransfer.WebApi1"
RUN dotnet build "FileTransfer.WebApi1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FileTransfer.WebApi1.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FileTransfer.WebApi1.dll"]