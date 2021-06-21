
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ActorsTabPage = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.btnActorSearch = new System.Windows.Forms.Button();
            this.txtActorSearch = new System.Windows.Forms.TextBox();
            this.dgvActors = new System.Windows.Forms.DataGridView();
            this.btnActorCancel = new System.Windows.Forms.Button();
            this.btnActorDelete = new System.Windows.Forms.Button();
            this.btnActorSave = new System.Windows.Forms.Button();
            this.txtActorBirthYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtActorNationality = new System.Windows.Forms.TextBox();
            this.ActorNationalityLabel = new System.Windows.Forms.Label();
            this.txtActorLastName = new System.Windows.Forms.TextBox();
            this.ActorLastNameLabel = new System.Windows.Forms.Label();
            this.txtActorFirstName = new System.Windows.Forms.TextBox();
            this.ActorFirstNameLabel = new System.Windows.Forms.Label();
            this.DirectorsTabPage = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDirectorSearch = new System.Windows.Forms.Button();
            this.txtDirectorSearch = new System.Windows.Forms.TextBox();
            this.dgvDirectors = new System.Windows.Forms.DataGridView();
            this.btnDirectorCancel = new System.Windows.Forms.Button();
            this.btnDirectorDelete = new System.Windows.Forms.Button();
            this.btnDirectorSave = new System.Windows.Forms.Button();
            this.txtDirectorBirthYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDirectorNationality = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDirectorLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDirectorFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnGoToHome = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.ActorsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActors)).BeginInit();
            this.DirectorsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirectors)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ActorsTabPage);
            this.tabControl1.Controls.Add(this.DirectorsTabPage);
            this.tabControl1.Controls.Add(this.tabPage3);
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
            this.ActorsTabPage.Controls.Add(this.dgvActors);
            this.ActorsTabPage.Controls.Add(this.btnActorCancel);
            this.ActorsTabPage.Controls.Add(this.btnActorDelete);
            this.ActorsTabPage.Controls.Add(this.btnActorSave);
            this.ActorsTabPage.Controls.Add(this.txtActorBirthYear);
            this.ActorsTabPage.Controls.Add(this.label4);
            this.ActorsTabPage.Controls.Add(this.txtActorNationality);
            this.ActorsTabPage.Controls.Add(this.ActorNationalityLabel);
            this.ActorsTabPage.Controls.Add(this.txtActorLastName);
            this.ActorsTabPage.Controls.Add(this.ActorLastNameLabel);
            this.ActorsTabPage.Controls.Add(this.txtActorFirstName);
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
            this.btnActorSearch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActorSearch.Location = new System.Drawing.Point(738, 69);
            this.btnActorSearch.Name = "btnActorSearch";
            this.btnActorSearch.Size = new System.Drawing.Size(82, 26);
            this.btnActorSearch.TabIndex = 13;
            this.btnActorSearch.Text = "Search";
            this.btnActorSearch.UseVisualStyleBackColor = true;
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
            this.btnActorCancel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnActorDelete.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActorDelete.Location = new System.Drawing.Point(143, 242);
            this.btnActorDelete.Name = "btnActorDelete";
            this.btnActorDelete.Size = new System.Drawing.Size(82, 37);
            this.btnActorDelete.TabIndex = 9;
            this.btnActorDelete.Text = "Delete";
            this.btnActorDelete.UseVisualStyleBackColor = true;
            this.btnActorDelete.Click += new System.EventHandler(this.btnActorDelete_Click);
            // 
            // btnActorSave
            // 
            this.btnActorSave.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActorSave.Location = new System.Drawing.Point(38, 242);
            this.btnActorSave.Name = "btnActorSave";
            this.btnActorSave.Size = new System.Drawing.Size(82, 37);
            this.btnActorSave.TabIndex = 8;
            this.btnActorSave.Text = "Save";
            this.btnActorSave.UseVisualStyleBackColor = true;
            this.btnActorSave.Click += new System.EventHandler(this.btnActorSave_Click);
            // 
            // txtActorBirthYear
            // 
            this.txtActorBirthYear.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActorBirthYear.Location = new System.Drawing.Point(123, 181);
            this.txtActorBirthYear.Name = "txtActorBirthYear";
            this.txtActorBirthYear.Size = new System.Drawing.Size(199, 26);
            this.txtActorBirthYear.TabIndex = 7;
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
            // txtActorNationality
            // 
            this.txtActorNationality.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActorNationality.Location = new System.Drawing.Point(123, 146);
            this.txtActorNationality.Name = "txtActorNationality";
            this.txtActorNationality.Size = new System.Drawing.Size(199, 26);
            this.txtActorNationality.TabIndex = 5;
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
            // txtActorLastName
            // 
            this.txtActorLastName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActorLastName.Location = new System.Drawing.Point(123, 108);
            this.txtActorLastName.Name = "txtActorLastName";
            this.txtActorLastName.Size = new System.Drawing.Size(199, 26);
            this.txtActorLastName.TabIndex = 3;
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
            // txtActorFirstName
            // 
            this.txtActorFirstName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActorFirstName.Location = new System.Drawing.Point(123, 69);
            this.txtActorFirstName.Name = "txtActorFirstName";
            this.txtActorFirstName.Size = new System.Drawing.Size(199, 26);
            this.txtActorFirstName.TabIndex = 1;
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
            // DirectorsTabPage
            // 
            this.DirectorsTabPage.Controls.Add(this.label7);
            this.DirectorsTabPage.Controls.Add(this.btnDirectorSearch);
            this.DirectorsTabPage.Controls.Add(this.txtDirectorSearch);
            this.DirectorsTabPage.Controls.Add(this.dgvDirectors);
            this.DirectorsTabPage.Controls.Add(this.btnDirectorCancel);
            this.DirectorsTabPage.Controls.Add(this.btnDirectorDelete);
            this.DirectorsTabPage.Controls.Add(this.btnDirectorSave);
            this.DirectorsTabPage.Controls.Add(this.txtDirectorBirthYear);
            this.DirectorsTabPage.Controls.Add(this.label1);
            this.DirectorsTabPage.Controls.Add(this.txtDirectorNationality);
            this.DirectorsTabPage.Controls.Add(this.label2);
            this.DirectorsTabPage.Controls.Add(this.txtDirectorLastName);
            this.DirectorsTabPage.Controls.Add(this.label3);
            this.DirectorsTabPage.Controls.Add(this.txtDirectorFirstName);
            this.DirectorsTabPage.Controls.Add(this.label5);
            this.DirectorsTabPage.Location = new System.Drawing.Point(4, 22);
            this.DirectorsTabPage.Name = "DirectorsTabPage";
            this.DirectorsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.DirectorsTabPage.Size = new System.Drawing.Size(838, 403);
            this.DirectorsTabPage.TabIndex = 1;
            this.DirectorsTabPage.Text = "Directors";
            this.DirectorsTabPage.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(311, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 23);
            this.label7.TabIndex = 28;
            this.label7.Text = "Manage Directors";
            // 
            // btnDirectorSearch
            // 
            this.btnDirectorSearch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDirectorSearch.Location = new System.Drawing.Point(730, 87);
            this.btnDirectorSearch.Name = "btnDirectorSearch";
            this.btnDirectorSearch.Size = new System.Drawing.Size(82, 26);
            this.btnDirectorSearch.TabIndex = 27;
            this.btnDirectorSearch.Text = "Search";
            this.btnDirectorSearch.UseVisualStyleBackColor = true;
            // 
            // txtDirectorSearch
            // 
            this.txtDirectorSearch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirectorSearch.Location = new System.Drawing.Point(355, 86);
            this.txtDirectorSearch.Name = "txtDirectorSearch";
            this.txtDirectorSearch.Size = new System.Drawing.Size(369, 26);
            this.txtDirectorSearch.TabIndex = 26;
            // 
            // dgvDirectors
            // 
            this.dgvDirectors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDirectors.Location = new System.Drawing.Point(355, 126);
            this.dgvDirectors.Name = "dgvDirectors";
            this.dgvDirectors.ReadOnly = true;
            this.dgvDirectors.Size = new System.Drawing.Size(457, 190);
            this.dgvDirectors.TabIndex = 25;
            // 
            // btnDirectorCancel
            // 
            this.btnDirectorCancel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDirectorCancel.Location = new System.Drawing.Point(234, 260);
            this.btnDirectorCancel.Name = "btnDirectorCancel";
            this.btnDirectorCancel.Size = new System.Drawing.Size(82, 37);
            this.btnDirectorCancel.TabIndex = 24;
            this.btnDirectorCancel.Text = "Cancel";
            this.btnDirectorCancel.UseVisualStyleBackColor = true;
            // 
            // btnDirectorDelete
            // 
            this.btnDirectorDelete.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDirectorDelete.Location = new System.Drawing.Point(135, 260);
            this.btnDirectorDelete.Name = "btnDirectorDelete";
            this.btnDirectorDelete.Size = new System.Drawing.Size(82, 37);
            this.btnDirectorDelete.TabIndex = 23;
            this.btnDirectorDelete.Text = "Delete";
            this.btnDirectorDelete.UseVisualStyleBackColor = true;
            // 
            // btnDirectorSave
            // 
            this.btnDirectorSave.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDirectorSave.Location = new System.Drawing.Point(30, 260);
            this.btnDirectorSave.Name = "btnDirectorSave";
            this.btnDirectorSave.Size = new System.Drawing.Size(82, 37);
            this.btnDirectorSave.TabIndex = 22;
            this.btnDirectorSave.Text = "Save";
            this.btnDirectorSave.UseVisualStyleBackColor = true;
            // 
            // txtDirectorBirthYear
            // 
            this.txtDirectorBirthYear.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirectorBirthYear.Location = new System.Drawing.Point(115, 199);
            this.txtDirectorBirthYear.Name = "txtDirectorBirthYear";
            this.txtDirectorBirthYear.Size = new System.Drawing.Size(199, 26);
            this.txtDirectorBirthYear.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Birth Year";
            // 
            // txtDirectorNationality
            // 
            this.txtDirectorNationality.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirectorNationality.Location = new System.Drawing.Point(115, 164);
            this.txtDirectorNationality.Name = "txtDirectorNationality";
            this.txtDirectorNationality.Size = new System.Drawing.Size(199, 26);
            this.txtDirectorNationality.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nationality";
            // 
            // txtDirectorLastName
            // 
            this.txtDirectorLastName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirectorLastName.Location = new System.Drawing.Point(115, 126);
            this.txtDirectorLastName.Name = "txtDirectorLastName";
            this.txtDirectorLastName.Size = new System.Drawing.Size(199, 26);
            this.txtDirectorLastName.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Last Name";
            // 
            // txtDirectorFirstName
            // 
            this.txtDirectorFirstName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirectorFirstName.Location = new System.Drawing.Point(115, 87);
            this.txtDirectorFirstName.Name = "txtDirectorFirstName";
            this.txtDirectorFirstName.Size = new System.Drawing.Size(199, 26);
            this.txtDirectorFirstName.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "First Name";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(838, 403);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Movies";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnGoToHome
            // 
            this.btnGoToHome.Location = new System.Drawing.Point(737, 6);
            this.btnGoToHome.Name = "btnGoToHome";
            this.btnGoToHome.Size = new System.Drawing.Size(95, 28);
            this.btnGoToHome.TabIndex = 15;
            this.btnGoToHome.Text = "Home Page";
            this.btnGoToHome.UseVisualStyleBackColor = true;
            this.btnGoToHome.Click += new System.EventHandler(this.btnGoToHome_Click);
            // 
            // ManageActors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 453);
            this.Controls.Add(this.tabControl1);
            this.Name = "ManageActors";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Movie Entities";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.tabControl1.ResumeLayout(false);
            this.ActorsTabPage.ResumeLayout(false);
            this.ActorsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActors)).EndInit();
            this.DirectorsTabPage.ResumeLayout(false);
            this.DirectorsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirectors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ActorsTabPage;
        private System.Windows.Forms.TabPage DirectorsTabPage;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvActors;
        private System.Windows.Forms.Button btnActorCancel;
        private System.Windows.Forms.Button btnActorDelete;
        private System.Windows.Forms.Button btnActorSave;
        private System.Windows.Forms.TextBox txtActorBirthYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtActorNationality;
        private System.Windows.Forms.Label ActorNationalityLabel;
        private System.Windows.Forms.TextBox txtActorLastName;
        private System.Windows.Forms.Label ActorLastNameLabel;
        private System.Windows.Forms.TextBox txtActorFirstName;
        private System.Windows.Forms.Label ActorFirstNameLabel;
        private System.Windows.Forms.Button btnActorSearch;
        private System.Windows.Forms.TextBox txtActorSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDirectorSearch;
        private System.Windows.Forms.TextBox txtDirectorSearch;
        private System.Windows.Forms.DataGridView dgvDirectors;
        private System.Windows.Forms.Button btnDirectorCancel;
        private System.Windows.Forms.Button btnDirectorDelete;
        private System.Windows.Forms.Button btnDirectorSave;
        private System.Windows.Forms.TextBox txtDirectorBirthYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDirectorNationality;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDirectorLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDirectorFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGoToHome;
    }
}

