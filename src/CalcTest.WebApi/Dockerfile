FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["CalcTest.WebApi/CalcTest.WebApi.csproj", "CalcTest.WebApi/"]
COPY ["CalcTest.Application/CalcTest.Application.csproj", "CalcTest.Application/"]
COPY ["CalcTest.Core/CalcTest.Core.csproj", "CalcTest.Core/"]
RUN dotnet restore "CalcTest.WebApi/CalcTest.WebApi.csproj"
COPY . .
WORKDIR "/src/CalcTest.WebApi"
RUN dotnet build "CalcTest.WebApi.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "CalcTest.WebApi.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "CalcTest.WebApi.dll"]