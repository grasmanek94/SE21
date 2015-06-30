namespace MusicPlayer
{
    partial class CreatePlaylistForm
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
            this.btnOK = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbSongs = new System.Windows.Forms.ListBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.songsLabel = new System.Windows.Forms.Label();
            this.btnNewSong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(12, 56);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(35, 225);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(65, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(506, 20);
            this.tbName.TabIndex = 1;
            // 
            // lbSongs
            // 
            this.lbSongs.FormattingEnabled = true;
            this.lbSongs.Location = new System.Drawing.Point(65, 40);
            this.lbSongs.Name = "lbSongs";
            this.lbSongs.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbSongs.Size = new System.Drawing.Size(506, 212);
            this.lbSongs.TabIndex = 2;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 15);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Naam";
            // 
            // songsLabel
            // 
            this.songsLabel.AutoSize = true;
            this.songsLabel.Location = new System.Drawing.Point(12, 40);
            this.songsLabel.Name = "songsLabel";
            this.songsLabel.Size = new System.Drawing.Size(37, 13);
            this.songsLabel.TabIndex = 3;
            this.songsLabel.Text = "Songs";
            // 
            // btnNewSong
            // 
            this.btnNewSong.Location = new System.Drawing.Point(65, 258);
            this.btnNewSong.Name = "btnNewSong";
            this.btnNewSong.Size = new System.Drawing.Size(506, 23);
            this.btnNewSong.TabIndex = 4;
            this.btnNewSong.Text = "Nieuwe song toevoegen...";
            this.btnNewSong.UseVisualStyleBackColor = true;
            this.btnNewSong.Click += new System.EventHandler(this.btnNewSong_Click);
            // 
            // CreatePlaylistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 291);
            this.Controls.Add(this.btnNewSong);
            this.Controls.Add(this.songsLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.lbSongs);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnOK);
            this.Name = "CreatePlaylistForm";
            this.Text = "Playlist Maken";
            this.Load += new System.EventHandler(this.CreatePlaylistForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ListBox lbSongs;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label songsLabel;
        private System.Windows.Forms.Button btnNewSong;
    }
}