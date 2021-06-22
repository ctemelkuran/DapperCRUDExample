
namespace DapperCRUDExample
{
    partial class ManageActors
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageActors));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ActorsTabPage = new System.Windows.Forms.TabPage();
            this.btnGoToHome = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnActorSearch = new System.Windows.Forms.Button();
            this.txtActorSearch = new System.Windows.Forms.TextBox();
            this.txtActorBirthYear = new System.Windows.Forms.TextBox();
            this.txtActorNationality = new System.Windows.Forms.TextBox();
            this.txtActorLastName = new System.Windows.Forms.TextBox();
            this.txtActorFirstName = new System.Windows.Forms.TextBox();
            this.dgvActors = new System.Windows.Forms.DataGridView();
            this.btnActorCancel = new System.Windows.Forms.Button();
            this.btnActorDelete = new System.Windows.Forms.Button();
            this.btnActorSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ActorNationalityLabel = new System.Windows.Forms.Label();
            this.ActorLastNameLabel = new System.Windows.Forms.Label();
            this.ActorFirstNameLabel = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.ActorsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActors)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ActorsTabPage);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(846, 429);
            this.tabControl1.TabIndex = 0;
            // 
            // ActorsTabPage
            // 
            this.ActorsTabPage.Controls.Add(this.btnGoToHome);
            this.ActorsTabPage.Controls.Add(this.label6);
            this.ActorsTabPage.Controls.Add(this.btnActorSearch);
            this.ActorsTabPage.Controls.Add(this.txtActorSearch);
            this.ActorsTabPage.Controls.Add(this.txtActorBirthYear);
            this.ActorsTabPage.Controls.Add(this.txtActorNationality);
            this.ActorsTabPage.Controls.Add(this.txtActorLastName);
            this.ActorsTabPage.Controls.Add(this.txtActorFirstName);
            this.ActorsTabPage.Controls.Add(this.dgvActors);
            this.ActorsTabPage.Controls.Add(this.btnActorCancel);
            this.ActorsTabPage.Controls.Add(this.btnActorDelete);
            this.ActorsTabPage.Controls.Add(this.btnActorSave);
            this.ActorsTabPage.Controls.Add(this.label4);
            this.ActorsTabPage.Controls.Add(this.ActorNationalityLabel);
            this.ActorsTabPage.Controls.Add(this.ActorLastNameLabel);
            this.ActorsTabPage.Controls.Add(this.ActorFirstNameLabel);
            this.ActorsTabPage.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActorsTabPage.Location = new System.Drawing.Point(4, 22);
            this.ActorsTabPage.Name = "ActorsTabPage";
            this.ActorsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ActorsTabPage.Size = new System.Drawing.Size(838, 403);
            this.ActorsTabPage.TabIndex = 0;
            this.ActorsTabPage.Text = "Actors";
            this.ActorsTabPage.UseVisualStyleBackColor = true;
            // 
            // btnGoToHome
            // 
            this.btnGoToHome.BackgroundImage = global::DapperCRUDExample.Properties.Resources.homepage;
            this.btnGoToHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGoToHome.Location = new System.Drawing.Point(770, 6);
            this.btnGoToHome.Name = "btnGoToHome";
            this.btnGoToHome.Size = new System.Drawing.Size(50, 50);
            this.btnGoToHome.TabIndex = 15;
            this.btnGoToHome.UseVisualStyleBackColor = true;
            this.btnGoToHome.Click += new System.EventHandler(this.btnGoToHome_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(330, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Manage Actors";
            // 
            // btnActorSearch
            // 
            this.btnActorSearch.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnActorSearch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActorSearch.Location = new System.Drawing.Point(738, 69);
            this.btnActorSearch.Name = "btnActorSearch";
            this.btnActorSearch.Size = new System.Drawing.Size(82, 26);
            this.btnActorSearch.TabIndex = 13;
            this.btnActorSearch.Text = "Search";
            this.btnActorSearch.UseVisualStyleBackColor = false;
            this.btnActorSearch.Click += new System.EventHandler(this.btnActorSearch_Click);
            // 
            // txtActorSearch
            // 
            this.txtActorSearch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActorSearch.Location = new System.Drawing.Point(363, 68);
            this.txtActorSearch.Name = "txtActorSearch";
            this.txtActorSearch.Size = new System.Drawing.Size(369, 26);
            this.txtActorSearch.TabIndex = 12;
            // 
            // txtActorBirthYear
            // 
            this.txtActorBirthYear.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActorBirthYear.Location = new System.Drawing.Point(123, 181);
            this.txtActorBirthYear.Name = "txtActorBirthYear";
            this.txtActorBirthYear.Size = new System.Drawing.Size(199, 26);
            this.txtActorBirthYear.TabIndex = 7;
            // 
            // txtActorNationality
            // 
            this.txtActorNationality.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActorNationality.Location = new System.Drawing.Point(123, 146);
            this.txtActorNationality.Name = "txtActorNationality";
            this.txtActorNationality.Size = new System.Drawing.Size(199, 26);
            this.txtActorNationality.TabIndex = 5;
            // 
            // txtActorLastName
            // 
            this.txtActorLastName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActorLastName.Location = new System.Drawing.Point(123, 108);
            this.txtActorLastName.Name = "txtActorLastName";
            this.txtActorLastName.Size = new System.Drawing.Size(199, 26);
            this.txtActorLastName.TabIndex = 3;
            // 
            // txtActorFirstName
            // 
            this.txtActorFirstName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActorFirstName.Location = new System.Drawing.Point(123, 69);
            this.txtActorFirstName.Name = "txtActorFirstName";
            this.txtActorFirstName.Size = new System.Drawing.Size(199, 26);
            this.txtActorFirstName.TabIndex = 1;
            // 
            // dgvActors
            // 
            this.dgvActors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActors.Location = new System.Drawing.Point(363, 108);
            this.dgvActors.Name = "dgvActors";
            this.dgvActors.ReadOnly = true;
            this.dgvActors.Size = new System.Drawing.Size(457, 190);
            this.dgvActors.TabIndex = 11;
            this.dgvActors.DoubleClick += new System.EventHandler(this.dgvActors_DoubleClick);
            // 
            // btnActorCancel
            // 
            this.btnActorCancel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActorCancel.Location = new System.Drawing.Point(242, 242);
            this.btnActorCancel.Name = "btnActorCancel";
            this.btnActorCancel.Size = new System.Drawing.Size(82, 37);
            this.btnActorCancel.TabIndex = 10;
            this.btnActorCancel.Text = "Cancel";
            this.btnActorCancel.UseVisualStyleBackColor = true;
            this.btnActorCancel.Click += new System.EventHandler(this.btnActorCancel_Click);
            // 
            // btnActorDelete
            // 
            this.btnActorDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnActorDelete.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActorDelete.Location = new System.Drawing.Point(143, 242);
            this.btnActorDelete.Name = "btnActorDelete";
            this.btnActorDelete.Size = new System.Drawing.Size(82, 37);
            this.btnActorDelete.TabIndex = 9;
            this.btnActorDelete.Text = "Delete";
            this.btnActorDelete.UseVisualStyleBackColor = false;
            this.btnActorDelete.Click += new System.EventHandler(this.btnActorDelete_Click);
            // 
            // btnActorSave
            // 
            this.btnActorSave.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnActorSave.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActorSave.Location = new System.Drawing.Point(38, 242);
            this.btnActorSave.Name = "btnActorSave";
            this.btnActorSave.Size = new System.Drawing.Size(82, 37);
            this.btnActorSave.TabIndex = 8;
            this.btnActorSave.Text = "Save";
            this.btnActorSave.UseVisualStyleBackColor = false;
            this.btnActorSave.Click += new System.EventHandler(this.btnActorSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Birth Year";
            // 
            // ActorNationalityLabel
            // 
            this.ActorNationalityLabel.AutoSize = true;
            this.ActorNationalityLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActorNationalityLabel.Location = new System.Drawing.Point(35, 149);
            this.ActorNationalityLabel.Name = "ActorNationalityLabel";
            this.ActorNationalityLabel.Size = new System.Drawing.Size(76, 18);
            this.ActorNationalityLabel.TabIndex = 4;
            this.ActorNationalityLabel.Text = "Nationality";
            // 
            // ActorLastNameLabel
            // 
            this.ActorLastNameLabel.AutoSize = true;
            this.ActorLastNameLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActorLastNameLabel.Location = new System.Drawing.Point(35, 111);
            this.ActorLastNameLabel.Name = "ActorLastNameLabel";
            this.ActorLastNameLabel.Size = new System.Drawing.Size(72, 18);
            this.ActorLastNameLabel.TabIndex = 2;
            this.ActorLastNameLabel.Text = "Last Name";
            // 
            // ActorFirstNameLabel
            // 
            this.ActorFirstNameLabel.AutoSize = true;
            this.ActorFirstNameLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActorFirstNameLabel.Location = new System.Drawing.Point(35, 72);
            this.ActorFirstNameLabel.Name = "ActorFirstNameLabel";
            this.ActorFirstNameLabel.Size = new System.Drawing.Size(75, 18);
            this.ActorFirstNameLabel.TabIndex = 0;
            this.ActorFirstNameLabel.Text = "First Name";
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(838, 403);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Movie & Actor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ManageActors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 453);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageActors";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Actors";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.tabControl1.ResumeLayout(false);
            this.ActorsTabPage.ResumeLayout(false);
            this.ActorsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ActorsTabPage;
        private System.Windows.Forms.Button btnGoToHome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnActorSearch;
        private System.Windows.Forms.TextBox txtActorSearch;
        private System.Windows.Forms.TextBox txtActorBirthYear;
        private System.Windows.Forms.TextBox txtActorNationality;
        private System.Windows.Forms.TextBox txtActorLastName;
        private System.Windows.Forms.TextBox txtActorFirstName;
        private System.Windows.Forms.DataGridView dgvActors;
        private System.Windows.Forms.Button btnActorCancel;
        private System.Windows.Forms.Button btnActorDelete;
        private System.Windows.Forms.Button btnActorSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ActorNationalityLabel;
        private System.Windows.Forms.Label ActorLastNameLabel;
        private System.Windows.Forms.Label ActorFirstNameLabel;
        private System.Windows.Forms.TabPage tabPage1;
    }
}

