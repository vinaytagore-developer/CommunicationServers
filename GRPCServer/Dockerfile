# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy csproj and restore dependencies
COPY ./GRPCServer/*.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY /GRPCServer ./
RUN dotnet publish -c Release -o /app/publish

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

# Copy published output
COPY --from=build /app/publish .

# Expose port
EXPOSE 80

ENTRYPOINT "dotnet" "GRPCServer.dll"