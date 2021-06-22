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
using System.Data.SqlClient;

namespace DapperCRUDExample
{
    public partial class ManageMovies : Form
    {
        int Id = 0;
        List<Director> director = new List<Director>();
        List<Genre> genre = new List<Genre>();
        public ManageMovies()
        {
            InitializeComponent();
        }

       
        private void ManageMovies_Load(object sender, EventArgs e)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("MovieDatabaseDB")))
            {
                
                genre = connection.Query<Genre>("SELECT * FROM Genres", null).ToList();
                cmbxGenres.DataSource = genre;
                cmbxGenres.ValueMember = "GenreId";
                cmbxGenres.DisplayMember = "GenreName";
                

                director = connection.Query<Director>("SELECT DirectorId, FirstName, LastName FROM Directors", null).ToList();
                cmbxDirectors.DataSource = director;
                cmbxDirectors.ValueMember = "DirectorId";
                cmbxDirectors.DisplayMember = "DirectorFullName";
            }

            try
            {
                FillMovieDataGridView();
                Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnMovieSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("MovieDatabaseDB")))
                {
                    // assign directorId of selected director from combobox
                    var directorId = int.Parse(cmbxDirectors.SelectedValue.ToString());
                    var genreId = int.Parse(cmbxGenres.SelectedValue.ToString());
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@Id", Id);
                    param.Add("@DirectorId", directorId);
                    param.Add("@Title", txtMovieTitle.Text.Trim());
                    param.Add("@ReleaseYear", Convert.ToInt32(txtReleaseYear.Text));
                    param.Add("@Rating", float.Parse(txtRating.Text));
                    param.Add("@MovieLength", float.Parse(txtLength.Text));


                    //connection.Execute("INSERT INTO MovieGenres(MovieId,GenreId) VALUES(Id, genreId) ");
                    

                    connection.Execute("Movie_InsertOrEdit", param, commandType: CommandType.StoredProcedure);
                    if (Id == 0)
                    {
                        MessageBox.Show(txtMovieTitle.Text + " added successfully!");
                    }
                    else
                    {
                        MessageBox.Show(txtMovieTitle.Text + " updated successfully!");
                    }
                    string movieTitle = txtMovieTitle.Text;
                    string selectMovieId = "SELECT Id FROM Movies WHERE Title = '" + movieTitle + "';";
                    var selectedMovieId = connection.Query<Movie>(selectMovieId).FirstOrDefault();
                    
                    string insertToMovieGenres = "INSERT INTO MovieGenres(MovieId, GenreId) VALUES ( " + selectedMovieId.Id + "," + genreId + ");";
                    
                    connection.Execute(insertToMovieGenres);
                    FillMovieDataGridView();
                    Clear();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Pulls the data from SQL Server with Dapper and fills the corresponding DataGridView
        /// </summary>
        private void FillMovieDataGridView()
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@SearchText", txtMovieSearch.Text.Trim());

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("MovieDatabaseDB")))
            {
                List<Movie> movieList = connection.Query<Movie>("Movie_ViewAllOrSearchByTitle", param,
                    commandType: CommandType.StoredProcedure).ToList<Movie>();

                dgvMovies.DataSource = movieList;

                // Hide the DirectorId
                dgvMovies.Columns[0].Visible = false;
            }
        }

        private void Clear()
        {
            txtMovieTitle.Text = txtRating.Text = txtLength.Text = txtReleaseYear.Text = "";
            Id = 0;
            btnMovieSave.Text = "Save";
            btnMovieDelete.Enabled = false;
        }

        private void btnMovieCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnGoToHome_Click(object sender, EventArgs e)
        {
            HomePage homepage = new HomePage();
            homepage.Show();
            Hide();
        }

        private void btnDirectorSearch_Click(object sender, EventArgs e)
        {
            try
            {
                FillMovieDataGridView();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvMovies_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvMovies.CurrentRow.Index != -1)
                {
                    Id = Convert.ToInt32(dgvMovies.CurrentRow.Cells[0].Value.ToString());
                    txtMovieTitle.Text = dgvMovies.CurrentRow.Cells[2].Value.ToString();
                    txtReleaseYear.Text = dgvMovies.CurrentRow.Cells[3].Value.ToString();
                    txtRating.Text = dgvMovies.CurrentRow.Cells[4].Value.ToString();
                    txtLength.Text = dgvMovies.CurrentRow.Cells[5].Value.ToString();
                    btnMovieDelete.Enabled = true;
                    btnMovieSave.Text = "Edit";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnMovieDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // assign selected movie's id to delete it from MovieGenres table
                int movieId = Convert.ToInt32(dgvMovies.CurrentRow.Cells[0].Value.ToString());

                DynamicParameters param = new DynamicParameters();
                param.Add("@Id", Id);
                param.Add("@MovieId", movieId);
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("MovieDatabaseDB")))
                {
                    connection.Execute("Movie_DeleteById", param, commandType: CommandType.StoredProcedure);
                    Clear();
                    FillMovieDataGridView();
                    MessageBox.Show("Movie Deleted Successfully!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
