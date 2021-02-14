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

### ApplicationDbContext
- Define the relationship between domain models in the OnModelCreating method.
- Relationship of A to B as one to one is done with HasRequired, or one to many with HasMany.
- The inverse relationship of B to A is described with WithRequired (one to one) or WithMany (many to one).

### Models
- Models should represent an object in terms of properties and behaviours.
- Anaemic domain models are models that only describes properties. 
- Encapsulate business logic in domain models, so that business logic grows and contained within your domain models.
- Always be in a valid state. (through access modifiers)
- Cohesion: things highly related should be together, architectural and method level. ex. Cancel method will set gig status to canceled, and also notify attendees.