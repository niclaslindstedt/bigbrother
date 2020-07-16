FROM mcr.microsoft.com/dotnet/core/sdk:3.1-alpine as build
WORKDIR /app
COPY . .
RUN cd src/console \
    && dotnet publish -o /app/out

FROM build as develop
CMD ["dotnet", "run"]

FROM build as test
RUN cd src/tests \
    && dotnet test

FROM mcr.microsoft.com/dotnet/core/runtime:3.1-alpine as prod
WORKDIR /app
COPY --from=build /app/out .
CMD ["dotnet", "bigbrother.dll"]
