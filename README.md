
<br>
<p align="center">
  <u><big>|| <b>Animal Shelter</b> ||</big></u>
</p>
    <p align="center">
      ___________________________
    </p>
    <!-- GitHub Link -->
    <p align="center">
        <a href="https://github.com/beads89">
            <strong>Brandon Eads</strong>
        </a>
    </p>
    <!-- Project Shields -->
   

<p align="center">
  <small>Initiated October 29th, 2021.</small>
</p>

<!-- Project Links -->
<p align="center">
    <a href="https://github.com/beads89/animal-shelter/"><big>Project Docs</big></a> ·
    <a href="https://github.com/beads89/animal-shelter/issues"><big>Report Bug</big></a> ·
    <a href="https://github.com/beads89/animal-shelter/issues"><big>Request Feature</big></a>
</p>

------------------------------
### <u>Table of Contents</u>
* <a href="#🌐-about-the-project">About the Project</a>
    * <a href="#📖-description">Description</a>
    * <a href="#🦠-known-bugs">Known Bugs</a>
    * <a href="#🛠-built-with">Built With</a>
    <!-- * <a href="#🔍-preview">Preview</a> -->
* <a href="#🏁-getting-started">Getting Started</a>
    * <a href="#📋-prerequisites">Prerequisites</a>
    * <a href="#⚙️-setup-and-use">Setup and Use</a>
* <a href="#🛰️-api-documentation">API Documentation</a>
* <a href="#🤝-contributors">Auxiliary</a>
    * <a href="#🤝-contributors">Contributors</a>
    * <a href="#✉️-contact-and-support">Contact</a>
    * <a href="#⚖️-license">License</a>
    * <a href="#🌟-acknowledgements">Acknowledgements</a>
    
------------------------------

## 🌐 About the Project

### 📖 Description
This API uses RESTful principles to create an animal shelter that houses a number of cats and dogs, integrated is Swagger for documentation purposes. Full CRUD has been implemented for both API parameters of Cats and Dogs and is enabled via Swagger. A working MVC is in progress.

### 🦠 Known Bugs

* This is not a real API, which is the greatest shame of all.
* Front-end AnimalClient view is not currently supported. If an instruction includes both AnimalShelter and AnimalClient, please only pay mind to AnimalShelter. All steps involving AnimalClient can safely be ignored, current views will return a 404 not found. 

### 🛠 Built With
* [.NET 5](https://dotnet.microsoft.com/download/dotnet/5.0)
* [Visual Studio Code](https://code.visualstudio.com/)
* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [ASP.NET Core MVC](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-3.1)
* [MySQL](https://dev.mysql.com/)
* [Entity Framework Core 5.0.0](https://docs.microsoft.com/en-us/ef/core/)
* [Swagger - Swashbuckle 6.2.3](https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-nswag?view=aspnetcore-3.1&tabs=visual-studio)
* [Postman](postman.com)

<!-- ### 🔍 Preview -->

------------------------------

## 🏁 Getting Started

### 📋 Prerequisites

#### Install .NET Core
* On macOS Mojave or later
  * [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download the .NET Core SDK from Microsoft Corp for macOS.
* On Windows 10 x64 or later
  * [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp for Windows.

#### Install dotnet script
 Enter the command ``dotnet tool install -g dotnet-script`` in Terminal for macOS or PowerShell for Windows.

#### Install MySQL Workbench
 [Download and install the appropriate version of MySQL Workbench](https://dev.mysql.com/downloads/workbench/).

#### Install Postman
(Optional) [Download and install Postman](https://www.postman.com/downloads/).

#### Code Editor

  To view or edit the code, you will need an code editor or text editor. This project was created in Visual Studio Code.

  1) Code Editor Download:
     * [Visual Studio Code](https://code.visualstudio.com/)
  2) Click the download most applicable to your OS and system.
  3) Wait for download to complete, then install -- Windows will run the setup exe and macOS will drag and drop into applications.
  4) Optionally, create a [GitHub Account](https://github.com)

### ⚙️ Setup and Use

  #### Cloning

  1) Navigate to the [AnimalShelter API repository here](https://github.com/beads89/animal-shelter).
  2) Click 'Clone or download' to reveal the HTTPS url ending with .git and the 'Download ZIP' option.
  3) Open up your system Terminal or GitBash, navigate to your desktop with the command: `cd Desktop`, or whichever location suits you best.
  4) Clone the repository to your desktop: `$ git clone https://github.com/beads89/animal-shelter.git`
  5) Run the command `cd AnimalShelter.Solution` to enter into the project directory.
  6) View or Edit:
      * Code Editor - Run the command `code .` to open the project in Visual Studio Code respectively for review and editing.
      * Text Editor - Open by double clicking on any of the files to open in a text editor.

  #### Download

  1) Navigate to the [AnimalShelter API repository here](https://github.com/beads89/animal-shelter).
  2) Click 'Clone or download' to reveal the HTTPS url ending with .git and the 'Download ZIP' option.
  3) Click 'Download ZIP' and unextract.
  4) Open by double clicking on any of the files to open in a text editor.

  #### Enabling the View

  1) Repeat the above Setup and Use steps for the AnimalShelter front-end repository, [AnimalClient](https://github.com/beads89/Animal-Client).

  #### AppSettings

  1) Create a new file in the AnimalShelter.Solution/AnimalShelter and the AnimalClient.Solution/AnimalClient directories named `appsettings.json`
  2) Add in the following code snippet to the new appsettings.json file:
  * **AnimalShelter.Solution/AnimalShelter:**
  ```
{
  "Logging": {
      "LogLevel": {
      "Default": "Warning"
      }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=animal_shelter;uid=root;pwd=YourPassword;"
  }
}
  ```
  * **AnimalClient.Solution/AnimalClient:**
  ```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Port=3306;database=animal_shelter;uid=root;pwd=YourPassword;"
  }
}
  ```

  3) Change the server, port, and user id as necessary. Replace 'YourPassword' with relevant MySQL password (set at installation of MySQL).

  #### Database
  1) Navigate to AnimalShelter.Solution/AnimalShelter directory using the MacOS Terminal or Windows Powershell (e.g. `cd Desktop/AnimalShelter.Solution/AnimalShelter`).
  2) Run the command `dotnet restore` to recover any missing dependencies required to build the database.
  3) Run the command `dotnet ef database update` to generate the database through Entity Framework Core.
  4) (Optional) To update the database with any changes to the code, run the command `dotnet ef migrations add <MigrationsName>` which will use Entity Framework Core's code-first principle to generate a database update. After, run the previous command `dotnet ef database update` to update the database.
  5) Repeat steps 1 and 2 for AnimalClient.Solution/AnimalClient.

  #### Launch the API
  1) Navigate to AnimalShelter.Solution/AnimalShelter directory using the MacOS Terminal or Windows Powershell (e.g. `cd Desktop/AnimalShelter.Solution/AnimalShelter`).
  2) Run the command `dotnet run` to have access to the API in Postman or browser.
  3) Repeat the above steps for AnimalClient.Solution/AnimalClient.

