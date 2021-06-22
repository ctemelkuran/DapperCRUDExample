using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DapperCRUDExample
{
    public class DataAccessMovieActors
    {
        public List<Actor> GetActor(string lastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("MovieDatabaseDB")))
            {
                var actorList = connection.Query<Actor>("Actor_ViewAllSearchByLastName @LastName", new { LastName = lastName }).ToList();
                return actorList;

            }
        }

        public List<Movie> GetMovie(string title)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("MovieDatabaseDB")))
            {
                var movieList = connection.Query<Movie>("Movie_ViewAllOrSearchByTitle @Title", new { Title = title }).ToList();
                return movieList;
            }
        }

        public void InsertMovieActors(string title, string lastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("MovieDatabaseDB")))
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Title", title);
                param.Add("@LastName", lastName);
                connection.Execute("MovieActors_InsertMovieAndActor", param, commandType: CommandType.StoredProcedure);

            }
        }
    }
}
