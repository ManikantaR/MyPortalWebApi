# MyPortalWebApi
.Net Core Web Api 2.2  using Onion Architecture. 

Application is built on Onion Architecture with an aim to develop loosely coupled and proper separation of modules and its dependencies. 
 
Fundamental idea is dependency flow to center  i.e core layer (Domain/Service), and core doesn’t dependent on other layers.
Domain Layer: At the very core is the Domain layer which holds all of your domain entities. The idea is to have all of your domain objects at this core. Besides entities keep interfaces (repositories and services).

Application Service Layer: This is where we keep business logic. All concrete implementation of service should have interfaces.
Infrastructure Layer – this is the outermost layer which deals with Infrastructure needs and provides the implementation of your repositories interfaces. We could have Email, Log, File access, External service call implementation in this layer.
Helper Libraries used to increase the productivity of developer.
AutoMapper : AutoMapper is a simple little library built to solve a deceptively complex problem - getting rid of code that mapped one object to another. This eases mapping of DTO to Entities and reverse mapping.

https://automapper.org/ 

FluentValidation : A small validation library for .NET that uses a fluent interface and lambda expressions for building validation rules.

https://fluentvalidation.net/ 
 


Swashbuckle Swagger : Api documentation using swagger. When consuming a Web API, understanding
its various methods can be challenging for a developer. Swagger, also known as OpenAPI, solves the problem of 
generating useful documentation and help pages for Web APIs. It provides benefits such as interactive documentation, 
client SDK generation, and API discoverability.

https://docs.microsoft.com/en-us/aspnet/core/tutorials/web-api-help-pages-using-swagger?view=aspnetcore-2.2 
