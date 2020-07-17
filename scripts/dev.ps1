docker build --target develop -t bigbrother:dev $PSScriptRoot/..

docker run --rm -it --pid host -v $PSScriptRoot/../src:/app/src bigbrother:dev
