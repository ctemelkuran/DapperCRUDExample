﻿
namespace DapperCRUDExample
{
    partial class ManageMovies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageMovies));
            this.btnDirectorSearch = new System.Windows.Forms.Button();
            this.txtMovieSearch = new System.Windows.Forms.TextBox();
            this.dgvMovies = new System.Windows.Forms.DataGridView();
            this.btnMovieCancel = new System.Windows.Forms.Button();
            this.btnMovieDelete = new System.Windows.Forms.Button();
            this.btnMovieSave = new System.Windows.Forms.Button();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReleaseYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMovieTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbxGenres = new System.Windows.Forms.ComboBox();
            this.cmbxDirectors = new System.Windows.Forms.ComboBox();
            this.btnGoToHome = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDirectorSearch
            // 
            this.btnDirectorSearch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDirectorSearch.Location = new System.Drawing.Point(726, 134);
            this.btnDirectorSearch.Name = "btnDirectorSearch";
            this.btnDirectorSearch.Size = new System.Drawing.Size(82, 26);
            this.btnDirectorSearch.TabIndex = 56;
            this.btnDirectorSearch.Text = "Search";
            this.btnDirectorSearch.UseVisualStyleBackColor = true;
            this.btnDirectorSearch.Click += new System.EventHandler(this.btnDirectorSearch_Click);
            // 
            // txtMovieSearch
            // 
            this.txtMovieSearch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovieSearch.Location = new System.Drawing.Point(351, 133);
            this.txtMovieSearch.Name = "txtMovieSearch";
            this.txtMovieSearch.Size = new System.Drawing.Size(369, 26);
            this.txtMovieSearch.TabIndex = 55;
            // 
            // dgvMovies
            // 
            this.dgvMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovies.Location = new System.Drawing.Point(351, 173);
            this.dgvMovies.Name = "dgvMovies";
            this.dgvMovies.ReadOnly = true;
            this.dgvMovies.Size = new System.Drawing.Size(457, 163);
            this.dgvMovies.TabIndex = 54;
            this.dgvMovies.DoubleClick += new System.EventHandler(this.dgvMovies_DoubleClick);
            // 
            // btnMovieCancel
            // 
            this.btnMovieCancel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovieCancel.Location = new System.Drawing.Point(237, 363);
            this.btnMovieCancel.Name = "btnMovieCancel";
            this.btnMovieCancel.Size = new System.Drawing.Size(82, 37);
            this.btnMovieCancel.TabIndex = 53;
            this.btnMovieCancel.Text = "Cancel";
            this.btnMovieCancel.UseVisualStyleBackColor = true;
            this.btnMovieCancel.Click += new System.EventHandler(this.btnMovieCancel_Click);
            // 
            // btnMovieDelete
            // 
            this.btnMovieDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnMovieDelete.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovieDelete.Location = new System.Drawing.Point(138, 363);
            this.btnMovieDelete.Name = "btnMovieDelete";
            this.btnMovieDelete.Size = new System.Drawing.Size(82, 37);
            this.btnMovieDelete.TabIndex = 52;
            this.btnMovieDelete.Text = "Delete";
            this.btnMovieDelete.UseVisualStyleBackColor = false;
            this.btnMovieDelete.Click += new System.EventHandler(this.btnMovieDelete_Click);
            // 
            // btnMovieSave
            // 
            this.btnMovieSave.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnMovieSave.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovieSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMovieSave.Location = new System.Drawing.Point(33, 363);
            this.btnMovieSave.Name = "btnMovieSave";
            this.btnMovieSave.Size = new System.Drawing.Size(82, 37);
            this.btnMovieSave.TabIndex = 51;
            this.btnMovieSave.Text = "Save";
            this.btnMovieSave.UseVisualStyleBackColor = false;
            this.btnMovieSave.Click += new System.EventHandler(this.btnMovieSave_Click);
            // 
            // txtLength
            // 
            this.txtLength.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLength.Location = new System.Drawing.Point(131, 246);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(199, 26);
            this.txtLength.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(23, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 49;
            this.label1.Text = "Movie Length";
            // 
            // txtRating
            // 
            this.txtRating.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRating.Location = new System.Drawing.Point(131, 211);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(199, 26);
            this.txtRating.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(23, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 47;
            this.label2.Text = "Rating";
            // 
            // txtReleaseYear
            // 
            this.txtReleaseYear.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReleaseYear.Location = new System.Drawing.Point(131, 173);
            this.txtReleaseYear.Name = "txtReleaseYear";
            this.txtReleaseYear.Size = new System.Drawing.Size(199, 26);
            this.txtReleaseYear.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(23, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 45;
            this.label3.Text = "Release Year";
            // 
            // txtMovieTitle
            // 
            this.txtMovieTitle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovieTitle.Location = new System.Drawing.Point(131, 134);
            this.txtMovieTitle.Name = "txtMovieTitle";
            this.txtMovieTitle.Size = new System.Drawing.Size(199, 26);
            this.txtMovieTitle.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(23, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 18);
            this.label5.TabIndex = 43;
            this.label5.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(23, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 57;
            this.label4.Text = "Genre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(23, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 18);
            this.label6.TabIndex = 58;
            this.label6.Text = "Director";
            // 
            // cmbxGenres
            // 
            this.cmbxGenres.FormattingEnabled = true;
            this.cmbxGenres.Location = new System.Drawing.Point(131, 283);
            this.cmbxGenres.Name = "cmbxGenres";
            this.cmbxGenres.Size = new System.Drawing.Size(199, 21);
            this.cmbxGenres.TabIndex = 59;
            // 
            // cmbxDirectors
            // 
            this.cmbxDirectors.FormattingEnabled = true;
            this.cmbxDirectors.Location = new System.Drawing.Point(131, 315);
            this.cmbxDirectors.Name = "cmbxDirectors";
            this.cmbxDirectors.Size = new System.Drawing.Size(199, 21);
            this.cmbxDirectors.TabIndex = 60;
            // 
            // btnGoToHome
            // 
            this.btnGoToHome.BackgroundImage = global::DapperCRUDExample.Properties.Resources.homepage;
            this.btnGoToHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGoToHome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGoToHome.Location = new System.Drawing.Point(758, 17);
            this.btnGoToHome.Name = "btnGoToHome";
            this.btnGoToHome.Size = new System.Drawing.Size(50, 50);
            this.btnGoToHome.TabIndex = 61;
            this.btnGoToHome.UseVisualStyleBackColor = true;
            this.btnGoToHome.Click += new System.EventHandler(this.btnGoToHome_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(335, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 23);
            this.label7.TabIndex = 62;
            this.label7.Text = "Manage Movies";
            // 
            // ManageMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DapperCRUDExample.Properties.Resources.blackbg;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnGoToHome);
            this.Controls.Add(this.cmbxDirectors);
            this.Controls.Add(this.cmbxGenres);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDirectorSearch);
            this.Controls.Add(this.txtMovieSearch);
            this.Controls.Add(this.dgvMovies);
            this.Controls.Add(this.btnMovieCancel);
            this.Controls.Add(this.btnMovieDelete);
            this.Controls.Add(this.btnMovieSave);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtReleaseYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMovieTitle);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageMovies";
            this.Text = "Manage Movies ";
            this.Load += new System.EventHandler(this.ManageMovies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDirectorSearch;
        private System.Windows.Forms.TextBox txtMovieSearch;
        private System.Windows.Forms.DataGridView dgvMovies;
        private System.Windows.Forms.Button btnMovieCancel;
        private System.Windows.Forms.Button btnMovieDelete;
        private System.Windows.Forms.Button btnMovieSave;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReleaseYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMovieTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbxGenres;
        private System.Windows.Forms.ComboBox cmbxDirectors;
        private System.Windows.Forms.Button btnGoToHome;
        private System.Windows.Forms.Label label7;
    }
}