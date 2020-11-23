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
![Screenshot](Screens/1.jpeg)

### Employee list Page
![Screenshot](Screens/2.jpeg)

### Add Employee Page
![Screenshot](Screens/3.jpeg)

### Add Employee Page : Validation
![Screenshot](Screens/4.jpeg)

###  Employee list Page : Actions
![Screenshot](Screens/5.jpeg)

###  Employee detail Page
![Screenshot](Screens/6.jpeg)

###  Employee edit Page
![Screenshot](Screens/7.jpeg)

###  Employee list Page : Delete
![Screenshot](Screens/8.jpeg)

###  Employee list Page : Alert
![Screenshot](Screens/9.jpeg)
