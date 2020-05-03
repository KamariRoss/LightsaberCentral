Don't lose track!
Now that we have new API skills, we want to create an API to help our favorite store keep track of their inventory. This API will be able to let users add, update, delete, and search for items.

Objectives
Create an API that can CRUD against a Database
practice creating ASP.NET Web API endpoints
practice EF Core.
Working with docker
Requirements
Create a simple API that has a handful of endpoints to manage data
The API should be using Web API Controllers, Ef Core, and Postgres database
deploy your app to Heroku
Explorer Mode
Create a new sdg-api project using the dotnet CLI, have fun with the name and what items the shop sells.

Create a Model for an item in the shop. This will be your database table structure.

The Item should have at least

Id
SKU
Name
Short description
NumberInStock
Price
DateOrdered
Create a GET endpoint for all items in your inventory

Create a GET endpoint for each item

Create a POST endpoint that allows a client to add an item to the inventory

Create a PUT endpoint that allows a client to update an item

Create a DELETE endpoint that allows a client to delete an item

Create a GET endpoint to get all items that are out of stock

Create a GET endpoint that allows them to search for an item based on SKU

Deploy your app to heroku

Update the inventory
The store that had you built the API loves it so much, and it caused the store to become more successful and open up multiple locations.

We need to update our API to accommodate many locations. This means we have to add a new Model and new a relationship to our diagrams.

Objectives
Extend your API to not only track inventory, but also track how much we have at each location.
practice creating ASP.NET Web API endpoints
practice EF Core.
practice SQL Relationships
Requirements
Create a simple API that has a handful of endpoints to manage data
The API should be using Web API Controllers, Ef Core, and Postgres database
The API now has 2 models.
Explorer Mode
Create a Model for the Locations

The Locations should have at least

Id
Address
ManagerName
PhoneNumber
Add a relationship to your Item model to include a Foreign Key to the Locations table. Each location can have many items. There are now two new properties to your Existing Item model that points to the new Model you create (Location)

Add a new Locations Controller. This controller has at least 2 endpoints

A POST endpoint that allows a user to create a location
A GET endpoint that gets all locations
Update the following endpoints.

Update the GET all items endpoint to need a location
Update the GET endpoint for each item to need a location
Update the POST endpoint that allows a user/client to add an item to the inventory to a location
Update the PUT endpoint that allows a user/client to update an item for a location
Update the DELETE endpoint that allows a user/client to delete an item for a location
Add a new GET endpoint to get all items that are out of stock for a location. Keep you old GET endpoint for out of stock, but create a new one
Update the GET endpoint that allows the user to search for an item based on SKU, and this should search all the locations.
Deploy your update to Heroku
