## Description
PoC Training core .NET Mongodb Backend Topics Resources

## Install some dependencies

```sh
dotnet add package Microsoft.EntityFrameworkCore --version 6.0.1
```

```sh
dotnet add package MongoDB.Driver --version 2.15.0
```

## Compile service
```sh
dotnet publish -c Release
```

## Execute service
```sh
dotnet run
```

## Access swagger UI
```sh
http://localhost:5225/swagger/index.html
```

# Compile image
```sh
docker build -t poc-docker-corenet-backend .
```

# run image
```sh
docker run --name poc-docker-corenet-backend -d -p 5000:80 --network training poc-docker-corenet-backend
```

# Access API from container
```sh
http://localhost:5000/products
```