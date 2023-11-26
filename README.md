# Taste

#### By: Elena Rosa

## Description
An application with user authentication. This application allows for a bakery manager to keep track of his guests sweet and savory treats.   

## Technologies Used
- C#
- ASP.NET Core MVC
- .NET 5.0
- Entity Framework Core
- Identity for ASP.NET Core
- HTML
- CSS


## Setup/Installation Requirements
- Note: An installation of the .NET SDK is required in order to run this application locally. [See Here](https://dotnet.microsoft.com/en-us/) for installation.
1. Clone this repo.
2. Open your shell (e.g., Terminal or GitBash) and navigate to this project's directory called "Factory.Solution/Factory". 
3. Create a file named `appsettings.json`: `$ touch appsettings.json`
4. Within `appsettings.json` add the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL.

    ```json
    {
      "ConnectionStrings": {
          "DefaultConnection": "Server=localhost;Port=3306;database=Factory-database;uid=[YOUR-USERNAME];pwd=[YOUR-MYSQL-PASSWORD];"
      }
    }
    ```

5. Navigate to the project directory: `$ cd Factory`

6. Run the command dotnet restore to install necessary packages.

7. Run `$ dotnet watch run` in the command line to start the project in development mode with a watcher.

8. Run the command dotnet build to compile the application.

9. Run dotnet run to start the server and application.

10. Open the browser at: _https://localhost:5001_. If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS. 

11. This application used authentication with Identity. Users must create an account in order to create and edit items. 

12. Enjoy!

## Known Bugs
- Please visit this projects [GitHub repository](https://github.com/Elena-Rosa/Taste.git) to submit Issues and Pull Requests.

## License
MIT License

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

Copyright (c) Elena Rosa 2023 