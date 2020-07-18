docker build --target prod -t bigbrother:dev $PSScriptRoot/..

docker run --rm -it --pid host bigbrother:latest
