namespace MusicPlayer
{
    partial class AddSongForm
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
            this.btnAddSong = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.rtbLyrics = new System.Windows.Forms.RichTextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lyricsLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.artistLabel = new System.Windows.Forms.Label();
            this.lbArtists = new System.Windows.Forms.ListBox();
            this.fileLabel = new System.Windows.Forms.Label();
            this.btnfilePath = new System.Windows.Forms.Button();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnAddArtist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddSong
            // 
            this.btnAddSong.Location = new System.Drawing.Point(12, 385);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(529, 23);
            this.btnAddSong.TabIndex = 0;
            this.btnAddSong.Text = "Toevoegen";
            this.btnAddSong.UseVisualStyleBackColor = true;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(61, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(480, 20);
            this.tbName.TabIndex = 1;
            // 
            // rtbLyrics
            // 
            this.rtbLyrics.Location = new System.Drawing.Point(12, 243);
            this.rtbLyrics.Name = "rtbLyrics";
            this.rtbLyrics.Size = new System.Drawing.Size(529, 136);
            this.rtbLyrics.TabIndex = 2;
            this.rtbLyrics.Text = "";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(61, 38);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(480, 20);
            this.dtpDate.TabIndex = 3;
            // 
            // lyricsLabel
            // 
            this.lyricsLabel.AutoSize = true;
            this.lyricsLabel.Location = new System.Drawing.Point(249, 227);
            this.lyricsLabel.Name = "lyricsLabel";
            this.lyricsLabel.Size = new System.Drawing.Size(55, 13);
            this.lyricsLabel.TabIndex = 4;
            this.lyricsLabel.Text = "Songtekst";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(9, 15);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Naam";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(9, 44);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(38, 13);
            this.dateLabel.TabIndex = 4;
            this.dateLabel.Text = "Datum";
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.Location = new System.Drawing.Point(9, 110);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(36, 13);
            this.artistLabel.TabIndex = 4;
            this.artistLabel.Text = "Artiest";
            // 
            // lbArtists
            // 
            this.lbArtists.FormattingEnabled = true;
            this.lbArtists.Location = new System.Drawing.Point(61, 64);
            this.lbArtists.Name = "lbArtists";
            this.lbArtists.Size = new System.Drawing.Size(480, 95);
            this.lbArtists.TabIndex = 5;
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Location = new System.Drawing.Point(9, 198);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(46, 13);
            this.fileLabel.TabIndex = 4;
            this.fileLabel.Text = "Bestand";
            // 
            // btnfilePath
            // 
            this.btnfilePath.Location = new System.Drawing.Point(517, 193);
            this.btnfilePath.Name = "btnfilePath";
            this.btnfilePath.Size = new System.Drawing.Size(24, 23);
            this.btnfilePath.TabIndex = 6;
            this.btnfilePath.Text = "...";
            this.btnfilePath.UseVisualStyleBackColor = true;
            this.btnfilePath.Click += new System.EventHandler(this.btnfilePath_Click);
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(61, 195);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.ReadOnly = true;
            this.tbFilePath.Size = new System.Drawing.Size(450, 20);
            this.tbFilePath.TabIndex = 7;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnAddArtist
            // 
            this.btnAddArtist.Location = new System.Drawing.Point(61, 165);
            this.btnAddArtist.Name = "btnAddArtist";
            this.btnAddArtist.Size = new System.Drawing.Size(480, 23);
            this.btnAddArtist.TabIndex = 8;
            this.btnAddArtist.Text = "Nieuwe Artiest...";
            this.btnAddArtist.UseVisualStyleBackColor = true;
            this.btnAddArtist.Click += new System.EventHandler(this.btnAddArtist_Click);
            // 
            // AddSongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 413);
            this.Controls.Add(this.btnAddArtist);
            this.Controls.Add(this.tbFilePath);
            this.Controls.Add(this.btnfilePath);
            this.Controls.Add(this.lbArtists);
            this.Controls.Add(this.fileLabel);
            this.Controls.Add(this.artistLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.lyricsLabel);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.rtbLyrics);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnAddSong);
            this.Name = "AddSongForm";
            this.Text = "Song Toevoegen";
            this.Load += new System.EventHandler(this.AddSongForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.RichTextBox rtbLyrics;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lyricsLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label artistLabel;
        private System.Windows.Forms.ListBox lbArtists;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.Button btnfilePath;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnAddArtist;
    }
}