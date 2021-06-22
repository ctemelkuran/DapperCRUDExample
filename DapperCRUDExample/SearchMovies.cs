using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DapperCRUDExample
{
    public partial class SearchMovies : Form
    {
        public SearchMovies()
        {
            InitializeComponent();
        }

        private void btnGoToHome_Click(object sender, EventArgs e)
        {
            HomePage homepage = new HomePage();
            homepage.Show();
            Hide();
        }

        private void btnMovieSearch_Click(object sender, EventArgs e)
        {
            int count = 0;
            string title = txtMovieTitle.Text;
            string year = txtReleaseYear.Text;
            string rating = txtRating.Text;
            string length = txtLength.Text;
            string genre = txtMovieGenre.Text;
            string director = txtMovieDirector.Text;

            string query = "SELECT DISTINCT dbo.Movies.Title, dbo.Movies.ReleaseYear, dbo.Movies.Rating, dbo.Movies.MovieLength," +
                " dbo.Genres.GenreName, dbo.Directors.FirstName, dbo.Directors.LastName " +
                "FROM dbo.MovieGenres INNER JOIN dbo.Genres ON dbo.MovieGenres.GenreId = dbo.Genres.GenreId " +
                "INNER JOIN dbo.Movies ON dbo.MovieGenres.MovieId = dbo.Movies.Id INNER JOIN dbo.Directors " +
                "ON dbo.Movies.DirectorId = dbo.Directors.DirectorId ";

            if (title != "")
            {
                query += "WHERE Movies.Title LIKE '%" + title + "%' ";
                count++;
            }
            if (year != "")
            {
                if (count != 0)
                {
                    query += "AND ";
                }
                else
                {
                    query += "WHERE ";
                }
                query += "Movies.ReleaseYear > " + year + " ";
                count++;
            }
            if (rating != "")
            {
                if (count != 0)
                {
                    query += "AND ";
                }
                else
                {
                    query += "WHERE ";
                }
                query += " Rating > " + rating + " ";
                count++;
            }

            if (length != "")
            {
                if (count != 0)
                {
                    query += "AND ";
                }
                else
                {
                    query += "WHERE ";
                }
                query += " Movies.MovieLength < " + length + " ";
                count++;
            }
            if (genre != "")
            {
                if (count != 0)
                {
                    query += "AND ";
                }
                else
                {
                    query += "WHERE ";
                }
                query += " Genres.GenreName LIKE '%" + genre + "%' ";
                count++;
            }
            if (director != "")
            {
                if (count != 0)
                {
                    query += "AND ";
                }
                else
                {
                    query += "WHERE ";
                }
                query += " Directors.FirstName LIKE '%" + director + "%' ";
                
            }
            query += ";";

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("MovieDatabaseDB")))
            {
                var searchList = connection.Query<MovieSearch>(query).ToList();
                dgvMovies.DataSource = searchList;
            }

        }
        class MovieSearch
        {
            public string Title { get; set; }
            public int ReleaseYear { get; set; }
            public float Rating { get; set; }
            public float MovieLength { get; set; }
            public string GenreName { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            
        }
    }
}
