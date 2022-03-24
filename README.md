## Description
PoC Training core .NET Mongodb Backend Topics Resources

## Install some dependencies

```sh
dotnet add package Microsoft.EntityFrameworkCore --version 6.0.1
```

```sh
dotnet add package MongoDB.Driver --version 2.15.0
```

## Restore dependencies
```sh
dotnet restore
```

## Compile service
```sh
dotnet publish -c Release
```

## Start service from host
```sh
dotnet run
```

Access API service
```sh
http://localhost:5225/api/products
```

Access swagger ui service
```sh
http://localhost:5225/swagger/index.html
```

## Compile image
```sh
docker build -t poc-docker-corenet-backend .
```

## Start container from docker
Start container from docker environment
```sh
docker run --name poc-docker-corenet-backend -d -e "ASPNETCORE_ENVIRONMENT=Docker" -p 5000:80 --network training poc-docker-corenet-backend
```

Access API service
```sh
http://localhost:5000/api/products
```