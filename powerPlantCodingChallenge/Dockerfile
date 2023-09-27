FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env
WORKDIR /App

# Copy everything
COPY . ./
# Restore as distinct layers
RUN dotnet restore  powerPlantCodingChallenge.API.csproj
# Build and publish a release
RUN dotnet publish powerPlantCodingChallenge.API.csproj -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /App
COPY --from=build-env /App/out .

# Set the desired port using the ASPNETCORE_URLS environment variable
#ENV ASPNETCORE_URLS=http://+:8888

ENTRYPOINT ["dotnet", "powerPlantCodingChallenge.API.dll"]


