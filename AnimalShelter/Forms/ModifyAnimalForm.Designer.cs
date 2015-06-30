namespace AnimalShelter.Forms
{
    partial class ModifyAnimalForm
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
            this.modifyAnimalButton = new System.Windows.Forms.Button();
            this.inputAnimalType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelDynamic
            // 
            this.labelDynamic.AutoSize = true;
            this.labelDynamic.Location = new System.Drawing.Point(12, 108);
            this.labelDynamic.Name = "labelDynamic";
            this.labelDynamic.Size = new System.Drawing.Size(59, 13);
            this.labelDynamic.TabIndex = 26;
            this.labelDynamic.Text = "Bad Habits";
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Location = new System.Drawing.Point(12, 66);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(51, 13);
            this.labelBirthDate.TabIndex = 27;
            this.labelBirthDate.Text = "BirthDate";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 40);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 28;
            this.labelName.Text = "Name";
            // 
            // labelAnimalType
            // 
            this.labelAnimalType.AutoSize = true;
            this.labelAnimalType.Location = new System.Drawing.Point(12, 9);
            this.labelAnimalType.Name = "labelAnimalType";
            this.labelAnimalType.Size = new System.Drawing.Size(65, 13);
            this.labelAnimalType.TabIndex = 29;
            this.labelAnimalType.Text = "Animal Type";
            // 
            // checkbox_Reserved
            // 
            this.checkbox_Reserved.AutoSize = true;
            this.checkbox_Reserved.Location = new System.Drawing.Point(110, 85);
            this.checkbox_Reserved.Name = "checkbox_Reserved";
            this.checkbox_Reserved.Size = new System.Drawing.Size(72, 17);
            this.checkbox_Reserved.TabIndex = 25;
            this.checkbox_Reserved.Text = "Reserved";
            this.checkbox_Reserved.UseVisualStyleBackColor = true;
            // 
            // inputBadHabits
            // 
            this.inputBadHabits.Location = new System.Drawing.Point(110, 105);
            this.inputBadHabits.Name = "inputBadHabits";
            this.inputBadHabits.Size = new System.Drawing.Size(193, 20);
            this.inputBadHabits.TabIndex = 23;
            // 
            // inputName
            // 
            this.inputName.Enabled = false;
            this.inputName.Location = new System.Drawing.Point(110, 33);
            this.inputName.Name = "inputName";
            this.inputName.ReadOnly = true;
            this.inputName.Size = new System.Drawing.Size(193, 20);
            this.inputName.TabIndex = 24;
            // 
            // inputLastWalkDate
            // 
            this.inputLastWalkDate.Location = new System.Drawing.Point(110, 105);
            this.inputLastWalkDate.Name = "inputLastWalkDate";
            this.inputLastWalkDate.Size = new System.Drawing.Size(193, 20);
            this.inputLastWalkDate.TabIndex = 21;
            // 
            // inputBirthDate
            // 
            this.inputBirthDate.Enabled = false;
            this.inputBirthDate.Location = new System.Drawing.Point(110, 59);
            this.inputBirthDate.Name = "inputBirthDate";
            this.inputBirthDate.Size = new System.Drawing.Size(193, 20);
            this.inputBirthDate.TabIndex = 22;
            // 
            // modifyAnimalButton
            // 
            this.modifyAnimalButton.Location = new System.Drawing.Point(15, 131);
            this.modifyAnimalButton.Name = "modifyAnimalButton";
            this.modifyAnimalButton.Size = new System.Drawing.Size(288, 23);
            this.modifyAnimalButton.TabIndex = 20;
            this.modifyAnimalButton.Text = "Modify";
            this.modifyAnimalButton.UseVisualStyleBackColor = true;
            this.modifyAnimalButton.Click += new System.EventHandler(this.modifyAnimalButton_Click);
            // 
            // inputAnimalType
            // 
            this.inputAnimalType.DisplayMember = "Cat";
            this.inputAnimalType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputAnimalType.Enabled = false;
            this.inputAnimalType.FormattingEnabled = true;
            this.inputAnimalType.Items.AddRange(new object[] {
            "Cat",
            "Dog"});
            this.inputAnimalType.Location = new System.Drawing.Point(110, 6);
            this.inputAnimalType.Name = "inputAnimalType";
            this.inputAnimalType.Size = new System.Drawing.Size(193, 21);
            this.inputAnimalType.TabIndex = 19;
            // 
            // ModifyAnimalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 162);
            this.Controls.Add(this.labelDynamic);
            this.Controls.Add(this.labelBirthDate);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelAnimalType);
            this.Controls.Add(this.checkbox_Reserved);
            this.Controls.Add(this.inputBadHabits);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.inputLastWalkDate);
            this.Controls.Add(this.inputBirthDate);
            this.Controls.Add(this.modifyAnimalButton);
            this.Controls.Add(this.inputAnimalType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModifyAnimalForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Modify Animal";
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
        private System.Windows.Forms.Button modifyAnimalButton;
        private System.Windows.Forms.ComboBox inputAnimalType;
    }
}