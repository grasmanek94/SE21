namespace MusicPlayer
{
    partial class MusicPlayerForm
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
            this.btnAddArtist = new System.Windows.Forms.Button();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.btnCreatePlaylist = new System.Windows.Forms.Button();
            this.btnStopPlay = new System.Windows.Forms.Button();
            this.tcPlayLists = new System.Windows.Forms.TabControl();
            this.playlistsLabel = new System.Windows.Forms.Label();
            this.lbSongs = new System.Windows.Forms.ListBox();
            this.songsLabel = new System.Windows.Forms.Label();
            this.lbArtists = new System.Windows.Forms.ListBox();
            this.artistsLabel = new System.Windows.Forms.Label();
            this.btnRemoPlaylist = new System.Windows.Forms.Button();
            this.timeTracker = new System.Windows.Forms.TrackBar();
            this.remainingLabel = new System.Windows.Forms.Label();
            this.currentposLabel = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.timeTracker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddArtist
            // 
            this.btnAddArtist.Location = new System.Drawing.Point(12, 41);
            this.btnAddArtist.Name = "btnAddArtist";
            this.btnAddArtist.Size = new System.Drawing.Size(111, 104);
            this.btnAddArtist.TabIndex = 1;
            this.btnAddArtist.Text = "Artiest Toevoegen";
            this.btnAddArtist.UseVisualStyleBackColor = true;
            this.btnAddArtist.Click += new System.EventHandler(this.btnAddArtist_Click);
            // 
            // btnAddSong
            // 
            this.btnAddSong.Location = new System.Drawing.Point(12, 151);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(111, 104);
            this.btnAddSong.TabIndex = 2;
            this.btnAddSong.Text = "Song Toevoegen";
            this.btnAddSong.UseVisualStyleBackColor = true;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // btnCreatePlaylist
            // 
            this.btnCreatePlaylist.Location = new System.Drawing.Point(12, 261);
            this.btnCreatePlaylist.Name = "btnCreatePlaylist";
            this.btnCreatePlaylist.Size = new System.Drawing.Size(111, 104);
            this.btnCreatePlaylist.TabIndex = 3;
            this.btnCreatePlaylist.Text = "Playlist Maken";
            this.btnCreatePlaylist.UseVisualStyleBackColor = true;
            this.btnCreatePlaylist.Click += new System.EventHandler(this.btnCreatePlaylist_Click);
            // 
            // btnStopPlay
            // 
            this.btnStopPlay.Location = new System.Drawing.Point(12, 370);
            this.btnStopPlay.Name = "btnStopPlay";
            this.btnStopPlay.Size = new System.Drawing.Size(111, 104);
            this.btnStopPlay.TabIndex = 5;
            this.btnStopPlay.Text = "STOP";
            this.btnStopPlay.UseVisualStyleBackColor = true;
            this.btnStopPlay.Click += new System.EventHandler(this.btnStopPlay_Click);
            // 
            // tcPlayLists
            // 
            this.tcPlayLists.Location = new System.Drawing.Point(771, 41);
            this.tcPlayLists.Name = "tcPlayLists";
            this.tcPlayLists.SelectedIndex = 0;
            this.tcPlayLists.Size = new System.Drawing.Size(315, 329);
            this.tcPlayLists.TabIndex = 6;
            this.tcPlayLists.DoubleClick += new System.EventHandler(this.tcPlayLists_DoubleClick);
            // 
            // playlistsLabel
            // 
            this.playlistsLabel.AutoSize = true;
            this.playlistsLabel.Location = new System.Drawing.Point(768, 17);
            this.playlistsLabel.Name = "playlistsLabel";
            this.playlistsLabel.Size = new System.Drawing.Size(53, 13);
            this.playlistsLabel.TabIndex = 7;
            this.playlistsLabel.Text = "Playlijsten";
            // 
            // lbSongs
            // 
            this.lbSongs.FormattingEnabled = true;
            this.lbSongs.Location = new System.Drawing.Point(450, 41);
            this.lbSongs.Name = "lbSongs";
            this.lbSongs.Size = new System.Drawing.Size(315, 329);
            this.lbSongs.TabIndex = 8;
            this.lbSongs.DoubleClick += new System.EventHandler(this.lbSongs_DoubleClick);
            // 
            // songsLabel
            // 
            this.songsLabel.AutoSize = true;
            this.songsLabel.Location = new System.Drawing.Point(587, 17);
            this.songsLabel.Name = "songsLabel";
            this.songsLabel.Size = new System.Drawing.Size(37, 13);
            this.songsLabel.TabIndex = 7;
            this.songsLabel.Text = "Songs";
            // 
            // lbArtists
            // 
            this.lbArtists.FormattingEnabled = true;
            this.lbArtists.Location = new System.Drawing.Point(129, 41);
            this.lbArtists.Name = "lbArtists";
            this.lbArtists.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbArtists.Size = new System.Drawing.Size(315, 329);
            this.lbArtists.TabIndex = 8;
            // 
            // artistsLabel
            // 
            this.artistsLabel.AutoSize = true;
            this.artistsLabel.Location = new System.Drawing.Point(263, 17);
            this.artistsLabel.Name = "artistsLabel";
            this.artistsLabel.Size = new System.Drawing.Size(48, 13);
            this.artistsLabel.TabIndex = 7;
            this.artistsLabel.Text = "Artiesten";
            // 
            // btnRemoPlaylist
            // 
            this.btnRemoPlaylist.Location = new System.Drawing.Point(827, 12);
            this.btnRemoPlaylist.Name = "btnRemoPlaylist";
            this.btnRemoPlaylist.Size = new System.Drawing.Size(259, 23);
            this.btnRemoPlaylist.TabIndex = 9;
            this.btnRemoPlaylist.Text = "Verwijder Geselecteerde Playlist";
            this.btnRemoPlaylist.UseVisualStyleBackColor = true;
            this.btnRemoPlaylist.Click += new System.EventHandler(this.btnRemoPlaylist_Click);
            // 
            // timeTracker
            // 
            this.timeTracker.Location = new System.Drawing.Point(172, 376);
            this.timeTracker.Name = "timeTracker";
            this.timeTracker.Size = new System.Drawing.Size(864, 45);
            this.timeTracker.TabIndex = 10;
            this.timeTracker.Scroll += new System.EventHandler(this.timeTracker_Scroll);
            // 
            // remainingLabel
            // 
            this.remainingLabel.AutoSize = true;
            this.remainingLabel.Location = new System.Drawing.Point(1042, 385);
            this.remainingLabel.Name = "remainingLabel";
            this.remainingLabel.Size = new System.Drawing.Size(28, 13);
            this.remainingLabel.TabIndex = 11;
            this.remainingLabel.Text = "0:00";
            // 
            // currentposLabel
            // 
            this.currentposLabel.AutoSize = true;
            this.currentposLabel.Location = new System.Drawing.Point(138, 385);
            this.currentposLabel.Name = "currentposLabel";
            this.currentposLabel.Size = new System.Drawing.Size(28, 13);
            this.currentposLabel.TabIndex = 11;
            this.currentposLabel.Text = "0:00";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(759, 427);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(277, 45);
            this.trackBar1.TabIndex = 12;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(711, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Volume";
            // 
            // MusicPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 484);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentposLabel);
            this.Controls.Add(this.remainingLabel);
            this.Controls.Add(this.timeTracker);
            this.Controls.Add(this.btnRemoPlaylist);
            this.Controls.Add(this.lbArtists);
            this.Controls.Add(this.lbSongs);
            this.Controls.Add(this.artistsLabel);
            this.Controls.Add(this.songsLabel);
            this.Controls.Add(this.playlistsLabel);
            this.Controls.Add(this.tcPlayLists);
            this.Controls.Add(this.btnStopPlay);
            this.Controls.Add(this.btnCreatePlaylist);
            this.Controls.Add(this.btnAddSong);
            this.Controls.Add(this.btnAddArtist);
            this.Name = "MusicPlayerForm";
            this.Text = "Muziek Speler 2015";
            ((System.ComponentModel.ISupportInitialize)(this.timeTracker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddArtist;
        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.Button btnCreatePlaylist;
        private System.Windows.Forms.Button btnStopPlay;
        private System.Windows.Forms.TabControl tcPlayLists;
        private System.Windows.Forms.Label playlistsLabel;
        private System.Windows.Forms.ListBox lbSongs;
        private System.Windows.Forms.Label songsLabel;
        private System.Windows.Forms.ListBox lbArtists;
        private System.Windows.Forms.Label artistsLabel;
        private System.Windows.Forms.Button btnRemoPlaylist;
        private System.Windows.Forms.TrackBar timeTracker;
        private System.Windows.Forms.Label remainingLabel;
        private System.Windows.Forms.Label currentposLabel;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;

    }
}

