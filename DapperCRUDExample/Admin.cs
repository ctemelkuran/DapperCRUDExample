using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace DapperCRUDExample
{
    public partial class Admin : Form
    {
        int actorId = 0;
        public Admin()
        {
            InitializeComponent();
        }

        private void btnActorSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("MovieDatabaseDB")))
                {
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@ActorId", actorId);
                    param.Add("@FirstName", txtActorFirstName.Text.Trim());
                    param.Add("@LastName", txtActorLastName.Text.Trim());
                    param.Add("@Nationality", txtActorNationality.Text.Trim());
                    param.Add("@Birth", Convert.ToInt32(txtActorBirthYear.Text));
                    connection.Execute("Actor_InsertOrEdit", param, commandType: CommandType.StoredProcedure);
                    if (actorId == 0)
                    {
                        MessageBox.Show("Actor "+ txtActorFirstName.Text+" " + txtActorLastName.Text + " saved successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Actor " + txtActorFirstName.Text + " " + txtActorLastName.Text + " updated successfully!");
                    }
                    FillActorDataGridView();
                    Clear();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        void FillActorDataGridView()
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@SearchText", txtActorSearch.Text.Trim());

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("MovieDatabaseDB")))
            {
                List<Actor> actorList = connection.Query<Actor>("Actor_ViewAllOrSearchByFirstName", param,
                    commandType: CommandType.StoredProcedure).ToList<Actor>();

                dgvActors.DataSource = actorList;

                // Hide the ActorId
                dgvActors.Columns[0].Visible = false;
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            try
            {
                FillActorDataGridView();
                Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnActorSearch_Click(object sender, EventArgs e)
        {
            try
            {
                FillActorDataGridView();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnActorCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            txtActorFirstName.Text = txtActorLastName.Text = txtActorNationality.Text = txtActorBirthYear.Text = "";
            actorId = 0;
            btnActorSave.Text = "Save";
            btnActorDelete.Enabled = false;
        }

        private void dgvActors_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvActors.CurrentRow.Index != -1)
                {
                    actorId = Convert.ToInt32(dgvActors.CurrentRow.Cells[0].Value.ToString());
                    txtActorFirstName.Text = dgvActors.CurrentRow.Cells[1].Value.ToString();
                    txtActorLastName.Text = dgvActors.CurrentRow.Cells[2].Value.ToString();
                    txtActorNationality.Text = dgvActors.CurrentRow.Cells[3].Value.ToString();
                    txtActorBirthYear.Text = dgvActors.CurrentRow.Cells[4].Value.ToString();
                    btnActorDelete.Enabled = true;
                    btnActorSave.Text = "Edit";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void btnActorDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@ActorId", actorId);
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("MovieDatabaseDB")))
                {
                    connection.Execute("Actor_DeleteById", param, commandType: CommandType.StoredProcedure);
                    Clear();
                    FillActorDataGridView();
                    MessageBox.Show("Actor Deleted Successfully!");
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
