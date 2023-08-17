# &#x1F408; Cat Breeds &#x1F408;

### A Cat Breed API

#### _By_ Alesandria Wild, Casey Hill, Eva K., Jase Grable, Joshua Khan, Thomas Bakken, Bannakaffalatta
<br>

##### ...._"The cat does not offer services. The cat offers itself."_ - William S. Burroughs

## **Technologies Used**

- C#
- .NET 6
- Entity Framework Core version 6.0
- EFCore Design
- EFCore Migration
- Razor
- MySql
- Git
- Swagger

## **Description**

Cats.

<br>

## **Setup/Installation Requirements** &#x1F4BB;

<details>
<summary> Initial Setup </summary>

- Clone this repository to your local machine.
  ```bash
  $ git clone https://github.com/_____
  ```
- Open VS Code (or your IDE of choice).
- Open the top level directory you just cloned.
</details>

<details>
<summary> Database Setup </summary>

- Use a MySql RDBMS (like MySql Workbench) to import/upload the ______.sql file and create your database.
- In your CatBreed Directory, create a file with the name `appsettings.json` and copy and past the following code into this file:

  <pre><code>{
      "Logging": {
          "LogLevel": {
          "Default": "Information",
          "Microsoft.AspNetCore": "Warning"
          }
      },
      "AllowedHosts": "*",
      "ConnectionStrings": {
          "DefaultConnection": "Server=localhost;Port=3306;catbreed_api;uid=[YOUR_UID];pwd=[YOUR_PASSWORD];"
      }
  }</code></pre>

- Use your personal UID and Password for your db connection and make sure you remove the brackets currently in place.
</details>

<details>
<summary> Finish Setup </summary>

- In your terminal:

  Change directory (cd) to CatBreed.

  ```bash
  $ dotnet build
  ```

  ```bash
  $ dotnet ef migrations add Initial
  ```

  ```bash
  $ dotnet ef database update
  ```

  ```bash
  $ dotnet run
  ```

  (or `dotnet watch run` to see edit and see edits in real time).

- A web page will automatically open in your browser at port 5000 or 5001
</details>

<br>

## API

<details>
<summary>Endpoints</summary>

<span style="color: green; font-style: italic;">GET</span> /api/
<br>
<span style="color: purple; font-style: italic;">POST</span> /api/
<br>
<span style="color: orange; font-style: italic;">PUT</span> /api/
<br>
<span style="color: red; font-style: italic;">DELETE</span> /api/
<br>

</details>

<br>

## Debugging

<details>
<summary> If the program does not run...</summary>

- Make sure you have the appropriate packages installed to run dotnet

  - In your Terminal, enter the following commands:<br>
    ```bash
    $ dotnet tool install --global dotnet-ef --version 6.0.0
    ```
    ```bash
    $ dotnet add package Microsoft.EntityFrameworkCore -v 6.0.0
    ```
    ```bash
    $ dotnet add package Pomelo.EntityFrameworkCore.MySql -v 6.0.0
    ```
    ```bash
    $ dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.0
     ```

- To overwrite a different version of .NET to .NET 6, Try creating a `global.json` file in the Factory dir that contains the following code to override the default version, if your version exceeds .NET 6.0:<br>
  <pre><code>{
      "sdk": {
          "version": "6.0.402"
      }
  }
  </code></pre>

</details>

<br>

## **Known Bugs**

no, cats.

<br>

## License

Please contact [bannakaffalatta@titanic.cyborg](mailto:bannakaffalatta@titanic.com?subject=Hello%20bannakaffalatta,&body=Look%20can%20I%20just%20call%20you%20Banna?%20%20It's%20going%20to%20save%20a%20lot%20of%20time.)
with any the following:

- Found bugs &#x1F41E;
- General Questions
<details>
<summary>Where is Kylie Minogue?</summary>

- [Astrid Peth](https://en.wikipedia.org/wiki/Astrid_Peth)

</details>
<br><br><br>

<img src="https://static.wikia.nocookie.net/moviemorgue/images/9/98/Banna.jpg/revision/latest?cb=20141024211535" alt="Bannakaffalatta" style="max-width: 100px;"><img src="https://static.wikia.nocookie.net/moviemorgue/images/9/98/Banna.jpg/revision/latest?cb=20141024211535" alt="Bannakaffalatta" style="max-width: 100px;"><img src="https://static.wikia.nocookie.net/moviemorgue/images/9/98/Banna.jpg/revision/latest?cb=20141024211535" alt="Bannakaffalatta" style="max-width: 100px;"><img src="https://static.wikia.nocookie.net/moviemorgue/images/9/98/Banna.jpg/revision/latest?cb=20141024211535" alt="Bannakaffalatta" style="max-width: 100px;"><img src="https://static.wikia.nocookie.net/moviemorgue/images/9/98/Banna.jpg/revision/latest?cb=20141024211535" alt="Bannakaffalatta" style="max-width: 100px;"><img src="https://static.wikia.nocookie.net/moviemorgue/images/9/98/Banna.jpg/revision/latest?cb=20141024211535" alt="Bannakaffalatta" style="max-width: 100px;">
