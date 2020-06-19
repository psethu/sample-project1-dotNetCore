# App-DotNetCore

This project was created with .Net Core 3.1

## Starting the server

1. Open Visual Studio and run the application by selecting IIS Express.
2. Navigate to `http://localhost:5000/taxirides`. The app will present some default values using  TaxiRideModel.cs

## Note  
1. TaxiRideModel.cs and TaxiFareModel.cs are the main models of the application
2. Ultimately, goal is to start angular app as client and start this repo’s project as server. Then from angular app, we can access the endpoints on the dotNetCore side. However, despite some workarounds, the CORS notice still appears in Chrome/Microsoft Edge.