# Movie Town Database Management System Project

Developed in .NET Framework 4.8, using SQL Server and Dapper NuGet.

### Why Dapper?
Because it is "King of Micro ORM" in terms of speed and performance. Also, it is developed by Stack Overflow developers and doesn't going anywhere any time soon.
Implementation is relatively simple than Entity Framework and ADO.NET for a small project. It can work after three-step process:
- Create an IDbConnection object.
- Write a query to perform CRUD operations.
- Pass query as a parameter in the Execute method.

```csharp
  public List<Movie> GetMovie(string title)
  {
      using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("MovieDatabaseDB")))
      {
          var movieList = connection.Query<Movie>("Movie_ViewAllOrSearchByTitle @Title",
              new { Title = title }).ToList();
          return movieList;
      }
  }
```
--------------
### Movie Town Interface
![Home][homepage]
![ui][ui]

[homepage]: images/MovieTown_Homepage.png "MovieTown_Homepage"
[ui]: images/MovieTown_UI2.png "MovieTown_UI2"
