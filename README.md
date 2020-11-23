# ERPCore

## .netCore 3 POC

## Highlights

* CRUD
* Custom Tags (Pagination Tag)
* Entity Framework
* DI
* Razor pages

## Changing data store 
### Supported :
* In Memory
* SQLite
* MSSQL

```C#
   services.AddTransient<IEmployeeRepository, SqliteEmployeeRepository>();
   // services.AddTransient<IEmployeeRepository, MSqlEmployeeRepository>();
   // services.AddTransient<IEmployeeRepository, InMemoryEmployeeRepository>();
```

### Home Page
<kbd>![Screenshot](Screens/1.jpeg)</kbd>

### Employee list Page
<kbd>![Screenshot](Screens/2.jpeg)</kbd>

### Add Employee Page
<kbd>![Screenshot](Screens/3.jpeg)</kbd>

### Add Employee Page : Validation
<kbd>![Screenshot](Screens/4.jpeg)</kbd>

###  Employee list Page : Actions
<kbd>![Screenshot](Screens/5.jpeg)</kbd>

###  Employee detail Page
<kbd>![Screenshot](Screens/6.jpeg)</kbd>

###  Employee edit Page
<kbd>![Screenshot](Screens/7.jpeg)</kbd>

###  Employee list Page : Delete
<kbd>![Screenshot](Screens/8.jpeg)</kbd>

###  Employee list Page : Alert
<kbd>![Screenshot](Screens/9.jpeg)</kbd>
