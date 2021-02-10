# GigHub
This is a practice project for Pluralsight .NET Full Stack Development.

## Stack
- .NET Core MVC
- SQL Database

### How the database is maintained.
- Code first approach.
- Class models are created.
- PM > add-migration when changes are made to the models. 
- PM > Update-Database to commit the changes to database.
- Whenever a new model is created, the ApplicationDbContext is updated with the new models.