------------------------------

## 🛰️ API Documentation
Explore the API endpoints in Postman or a browser.

### Using Swagger Documentation
To explore the AnimalShelter.Solution API with NSwag, launch the project using `dotnet run` with the Terminal or Powershell, and input the following URL into your browser: `http://localhost:5000/swagger`



..........................................................................................

### Endpoints
Base URL: `http://localhost:5000`  
Cats: `http://localhost:5000/api/cats`  
Dogs: `http://localhost:5000/api/dogs`

#### HTTP Request Structure
```
GET /api/{component}
POST /api/{component}
GET /api/{component}/{id}
PUT /api/{component}/{id}
DELETE /api/{component}/{id}
```

#### Example Query
```
http://localhost:5000/api/cats/1
```

#### Sample JSON Response
```
  {
    "catId": 1,
    "catName": "Toey",
    "catGender": "Female",
    "catBreed": "Chocolate York",
    "catColor": "Black, Grey"
  }
```

..........................................................................................

### Cats
Access the list of cats in the API.

#### HTTP Request
```
GET /api/cats
POST /api/cats
GET /api/cats/{id}
PUT /api/cats/{id}
DELETE /api/cats/{id}
```

#### Path Parameters
| Parameter | Type | Default | Required | Description |
| :---: | :---: | :---: | :---: | --- |
| name | string | none | false | Return matches by name. |
| gender | string | none | false | Return matches based on gender. |
| breed | string | none | false | Return matches containing the specified breed. |
| color | string | none | false | Return cats that contain the specified color. |

#### Example Query
```
http://localhost:5000/api/cats?name=bigglesworth&gender=male&breed=sphynx&color=naked
```

#### Sample JSON Response
```
{
  "catId": 4,
  "catName": "Mr. Bigglesworth",
  "catGender": "Male",
  "catBreed": "Sphynx",
  "catColor": "Naked"
}
```

------------------------------
### Dogs
Access the list of dogs in the API.

#### HTTP Request
```
GET /api/dogs
POST /api/dogs
GET /api/dogs/{id}
PUT /api/dogs/{id}
DELETE /api/dogs/{id}
```

#### Path Parameters
| Parameter | Type | Default | Required | Description |
| :---: | :---: | :---: | :---: | --- |
| name | string | none | false | Return matches by name. |
| gender | string | none | false | Return matches based on gender. |
| breed | string | none | false | Return matches containing the specified breed. |
| color | string | none | false | Return dogs that contain the specified color. |

#### Example Query
```
http://localhost:5000/api/dogs?name=clifford&gender=male&breed=mixed&color=red
```

#### Sample JSON Response
```
{
  "dogId": 3,
  "dogName": "Clifford",
  "dogGender": "Male",
  "dogBreed": "Mixed, Vizsla, Hound, Bloodhound",
  "dogColor": "Red"
}
```

------------------------------

### 🤝 Contributors

| Author | GitHub | Email |
|--------|:------:|:-----:|
| [Brandon Eads](https://www.linkedin.com/in/brandoneads/) | [Beads89](https://github.com/beads89/) | [brandon181989@hotmail.com](mailto:brandon181989@hotmail.com) |

------------------------------

### ✉️ Contact and Support

If you have any feedback or concerns, please contact me.

<p>
    <a href="https://github.com/beads89/animal-shelter/issues">Brandon Eads</a>
</p>

------------------------------

### ⚖️ License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT). Copyright (C) 2021 Brandon Eads. All Rights Reserved.

```
MIT License

Copyright (c) 2021 Brandon Eads.

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```

------------------------------

### 🌟 Acknowledgments

#### [Epicodus](https://www.epicodus.com/)
>"A school for tech careers... to help people learn the skills they need to get great jobs."

------------------------------

<center><a href="#">Return to Top</a></center>