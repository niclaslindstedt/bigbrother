FROM mcr.microsoft.com/dotnet/core/sdk:3.1-alpine as build
RUN apk update \
	&& apk upgrade \
	&& apk add \
		nano
WORKDIR /app/src
COPY ./src/*.sln ./
COPY ./src/console/*.csproj ./console/
COPY ./src/core/*.csproj ./core/
COPY ./src/tests/*.csproj ./tests/
RUN dotnet clean \
	&& dotnet restore
COPY ./src .
RUN dotnet build --no-restore

FROM build as develop
WORKDIR /app/src/tests
CMD ["dotnet", "watch", "test"]

FROM build as test
RUN dotnet test -c Release --no-restore

FROM test as publish
WORKDIR /app/src
RUN dotnet publish -c Release -o /app/out --no-restore

FROM mcr.microsoft.com/dotnet/core/runtime:3.1-alpine as prod
WORKDIR /app
COPY --from=publish /app/out .
CMD ["dotnet", "bigbrother.dll"]
