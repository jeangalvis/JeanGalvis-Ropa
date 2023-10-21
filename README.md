# JeanGalvis-Ropa

Los endpoints estan separados por:

- Los gets de cada tabla y su versionado.
- Los gets de las consultas y su versionado.

Nota: Tener en cuenta que la autenticacion para poder usar los endpoints es por medio del bearer token.

Para el uso de los endpoints en la version 1.1 se debe establecer el Header y los Query parameters de la siguiente forma:

#### Headers

![Header](https://github.com/jeangalvis/Veterinary/assets/137228150/4edb2104-3840-4438-ba04-a3549143bd0e)

#### Query Parameters

Algunos endpoints permiten recibir un parametro mas "name" para busquedas especificas de un nombre, asi como tambien otros no hacen uso del parametro Search.

![Queries](https://github.com/jeangalvis/Veterinary/assets/137228150/16464107-359c-4e84-bd8f-665866c0abe1)

## Endpoints Usuarios

Para los endpoints de Register y AddRole es necesario estar autenticado con un usuario que tenga rol de "Administrator"

##### 1. Register

`http://localhost:5036/api/User/register`

Body en formato JSON

```JSON
{
  "email": "string",
  "username": "string",
  "password": "string"
}
```

##### 2. Login

Aca obtenemos el token para usarlo como autenticación en el Bearer Token de las consultas

`http://localhost:5036/api/User/token`

Body en formato JSON

```JSON
{
  "username": "string",
  "password": "string"
}
```

##### 2. AddRole

`http://localhost:5036/api/User/addrole`

Body en formato JSON

```JSON
{
  "username": "string",
  "password": "string",
  "role": "string"
}
```


El endpoint de la query 1 es
`/api/Prenda/GetInsumosxPrenda`, pasar como parametro el id del codigo


### todas las tablas tienen su CRUD y su versionado con paginacion
###End
