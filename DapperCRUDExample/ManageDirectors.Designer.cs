
namespace DapperCRUDExample
{
    partial class ManageDirectors
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageDirectors));
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
            this.btnGoToHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirectors)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(287, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 23);
            this.label7.TabIndex = 43;
            this.label7.Text = "Manage Directors";
            // 
            // btnDirectorSearch
            // 
            this.btnDirectorSearch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDirectorSearch.Location = new System.Drawing.Point(726, 132);
            this.btnDirectorSearch.Name = "btnDirectorSearch";
            this.btnDirectorSearch.Size = new System.Drawing.Size(82, 26);
            this.btnDirectorSearch.TabIndex = 42;
            this.btnDirectorSearch.Text = "Search";
            this.btnDirectorSearch.UseVisualStyleBackColor = true;
            this.btnDirectorSearch.Click += new System.EventHandler(this.btnDirectorSearch_Click);
            // 
            // txtDirectorSearch
            // 
            this.txtDirectorSearch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirectorSearch.Location = new System.Drawing.Point(351, 131);
            this.txtDirectorSearch.Name = "txtDirectorSearch";
            this.txtDirectorSearch.Size = new System.Drawing.Size(369, 26);
            this.txtDirectorSearch.TabIndex = 41;
            // 
            // dgvDirectors
            // 
            this.dgvDirectors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDirectors.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDirectors.Location = new System.Drawing.Point(351, 171);
            this.dgvDirectors.Name = "dgvDirectors";
            this.dgvDirectors.ReadOnly = true;
            this.dgvDirectors.Size = new System.Drawing.Size(457, 171);
            this.dgvDirectors.TabIndex = 40;
            this.dgvDirectors.DoubleClick += new System.EventHandler(this.dgvDirectors_DoubleClick);
            // 
            // btnDirectorCancel
            // 
            this.btnDirectorCancel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDirectorCancel.Location = new System.Drawing.Point(230, 305);
            this.btnDirectorCancel.Name = "btnDirectorCancel";
            this.btnDirectorCancel.Size = new System.Drawing.Size(82, 37);
            this.btnDirectorCancel.TabIndex = 39;
            this.btnDirectorCancel.Text = "Cancel";
            this.btnDirectorCancel.UseVisualStyleBackColor = true;
            this.btnDirectorCancel.Click += new System.EventHandler(this.btnDirectorCancel_Click);
            // 
            // btnDirectorDelete
            // 
            this.btnDirectorDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDirectorDelete.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDirectorDelete.Location = new System.Drawing.Point(131, 305);
            this.btnDirectorDelete.Name = "btnDirectorDelete";
            this.btnDirectorDelete.Size = new System.Drawing.Size(82, 37);
            this.btnDirectorDelete.TabIndex = 38;
            this.btnDirectorDelete.Text = "Delete";
            this.btnDirectorDelete.UseVisualStyleBackColor = false;
            this.btnDirectorDelete.Click += new System.EventHandler(this.btnDirectorDelete_Click);
            // 
            // btnDirectorSave
            // 
            this.btnDirectorSave.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnDirectorSave.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDirectorSave.Location = new System.Drawing.Point(26, 305);
            this.btnDirectorSave.Name = "btnDirectorSave";
            this.btnDirectorSave.Size = new System.Drawing.Size(82, 37);
            this.btnDirectorSave.TabIndex = 37;
            this.btnDirectorSave.Text = "Save";
            this.btnDirectorSave.UseVisualStyleBackColor = false;
            this.btnDirectorSave.Click += new System.EventHandler(this.btnDirectorSave_Click);
            // 
            // txtDirectorBirthYear
            // 
            this.txtDirectorBirthYear.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirectorBirthYear.Location = new System.Drawing.Point(111, 244);
            this.txtDirectorBirthYear.Name = "txtDirectorBirthYear";
            this.txtDirectorBirthYear.Size = new System.Drawing.Size(199, 26);
            this.txtDirectorBirthYear.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(23, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 35;
            this.label1.Text = "Birth Year";
            // 
            // txtDirectorNationality
            // 
            this.txtDirectorNationality.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirectorNationality.Location = new System.Drawing.Point(111, 209);
            this.txtDirectorNationality.Name = "txtDirectorNationality";
            this.txtDirectorNationality.Size = new System.Drawing.Size(199, 26);
            this.txtDirectorNationality.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(23, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nationality";
            // 
            // txtDirectorLastName
            // 
            this.txtDirectorLastName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirectorLastName.Location = new System.Drawing.Point(111, 171);
            this.txtDirectorLastName.Name = "txtDirectorLastName";
            this.txtDirectorLastName.Size = new System.Drawing.Size(199, 26);
            this.txtDirectorLastName.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(23, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 31;
            this.label3.Text = "Last Name";
            // 
            // txtDirectorFirstName
            // 
            this.txtDirectorFirstName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirectorFirstName.Location = new System.Drawing.Point(111, 132);
            this.txtDirectorFirstName.Name = "txtDirectorFirstName";
            this.txtDirectorFirstName.Size = new System.Drawing.Size(199, 26);
            this.txtDirectorFirstName.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(23, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 29;
            this.label5.Text = "First Name";
            // 
            // btnGoToHome
            // 
            this.btnGoToHome.BackgroundImage = global::DapperCRUDExample.Properties.Resources.homepage;
            this.btnGoToHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGoToHome.Location = new System.Drawing.Point(758, 17);
            this.btnGoToHome.Name = "btnGoToHome";
            this.btnGoToHome.Size = new System.Drawing.Size(50, 50);
            this.btnGoToHome.TabIndex = 45;
            this.btnGoToHome.UseVisualStyleBackColor = true;
            this.btnGoToHome.Click += new System.EventHandler(this.btnGoToHome_Click);
            // 
            // ManageDirectors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DapperCRUDExample.Properties.Resources.blackbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.btnGoToHome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDirectorSearch);
            this.Controls.Add(this.txtDirectorSearch);
            this.Controls.Add(this.dgvDirectors);
            this.Controls.Add(this.btnDirectorCancel);
            this.Controls.Add(this.btnDirectorDelete);
            this.Controls.Add(this.btnDirectorSave);
            this.Controls.Add(this.txtDirectorBirthYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDirectorNationality);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDirectorLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDirectorFirstName);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageDirectors";
            this.Text = "Manage Directors";
            this.Load += new System.EventHandler(this.ManageDirectors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirectors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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