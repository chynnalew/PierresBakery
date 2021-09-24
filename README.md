# Pierre's Bakery

#### A console application that allows users to see the price of different amounts of bread and pastries, accounting for specified discounts

#### Created By: Chynna Lew

## Technologies Used

* C#
* .NET 5
* MSTest
* NuGet

## Description

This application was created as a week 8 independent project for Epicodus. This purpose of this application is to show an understanding and correct use of namespaces, classes, auto-implemented properties, and Test Driven Development in C#.
This console application is a fake bakery where users can enter how many "bread", "pastry", and "pie" items they would like to purchase and are returned the total cost. A single loaf of bread costs $5 with a buy 2 get 1 free discount. A "pastry" costs $2, with a 3 for $5 deal. A "pie" costs $10, with no special discounts.

## Setup and Usage Instructions

### Technology Requirements

* Download and install [.NET 5](https://dotnet.microsoft.com/download/dotnet/5.0)
* Download and install a code text editor. Ex: [VS Code](https://code.visualstudio.com/)

### Installation

* Clone [this](https://github.com/chynnalew/PierresBakery) repository, or download and open the Zip on your local machine
* Open the `PierresBakery.Solution` folder in your preferred text editor
* Restore and build the project:
  - Navigate to the `PierresBakery.Solution/PierresBakery `folder in the command line or terminal 
    -- Run the command `$ dotnet restore` to restore the project dependencies
    -- Run the command `$ dotnet build` to build and compile the project
  - Navigate to the `PierresBakery.Solution/PierresBakery.Tests` folder in the command line or terminal 
    -- Run the command `$ dotnet restore` to restore the test project dependencies
    -- Run the command `$ dotnet build` to build and compile the test project
* To run the tests:
  - You must restore and build the project first, as outlined previously in these instructions.
  - In the terminal (navigated to the `PierresBakery.Solution/PierresBakery.Tests` folder) run the command `$ dotnet test`
* To run the console application:
  - Navigate to the `PierresBakery.Solution/PierresBakery` folder in the terminal
  - Run the command `$ dotnet run` 
  - The application will run in the console
* Note: `$ dotnet run` will automatically restore and build the application.

## Known Bugs

* no known bugs

### License

[MIT License](https://opensource.org/licenses/MIT)
Copyright 2021 Chynna Lew

## Support and contact details

* [Chynna Lew](github.com/chynnalew) 
* <chynnalew@yahoo.com>