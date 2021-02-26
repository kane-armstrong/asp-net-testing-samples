FROM mcr.microsoft.com/dotnet/sdk:5.0.100-focal AS build
ARG Configuration=Release
WORKDIR /app

COPY . ./
RUN dotnet publish Api -c $Configuration -o ../../publish -r alpine-x64

FROM mcr.microsoft.com/dotnet/runtime-deps:5.0.0-alpine3.12
WORKDIR /app
COPY --from=build /publish ./
ENTRYPOINT ["./Api"]
