# App-DotNetCore

This project was created with .Net Core 3.1 using Visual Studio 2019

## Development server

1. Open Visual Studio and run the application by selecting IIS Express.
2. Navigate to `http://localhost:5000/taxirides`. The app will present some default values using  TaxiRideModel.cs

## Note  
1. TaxiRideModel.cs and TaxiFareModel.cs are the main models of the application
2. Ultimately, goal is to start angular app as client and start this repo’s project as server. Then from angular app, we can access the endpoints on the dotNetCore side. However, despite some workarounds, the CORS notice still appears in Chrome/Microsoft Edge.

## Future
1. Resolve CORS issue to communicate between the Angular clent side and Dotnet server side
2. Database connectivity
3. Add complete CRUD http endpoints -- create, read, update, delete.
4. Authentication/authorization
5. Load balancing. To make system more fault tolerant when there is a huge amount of accesses in short period
