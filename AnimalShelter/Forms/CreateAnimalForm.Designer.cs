namespace AnimalShelter.Forms
{
    partial class CreateAnimalForm
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
            this.labelDynamic = new System.Windows.Forms.Label();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAnimalType = new System.Windows.Forms.Label();
            this.checkbox_Reserved = new System.Windows.Forms.CheckBox();
            this.inputBadHabits = new System.Windows.Forms.TextBox();
            this.inputName = new System.Windows.Forms.TextBox();
            this.inputLastWalkDate = new System.Windows.Forms.DateTimePicker();
            this.inputBirthDate = new System.Windows.Forms.DateTimePicker();
            this.createAnimalButton = new System.Windows.Forms.Button();
            this.inputAnimalType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelDynamic
            // 
            this.labelDynamic.AutoSize = true;
            this.labelDynamic.Location = new System.Drawing.Point(8, 114);
            this.labelDynamic.Name = "labelDynamic";
            this.labelDynamic.Size = new System.Drawing.Size(59, 13);
            this.labelDynamic.TabIndex = 15;
            this.labelDynamic.Text = "Bad Habits";
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Location = new System.Drawing.Point(8, 72);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(51, 13);
            this.labelBirthDate.TabIndex = 16;
            this.labelBirthDate.Text = "BirthDate";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(8, 46);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 17;
            this.labelName.Text = "Name";
            // 
            // labelAnimalType
            // 
            this.labelAnimalType.AutoSize = true;
            this.labelAnimalType.Location = new System.Drawing.Point(8, 15);
            this.labelAnimalType.Name = "labelAnimalType";
            this.labelAnimalType.Size = new System.Drawing.Size(65, 13);
            this.labelAnimalType.TabIndex = 18;
            this.labelAnimalType.Text = "Animal Type";
            // 
            // checkbox_Reserved
            // 
            this.checkbox_Reserved.AutoSize = true;
            this.checkbox_Reserved.Location = new System.Drawing.Point(106, 91);
            this.checkbox_Reserved.Name = "checkbox_Reserved";
            this.checkbox_Reserved.Size = new System.Drawing.Size(72, 17);
            this.checkbox_Reserved.TabIndex = 12;
            this.checkbox_Reserved.Text = "Reserved";
            this.checkbox_Reserved.UseVisualStyleBackColor = true;
            // 
            // inputBadHabits
            // 
            this.inputBadHabits.Location = new System.Drawing.Point(106, 111);
            this.inputBadHabits.Name = "inputBadHabits";
            this.inputBadHabits.Size = new System.Drawing.Size(193, 20);
            this.inputBadHabits.TabIndex = 10;
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(106, 39);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(193, 20);
            this.inputName.TabIndex = 11;
            // 
            // inputLastWalkDate
            // 
            this.inputLastWalkDate.Location = new System.Drawing.Point(106, 111);
            this.inputLastWalkDate.Name = "inputLastWalkDate";
            this.inputLastWalkDate.Size = new System.Drawing.Size(193, 20);
            this.inputLastWalkDate.TabIndex = 8;
            // 
            // inputBirthDate
            // 
            this.inputBirthDate.Location = new System.Drawing.Point(106, 65);
            this.inputBirthDate.Name = "inputBirthDate";
            this.inputBirthDate.Size = new System.Drawing.Size(193, 20);
            this.inputBirthDate.TabIndex = 9;
            // 
            // createAnimalButton
            // 
            this.createAnimalButton.Location = new System.Drawing.Point(11, 137);
            this.createAnimalButton.Name = "createAnimalButton";
            this.createAnimalButton.Size = new System.Drawing.Size(288, 23);
            this.createAnimalButton.TabIndex = 7;
            this.createAnimalButton.Text = "Create";
            this.createAnimalButton.UseVisualStyleBackColor = true;
            this.createAnimalButton.Click += new System.EventHandler(this.createAnimalButton_Click);
            // 
            // inputAnimalType
            // 
            this.inputAnimalType.DisplayMember = "Cat";
            this.inputAnimalType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputAnimalType.FormattingEnabled = true;
            this.inputAnimalType.Items.AddRange(new object[] {
            "Cat",
            "Dog"});
            this.inputAnimalType.Location = new System.Drawing.Point(106, 12);
            this.inputAnimalType.Name = "inputAnimalType";
            this.inputAnimalType.Size = new System.Drawing.Size(193, 21);
            this.inputAnimalType.TabIndex = 6;
            this.inputAnimalType.SelectedIndexChanged += new System.EventHandler(this.inputAnimalType_SelectedIndexChanged);
            // 
            // CreateAnimalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 174);
            this.Controls.Add(this.labelDynamic);
            this.Controls.Add(this.labelBirthDate);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelAnimalType);
            this.Controls.Add(this.checkbox_Reserved);
            this.Controls.Add(this.inputBadHabits);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.inputLastWalkDate);
            this.Controls.Add(this.inputBirthDate);
            this.Controls.Add(this.createAnimalButton);
            this.Controls.Add(this.inputAnimalType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateAnimalForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Create New Animal";
            this.Load += new System.EventHandler(this.CreateAnimalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDynamic;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAnimalType;
        private System.Windows.Forms.CheckBox checkbox_Reserved;
        private System.Windows.Forms.TextBox inputBadHabits;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.DateTimePicker inputLastWalkDate;
        private System.Windows.Forms.DateTimePicker inputBirthDate;
        private System.Windows.Forms.Button createAnimalButton;
        private System.Windows.Forms.ComboBox inputAnimalType;
    }
}