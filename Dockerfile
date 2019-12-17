FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["BlazorLVM.csproj", "./"]
RUN dotnet restore "./BlazorLVM.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "BlazorLVM.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BlazorLVM.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BlazorLVM.dll"]
