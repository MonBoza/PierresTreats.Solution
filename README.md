# Pierre's Treats

## By Monica Barboza

### An C# and ASP.NET Core Mvc application for Pierre's to market his sweet and savory treats

## Technologies Used

* C#
* ASP.NET
* MS TEST
* Bootstrap
* MySQL
* MySQL Workbench
* EF Core
* ASP.NET Core MVC
* Entity Framework Core Identity

## Description

How to Use:

* User must first register to add update and view Treats and Flavors in this application.

To Register:

* Simply click the register button put your email address and create a password, log in and enjoy!

Treat Management:

* Add new treat by providing the name and quantity.
* Edit existing treats details as needed.

Flavor Management:

* Add flavor by their names and link them to specific treat. Update flavor information as preferences change.

Search Function:

* Use the search button to quickly find treats or flavors based on keywords.

## Setup/Installation Requirements

This Project assumes you have MySql Server and Workbench  installed if you do not have them installed follow along with these lessons at
[Learn how to program](https://full-time.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql).

1. Open terminal or command prompt.
2. Clone the repository by running the following command to your desktop:

    ```bash
    git clone https://github.com/MonBoza/PierresTreats.Solution.git
     ```

3. Open the project in your favorite code editor.

4. Navigate to the production directory "PierresTreats" and run the follow commands in your terminal to add the following dependencies

    ```bash
    dotnet add package Microsoft.EntityFrameworkCore -v 6.0.0
    ```

    ```bash
    dotnet add package Pomelo.EntityFrameworkCore.MySql -v 6.0.0
    ```

5. To configure Identity to work with EF Core run the following command to install package

    ```bash
    dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore -v 6.0.0
    ```

6. Within the production directory `PierresTreats`, create new file called `appsettings.json`

7. Make sure appsettings.json is added to the .gitignore file and it is added to the repository before pushing with your personal information.

8. Within `appsettings.json`, put in the following code replacing the `uid` and the `pwd` values with your own username and password for MySQL.

    ```bash
    {
      "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=pierres_treats;uid=[YOUR-USER-HERE];pwd=[YOUR-PASSWORD-HERE];"
      }
    }
    ```

9. To Setup the database run the following command in your terminal

    ```bash
    dotnet ef database update
    ```

10. Run  command in your terminal

    ```bash
    dotnet watch run 
    ```

## To set up Database

* Run the following command in your terminal

    ```bash
    dotnet ef database update
    ```

## Known Bugs

* No Known bugs
  * If bugs are discovered please contact the author

## License

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

Email: (mailto:<MonBoza@gmail.com>)

Copyright (c) February 16, 2024 Monica Barboza