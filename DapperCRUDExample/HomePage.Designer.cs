
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
            this.btnGoToMovies = new System.Windows.Forms.Button();
            this.btnGoToActors = new System.Windows.Forms.Button();
            this.btnGoToDirectors = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGoToMovies
            // 
            this.btnGoToMovies.Location = new System.Drawing.Point(572, 196);
            this.btnGoToMovies.Name = "btnGoToMovies";
            this.btnGoToMovies.Size = new System.Drawing.Size(87, 34);
            this.btnGoToMovies.TabIndex = 0;
            this.btnGoToMovies.Text = "Movies";
            this.btnGoToMovies.UseVisualStyleBackColor = true;
            this.btnGoToMovies.Click += new System.EventHandler(this.btnGoToMovies_Click);
            // 
            // btnGoToActors
            // 
            this.btnGoToActors.Location = new System.Drawing.Point(572, 239);
            this.btnGoToActors.Name = "btnGoToActors";
            this.btnGoToActors.Size = new System.Drawing.Size(87, 34);
            this.btnGoToActors.TabIndex = 1;
            this.btnGoToActors.Text = "Actors";
            this.btnGoToActors.UseVisualStyleBackColor = true;
            this.btnGoToActors.Click += new System.EventHandler(this.btnGoToActors_Click);
            // 
            // btnGoToDirectors
            // 
            this.btnGoToDirectors.Location = new System.Drawing.Point(572, 289);
            this.btnGoToDirectors.Name = "btnGoToDirectors";
            this.btnGoToDirectors.Size = new System.Drawing.Size(87, 34);
            this.btnGoToDirectors.TabIndex = 2;
            this.btnGoToDirectors.Text = "Directors";
            this.btnGoToDirectors.UseVisualStyleBackColor = true;
            this.btnGoToDirectors.Click += new System.EventHandler(this.btnGoToDirectors_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGoToDirectors);
            this.Controls.Add(this.btnGoToActors);
            this.Controls.Add(this.btnGoToMovies);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGoToMovies;
        private System.Windows.Forms.Button btnGoToActors;
        private System.Windows.Forms.Button btnGoToDirectors;
    }
}