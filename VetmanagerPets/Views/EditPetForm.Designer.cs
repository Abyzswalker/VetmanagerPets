namespace VetmanagerPets.Views
{
    partial class EditPetForm
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
            this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.petBirthdayLabel = new System.Windows.Forms.Label();
            this.petSexLabel = new System.Windows.Forms.Label();
            this.petBreedLabel = new System.Windows.Forms.Label();
            this.petTypeLabel = new System.Windows.Forms.Label();
            this.petAliasLabel = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.savePetBtn = new System.Windows.Forms.Button();
            this.petSexComboBox = new System.Windows.Forms.ComboBox();
            this.petBreedComboBox = new System.Windows.Forms.ComboBox();
            this.petTypeComboBox = new System.Windows.Forms.ComboBox();
            this.petAliasTextBox = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // birthdayDateTimePicker
            // 
            this.birthdayDateTimePicker.Location = new System.Drawing.Point(90, 195);
            this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            this.birthdayDateTimePicker.Size = new System.Drawing.Size(188, 20);
            this.birthdayDateTimePicker.TabIndex = 29;
            // 
            // petBirthdayLabel
            // 
            this.petBirthdayLabel.AutoSize = true;
            this.petBirthdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.petBirthdayLabel.Location = new System.Drawing.Point(6, 199);
            this.petBirthdayLabel.Name = "petBirthdayLabel";
            this.petBirthdayLabel.Size = new System.Drawing.Size(78, 16);
            this.petBirthdayLabel.TabIndex = 28;
            this.petBirthdayLabel.Text = "Дата рожд:";
            // 
            // petSexLabel
            // 
            this.petSexLabel.AutoSize = true;
            this.petSexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.petSexLabel.Location = new System.Drawing.Point(9, 158);
            this.petSexLabel.Name = "petSexLabel";
            this.petSexLabel.Size = new System.Drawing.Size(41, 18);
            this.petSexLabel.TabIndex = 27;
            this.petSexLabel.Text = "Пол:";
            // 
            // petBreedLabel
            // 
            this.petBreedLabel.AutoSize = true;
            this.petBreedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.petBreedLabel.Location = new System.Drawing.Point(6, 111);
            this.petBreedLabel.Name = "petBreedLabel";
            this.petBreedLabel.Size = new System.Drawing.Size(72, 18);
            this.petBreedLabel.TabIndex = 26;
            this.petBreedLabel.Text = "Порода:*";
            // 
            // petTypeLabel
            // 
            this.petTypeLabel.AutoSize = true;
            this.petTypeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.petTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.petTypeLabel.Location = new System.Drawing.Point(6, 64);
            this.petTypeLabel.Name = "petTypeLabel";
            this.petTypeLabel.Size = new System.Drawing.Size(43, 18);
            this.petTypeLabel.TabIndex = 25;
            this.petTypeLabel.Text = "Тип:*";
            // 
            // petAliasLabel
            // 
            this.petAliasLabel.AutoSize = true;
            this.petAliasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.petAliasLabel.Location = new System.Drawing.Point(6, 21);
            this.petAliasLabel.Name = "petAliasLabel";
            this.petAliasLabel.Size = new System.Drawing.Size(69, 18);
            this.petAliasLabel.TabIndex = 24;
            this.petAliasLabel.Text = "Кличка:*";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(178, 336);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 23;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // savePetBtn
            // 
            this.savePetBtn.Location = new System.Drawing.Point(45, 336);
            this.savePetBtn.Name = "savePetBtn";
            this.savePetBtn.Size = new System.Drawing.Size(75, 23);
            this.savePetBtn.TabIndex = 22;
            this.savePetBtn.Text = "Сохранить";
            this.savePetBtn.UseVisualStyleBackColor = true;
            this.savePetBtn.Click += new System.EventHandler(this.savePetBtn_Click);
            // 
            // petSexComboBox
            // 
            this.petSexComboBox.FormattingEnabled = true;
            this.petSexComboBox.Location = new System.Drawing.Point(88, 158);
            this.petSexComboBox.Name = "petSexComboBox";
            this.petSexComboBox.Size = new System.Drawing.Size(188, 21);
            this.petSexComboBox.TabIndex = 21;
            // 
            // petBreedComboBox
            // 
            this.petBreedComboBox.FormattingEnabled = true;
            this.petBreedComboBox.Location = new System.Drawing.Point(88, 112);
            this.petBreedComboBox.Name = "petBreedComboBox";
            this.petBreedComboBox.Size = new System.Drawing.Size(188, 21);
            this.petBreedComboBox.TabIndex = 20;
            // 
            // petTypeComboBox
            // 
            this.petTypeComboBox.FormattingEnabled = true;
            this.petTypeComboBox.Location = new System.Drawing.Point(88, 64);
            this.petTypeComboBox.Name = "petTypeComboBox";
            this.petTypeComboBox.Size = new System.Drawing.Size(188, 21);
            this.petTypeComboBox.TabIndex = 19;
            // 
            // petAliasTextBox
            // 
            this.petAliasTextBox.Location = new System.Drawing.Point(88, 22);
            this.petAliasTextBox.Name = "petAliasTextBox";
            this.petAliasTextBox.Size = new System.Drawing.Size(188, 20);
            this.petAliasTextBox.TabIndex = 18;
            // 
            // EditPetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 381);
            this.Controls.Add(this.birthdayDateTimePicker);
            this.Controls.Add(this.petBirthdayLabel);
            this.Controls.Add(this.petSexLabel);
            this.Controls.Add(this.petBreedLabel);
            this.Controls.Add(this.petTypeLabel);
            this.Controls.Add(this.petAliasLabel);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.savePetBtn);
            this.Controls.Add(this.petSexComboBox);
            this.Controls.Add(this.petBreedComboBox);
            this.Controls.Add(this.petTypeComboBox);
            this.Controls.Add(this.petAliasTextBox);
            this.Name = "EditPetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование питомца";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
        private System.Windows.Forms.Label petBirthdayLabel;
        private System.Windows.Forms.Label petSexLabel;
        private System.Windows.Forms.Label petBreedLabel;
        private System.Windows.Forms.Label petTypeLabel;
        private System.Windows.Forms.Label petAliasLabel;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button savePetBtn;
        private System.Windows.Forms.ComboBox petSexComboBox;
        private System.Windows.Forms.ComboBox petBreedComboBox;
        private System.Windows.Forms.ComboBox petTypeComboBox;
        private System.Windows.Forms.TextBox petAliasTextBox;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}