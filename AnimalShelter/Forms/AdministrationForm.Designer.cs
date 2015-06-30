namespace AnimalShelter.Forms
{
    partial class AdministrationForm
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
            this.labelReserved = new System.Windows.Forms.Label();
            this.labelNotReserved = new System.Windows.Forms.Label();
            this.listboxNotReserved = new System.Windows.Forms.ListBox();
            this.listboxReserved = new System.Windows.Forms.ListBox();
            this.buttonReserve = new System.Windows.Forms.Button();
            this.buttonUnReserve = new System.Windows.Forms.Button();
            this.buttonSell = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAnimalButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelReserved
            // 
            this.labelReserved.AutoSize = true;
            this.labelReserved.Location = new System.Drawing.Point(543, 3);
            this.labelReserved.Name = "labelReserved";
            this.labelReserved.Size = new System.Drawing.Size(53, 13);
            this.labelReserved.TabIndex = 5;
            this.labelReserved.Text = "Reserved";
            // 
            // labelNotReserved
            // 
            this.labelNotReserved.AutoSize = true;
            this.labelNotReserved.Location = new System.Drawing.Point(144, 3);
            this.labelNotReserved.Name = "labelNotReserved";
            this.labelNotReserved.Size = new System.Drawing.Size(73, 13);
            this.labelNotReserved.TabIndex = 5;
            this.labelNotReserved.Text = "Not Reserved";
            // 
            // listboxNotReserved
            // 
            this.listboxNotReserved.FormattingEnabled = true;
            this.listboxNotReserved.Location = new System.Drawing.Point(12, 27);
            this.listboxNotReserved.Name = "listboxNotReserved";
            this.listboxNotReserved.Size = new System.Drawing.Size(322, 329);
            this.listboxNotReserved.TabIndex = 6;
            this.listboxNotReserved.SelectedIndexChanged += new System.EventHandler(this.listboxNotReserved_SelectedIndexChanged);
            // 
            // listboxReserved
            // 
            this.listboxReserved.FormattingEnabled = true;
            this.listboxReserved.Location = new System.Drawing.Point(413, 27);
            this.listboxReserved.Name = "listboxReserved";
            this.listboxReserved.Size = new System.Drawing.Size(323, 329);
            this.listboxReserved.TabIndex = 6;
            this.listboxReserved.SelectedIndexChanged += new System.EventHandler(this.listboxReserved_SelectedIndexChanged);
            // 
            // buttonReserve
            // 
            this.buttonReserve.Location = new System.Drawing.Point(340, 176);
            this.buttonReserve.Name = "buttonReserve";
            this.buttonReserve.Size = new System.Drawing.Size(67, 56);
            this.buttonReserve.TabIndex = 7;
            this.buttonReserve.Text = ">>";
            this.buttonReserve.UseVisualStyleBackColor = true;
            this.buttonReserve.Visible = false;
            this.buttonReserve.Click += new System.EventHandler(this.buttonReserve_Click);
            // 
            // buttonUnReserve
            // 
            this.buttonUnReserve.Location = new System.Drawing.Point(340, 176);
            this.buttonUnReserve.Name = "buttonUnReserve";
            this.buttonUnReserve.Size = new System.Drawing.Size(67, 56);
            this.buttonUnReserve.TabIndex = 7;
            this.buttonUnReserve.Text = "<<";
            this.buttonUnReserve.UseVisualStyleBackColor = true;
            this.buttonUnReserve.Visible = false;
            this.buttonUnReserve.Click += new System.EventHandler(this.buttonUnReserve_Click);
            // 
            // buttonSell
            // 
            this.buttonSell.Location = new System.Drawing.Point(340, 238);
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.Size = new System.Drawing.Size(67, 56);
            this.buttonSell.TabIndex = 7;
            this.buttonSell.Text = "Sell";
            this.buttonSell.UseVisualStyleBackColor = true;
            this.buttonSell.Visible = false;
            this.buttonSell.Click += new System.EventHandler(this.buttonSell_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(340, 300);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(67, 55);
            this.buttonModify.TabIndex = 1;
            this.buttonModify.Text = "Modify";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Visible = false;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(340, 27);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(67, 81);
            this.buttonSort.TabIndex = 8;
            this.buttonSort.Text = "Sort both lists ascending";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(748, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // createAnimalButton
            // 
            this.createAnimalButton.Location = new System.Drawing.Point(340, 114);
            this.createAnimalButton.Name = "createAnimalButton";
            this.createAnimalButton.Size = new System.Drawing.Size(67, 56);
            this.createAnimalButton.TabIndex = 1;
            this.createAnimalButton.Text = "Create New Animal";
            this.createAnimalButton.UseVisualStyleBackColor = true;
            this.createAnimalButton.Click += new System.EventHandler(this.createAnimalButton_Click);
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 367);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonSell);
            this.Controls.Add(this.buttonUnReserve);
            this.Controls.Add(this.buttonReserve);
            this.Controls.Add(this.listboxReserved);
            this.Controls.Add(this.listboxNotReserved);
            this.Controls.Add(this.labelNotReserved);
            this.Controls.Add(this.labelReserved);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.createAnimalButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "AdministrationForm";
            this.Text = "Animal Shelter";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelReserved;
        private System.Windows.Forms.Label labelNotReserved;
        private System.Windows.Forms.ListBox listboxNotReserved;
        private System.Windows.Forms.ListBox listboxReserved;
        private System.Windows.Forms.Button buttonReserve;
        private System.Windows.Forms.Button buttonUnReserve;
        private System.Windows.Forms.Button buttonSell;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.Button createAnimalButton;
    }
}

