#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-1803 AS base
WORKDIR /app
EXPOSE 63271
EXPOSE 44385

FROM microsoft/dotnet:2.1-sdk-nanoserver-1803 AS build
WORKDIR /src
COPY ["CalcTest.WebApi/CalcTest.WebApi.csproj", "CalcTest.WebApi/"]
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