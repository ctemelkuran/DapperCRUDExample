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
    public partial class ManageDirectors : Form
    {
        int directorId = 0;
        public ManageDirectors()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Save button for directors
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDirectorSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("MovieDatabaseDB")))
                {
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@DirectorId", directorId);
                    param.Add("@FirstName", txtDirectorFirstName.Text.Trim());
                    param.Add("@LastName", txtDirectorLastName.Text.Trim());
                    param.Add("@Nationality", txtDirectorNationality.Text.Trim());
                    param.Add("@Birth", Convert.ToInt32(txtDirectorBirthYear.Text));
                    connection.Execute("Director_InsertOrEdit", param, commandType: CommandType.StoredProcedure);
                    if (directorId == 0)
                    {
                        MessageBox.Show("Director " + txtDirectorFirstName.Text + " " + txtDirectorLastName.Text + " saved successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Director " + txtDirectorFirstName.Text + " " + txtDirectorLastName.Text + " updated successfully!");
                    }
                    FillDirectorDataGridView();
                    Clear();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void FillDirectorDataGridView()
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@SearchText", txtDirectorSearch.Text.Trim());

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("MovieDatabaseDB")))
            {
                List<Director> actorList = connection.Query<Director>("Director_ViewAllOrSearchByFirstName", param,
                    commandType: CommandType.StoredProcedure).ToList<Director>();

                dgvDirectors.DataSource = actorList;

                // Hide the DirectorId
                dgvDirectors.Columns[0].Visible = false;
                dgvDirectors.Columns[5].Visible = false;
            }
        }
        void Clear()
        {
            txtDirectorFirstName.Text = txtDirectorLastName.Text = txtDirectorNationality.Text = txtDirectorBirthYear.Text = "";
            directorId = 0;
            btnDirectorSave.Text = "Save";
            btnDirectorDelete.Enabled = false;
        }

        private void btnDirectorCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnGoToHome_Click(object sender, EventArgs e)
        {
            HomePage homepage = new HomePage();
            homepage.Show();
            Hide();
        }

        private void ManageDirectors_Load(object sender, EventArgs e)
        {
            try
            {
                FillDirectorDataGridView();
                Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDirectorSearch_Click(object sender, EventArgs e)
        {
            try
            {
                FillDirectorDataGridView();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDirectors_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvDirectors.CurrentRow.Index != -1)
                {
                    directorId = Convert.ToInt32(dgvDirectors.CurrentRow.Cells[0].Value.ToString());
                    txtDirectorFirstName.Text = dgvDirectors.CurrentRow.Cells[1].Value.ToString();
                    txtDirectorLastName.Text = dgvDirectors.CurrentRow.Cells[2].Value.ToString();
                    txtDirectorNationality.Text = dgvDirectors.CurrentRow.Cells[3].Value.ToString();
                    txtDirectorBirthYear.Text = dgvDirectors.CurrentRow.Cells[4].Value.ToString();
                    btnDirectorDelete.Enabled = true;
                    btnDirectorSave.Text = "Edit";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnDirectorDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@DirectorId", directorId);
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("MovieDatabaseDB")))
                {
                    connection.Execute("Director_DeleteById", param, commandType: CommandType.StoredProcedure);
                    Clear();
                    FillDirectorDataGridView();
                    MessageBox.Show("Director Deleted Successfully!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
