# CINEMA-HALL-MANAGEMENT

build with c# ,and .net that can store movie,cinema hall and show imformation

# Dependencies

- **.Net freamwork version 3.5 ^**
- **visual studio 2012^**
- **c#**
- **My sql**

## How to run

### setup

1. open a database called "cinema_hall_management"
1. write all the querys from database schema in the database - (the highest number)
1. if the datasebase's port number is different than than '3306' , you can edit the MysqlConnetionString in DAL/DatabaseConnector

```csharp
String MysqlConnetionString = "datasource=127.0.0.1;port=<YOUR PORT NUMBER>;username=root;password=;database=cinema_hall_management;";
```

### run

1. open Visual stadio and run
2. to run the production version go to bin /release
