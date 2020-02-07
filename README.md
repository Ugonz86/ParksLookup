# Parks Lookup _01/31/2020_

## By _**Uriel Gonzalez**_

### Description

C#/.NET project. Includes full CRUD functionality and successful return responses to API calls.

The user can:

1. Add, view, edit, search and delete one or multiple national parks.

## Setup/Installation Requirements

* This program requires .NET and MySQL.

1. Clone this repository:

  ```sh
  $git clone https://github.com/Ugonz86/ParksLookup.git
  $cd ParksLookup/Parks
  $dotnet restore
  $dotnet ef database update
  $dotnet run
  In your browser URL type: http://localhost:5001/
  ```

2. Open the App Settings file (ParksLookup/Parks/appsettings.json) and ensure that the MySQL username and password matches your MySQL credentials.

## Postman

```sh
* To GET all parks: http://localhost:5000/api/parks/
* To GET a random park: http://localhost:5000/api/parks/random
* To GET a specific park by Name: http://localhost:5000/api/parks?name=Mt. Rainier
* To GET a specific park by Info: http://localhost:5000/api/parks?info=3002 Mt Angeles Rd, Port Angeles, WA 98362
* To GET a specific park by Alerts: http://localhost:5000/api/parks?alerts=Rain - 39°F
```

## Swagger

Visit my project at SwaggerHub:

```sh
* In command line: Dotnet run
* On your browser URL: https://app.swaggerhub.com/apis/Ugonz86/my-api/v1
```

## Known Bugs

* No bugs at this moment.

## Technologies Used

* C# / .NET / ASP.NET Core MVC / Entity Framework Core / Swagger

## Support and contact details

_Please contact me with questions and comments: ugonzalez86@gmail.com._

### License

Copyright (c) 2020 **_Uriel Gonzalez_**
