# ReactJsMaterilUICSharpCoreApi
Full Stack React Js Material UI CRUD Front End consume C# Wep API Core Backend [MSSQL]

## Donation

If this project helped you reduce time to develop, please consider buying me a cup of coffee :)

<a href="https://www.buymeacoffee.com/ongyishen" 
target="_blank">
<img src="https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png" 
alt="Buy Me A Coffee" style="height: 41px !important;width: 174px !important;box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;-webkit-box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;" ></a>

------

## Mssql Database

Create database with name **EmployeeDB**

------

## C# Asp.Net Core Web [BackEnd]

Change the database connection string at **appsetting.json**

```json
"ConnectionStrings": {
    "DevConnection": "Server =(local); Database=EmployeeDB; Trusted_Connection=True; MultipleActiveResultSets=True;"
  }
```

**Use EF Migrations**

In the Package Manager Console window, enter the following command:

update-database

**Package Manager Console Screenshot**
<img src="https://github.com/ongyishen/ReactJsMaterilUICSharpCoreApi/blob/main/SampleEF.PNG?raw=true" />

**DB Screenshot**

<img src="https://github.com/ongyishen/ReactJsMaterilUICSharpCoreApi/blob/main/SampleDB.PNG?raw=true" />

------
## React JS [Front End]

Change the Backapi API URL at api.js file

```javascript
import axios from "axios";

const baseUrl = "http://localhost:60671/api/"
```

Run (install all dependecies)

```bash
npm install
```

Start the front end

```bash
npm start
```

Frontend Screenshot

<img src="https://github.com/ongyishen/ReactJsMaterilUICSharpCoreApi/blob/main/Sample.gif?raw=true" />


------
### npm packages

- redux
- react-redux
- redux-thunk
- axios
- @material-ui/core
- @material-ui/icons
