namespace MusicPlayer
{
    partial class AddArtistForm
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
            this.dtpArtistBday = new System.Windows.Forms.DateTimePicker();
            this.btnAddArtist = new System.Windows.Forms.Button();
            this.bdayLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.tbArtistName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dtpArtistBday
            // 
            this.dtpArtistBday.Location = new System.Drawing.Point(94, 26);
            this.dtpArtistBday.Name = "dtpArtistBday";
            this.dtpArtistBday.Size = new System.Drawing.Size(300, 20);
            this.dtpArtistBday.TabIndex = 0;
            // 
            // btnAddArtist
            // 
            this.btnAddArtist.Location = new System.Drawing.Point(6, 52);
            this.btnAddArtist.Name = "btnAddArtist";
            this.btnAddArtist.Size = new System.Drawing.Size(388, 23);
            this.btnAddArtist.TabIndex = 1;
            this.btnAddArtist.Text = "Toevoegen";
            this.btnAddArtist.UseVisualStyleBackColor = true;
            this.btnAddArtist.Click += new System.EventHandler(this.button1_Click);
            // 
            // bdayLabel
            // 
            this.bdayLabel.AutoSize = true;
            this.bdayLabel.Location = new System.Drawing.Point(3, 32);
            this.bdayLabel.Name = "bdayLabel";
            this.bdayLabel.Size = new System.Drawing.Size(85, 13);
            this.bdayLabel.TabIndex = 2;
            this.bdayLabel.Text = "Geboorte Datum";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(3, 6);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Naam";
            // 
            // tbArtistName
            // 
            this.tbArtistName.Location = new System.Drawing.Point(94, 3);
            this.tbArtistName.Name = "tbArtistName";
            this.tbArtistName.Size = new System.Drawing.Size(300, 20);
            this.tbArtistName.TabIndex = 3;
            // 
            // AddArtistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 79);
            this.Controls.Add(this.tbArtistName);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.bdayLabel);
            this.Controls.Add(this.btnAddArtist);
            this.Controls.Add(this.dtpArtistBday);
            this.Name = "AddArtistForm";
            this.Text = "Artiest Toevoegen";
            this.Load += new System.EventHandler(this.AddArtistForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpArtistBday;
        private System.Windows.Forms.Button btnAddArtist;
        private System.Windows.Forms.Label bdayLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox tbArtistName;
    }
}