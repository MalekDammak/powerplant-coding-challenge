# Powerplant coding challenge
Calculate how much power each of a multitude of different powerplants need to produce when the load is given and taking into account the cost of the underlying energy sources (gas,  kerosine) and the Pmin and Pmax of each powerplant.


# Run & Test

## Microsoft Visual Studio
1. Open the project in Visual Studio.

2. Build the project by clicking "Build" in the Visual Studio menu.

3. Set the startup project to the main application.

4. Click "Start Debugging" to run the project.


## Building and Running with Command-Line Tools
1. Open a terminal or command prompt.

2. Navigate to the project directory.

```bash
cd powerPlantCodingChallenge
```

3. Build the project:

```bash
dotnet build  powerPlantCodingChallenge.sln
```
4. Run the project:
   
```bash
dotnet run  powerPlantCodingChallenge.sln
```
### Swagger UI
In development mode, you can explore the API using Swagger documentation:
1. Open a web browser and navigate to the following URL:  http://localhost:8888/swagger/index.html
## Building and Running with Docker

1. Make sure Docker is installed on your system.

2. Open a terminal or command prompt.

3. Navigate to the project directory.
   
```bash
cd powerPlantCodingChallenge
```
4. Build the Docker image:
```bash
docker build -t power-challenge .
```
6. Run the Docker image:
   
```bash
docker run -it -p 8888:8888 power-challenge power-challenge-api
```
7. Test The production plan api

* Production Plan Url : http://localhost:8888/productionplan


## Running Tests

You can run tests for this project using Microsoft Visual Studio's built-in test runner. 

1. Open the project's solution file (powerPlantCodingChallenge.Tests) in Microsoft Visual Studio.

2.  Build the solution.

3. Open the Test Explorer:
   - Go to the "Test" menu in Visual Studio.
   - Select "Test Explorer" to open the Test Explorer window.
   - Run All Tests

