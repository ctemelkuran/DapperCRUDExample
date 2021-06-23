
namespace DapperCRUDExample
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.btnGoToMovies = new System.Windows.Forms.Button();
            this.btnGoToActors = new System.Windows.Forms.Button();
            this.btnGoToDirectors = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnSearchMovies = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGoToMovies
            // 
            this.btnGoToMovies.BackColor = System.Drawing.Color.Transparent;
            this.btnGoToMovies.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGoToMovies.BackgroundImage")));
            this.btnGoToMovies.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGoToMovies.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToMovies.Location = new System.Drawing.Point(687, 187);
            this.btnGoToMovies.Name = "btnGoToMovies";
            this.btnGoToMovies.Size = new System.Drawing.Size(112, 60);
            this.btnGoToMovies.TabIndex = 0;
            this.btnGoToMovies.Text = "Movies";
            this.btnGoToMovies.UseVisualStyleBackColor = false;
            this.btnGoToMovies.Click += new System.EventHandler(this.btnGoToMovies_Click);
            // 
            // btnGoToActors
            // 
            this.btnGoToActors.BackColor = System.Drawing.Color.Transparent;
            this.btnGoToActors.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGoToActors.BackgroundImage")));
            this.btnGoToActors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGoToActors.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToActors.Location = new System.Drawing.Point(687, 27);
            this.btnGoToActors.Name = "btnGoToActors";
            this.btnGoToActors.Size = new System.Drawing.Size(112, 60);
            this.btnGoToActors.TabIndex = 1;
            this.btnGoToActors.Text = "Actors";
            this.btnGoToActors.UseVisualStyleBackColor = false;
            this.btnGoToActors.Click += new System.EventHandler(this.btnGoToActors_Click);
            // 
            // btnGoToDirectors
            // 
            this.btnGoToDirectors.BackColor = System.Drawing.Color.Transparent;
            this.btnGoToDirectors.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGoToDirectors.BackgroundImage")));
            this.btnGoToDirectors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGoToDirectors.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToDirectors.Location = new System.Drawing.Point(687, 109);
            this.btnGoToDirectors.Name = "btnGoToDirectors";
            this.btnGoToDirectors.Size = new System.Drawing.Size(112, 60);
            this.btnGoToDirectors.TabIndex = 2;
            this.btnGoToDirectors.Text = "Directors";
            this.btnGoToDirectors.UseVisualStyleBackColor = false;
            this.btnGoToDirectors.Click += new System.EventHandler(this.btnGoToDirectors_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = global::DapperCRUDExample.Properties.Resources._3;
            this.pictureBox1.Location = new System.Drawing.Point(621, 187);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Image = global::DapperCRUDExample.Properties.Resources._2;
            this.pictureBox2.Location = new System.Drawing.Point(621, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Image = global::DapperCRUDExample.Properties.Resources._1;
            this.pictureBox3.Location = new System.Drawing.Point(621, 109);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // btnSearchMovies
            // 
            this.btnSearchMovies.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchMovies.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchMovies.BackgroundImage")));
            this.btnSearchMovies.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchMovies.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMovies.Location = new System.Drawing.Point(687, 253);
            this.btnSearchMovies.Name = "btnSearchMovies";
            this.btnSearchMovies.Size = new System.Drawing.Size(112, 60);
            this.btnSearchMovies.TabIndex = 6;
            this.btnSearchMovies.Text = "Filter Movies";
            this.btnSearchMovies.UseVisualStyleBackColor = false;
            this.btnSearchMovies.Click += new System.EventHandler(this.btnSearchMovies_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox4.BackgroundImage = global::DapperCRUDExample.Properties.Resources.MovieBackground;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Image = global::DapperCRUDExample.Properties.Resources.Movietown;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBox4.Size = new System.Drawing.Size(834, 461);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.btnSearchMovies);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGoToDirectors);
            this.Controls.Add(this.btnGoToActors);
            this.Controls.Add(this.btnGoToMovies);
            this.Controls.Add(this.pictureBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomePage";
            this.Text = "MovieTown HomePage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGoToMovies;
        private System.Windows.Forms.Button btnGoToActors;
        private System.Windows.Forms.Button btnGoToDirectors;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnSearchMovies;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}