# library-management-system-api

> This project is an API developed using .NET 7 Web API.

>(https://library-management-app.azurewebsites.net/swagger/) 

## Getting Started

### Description
- This a simple library management system with CRUD operations, this project considered as the backend pavilion of the system.
- It is responsible for the communication with the database and execute all CRUD operations.
- the API is hosted in Azure cloud.

### Data Access

-  Entity framework core has been used as persistance framework for the application.
-  Repsitories has been implemented to work as a mediator between the domain and persistance framework layers.

### API Documentation
 
 - Swagger.

  
### Installing

- .Net 7 needs to be installed on the machine
- Visual Studio 2022 (recomended) or 2019
  
### Libraries used in the project:
- Microsoft.AspNetCore.Mvc
- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.ChangeTracking
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools

### Executing program
 
 - Clone the repository.
 - Configure your own connection string.
 - run the migration and update the database.
 - start the project.

### Version History

* 0.1
    * Initial Release
