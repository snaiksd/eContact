# eContact
Th project is implemented in .Net Core. If you run it on local, it will open swagger APIs at http://localhost:52315/swagger/index.html

eContact API Project has below components

Database

Just create an empty database and provide the connection in appsettings.json, it will create the table required for the application. Currently the databse is pointing to local database, you can copy azure SQL link in it.

eContact.API

APIs for getting and saving contact information, handles error. Dependency injection for different interfaces in startup. Also the connection string from appsettings.json is injected from here to the context class. It also have swagger so you can test API using the swagger.

eContact.Business

This has the manager which is used by controllers, it operates on different services. The services in this library are internal, if there are any external services for them there is a seperate project "eContact.Services" which is not added. This type of design can also be used to call microservices.

eContact.Data

This contains repositories and their entities, with a generic BaseRepository. The contactRepository is implemented but not use as there is just on entity which needs only CRUD operations

eContact.Data.Entities
This is for entity classes from database. Genrally we also have a seperate model fo the exposed APIs Here i am using the same as a Model

eContact.NUnitTest
Unit tests for the service and controller functions.

Design
1. Object creation is shifted using DI provided by Core
2. Repository pattern with EF Core Code First. Can use Unit of Work but not needed as not doing lot of things in one go.


Enhancements Not included
1. Seperate model class which will be used by controller rather than the entity itself. Along wiht that Automapper or some other mapper can be used
2. If more entities are there then use the Entity soecific service and repository. 
