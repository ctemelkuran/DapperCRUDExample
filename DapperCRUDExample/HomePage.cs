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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }


        private void btnGoToActors_Click(object sender, EventArgs e)
        {
            ManageActors manageActors = new ManageActors();
            manageActors.Show();
            Hide();
        }

        private void btnGoToDirectors_Click(object sender, EventArgs e)
        {
            ManageDirectors manageDirectors = new ManageDirectors();
            manageDirectors.Show();
            Hide();
        }

        private void btnGoToMovies_Click(object sender, EventArgs e)
        {
            ManageMovies manageMovies = new ManageMovies();
            manageMovies.Show();
            Hide();
        }

        private void btnSearchMovies_Click(object sender, EventArgs e)
        {
            SearchMovies searchMovies = new SearchMovies();
            searchMovies.Show();
            Hide();
        }
    }
}
