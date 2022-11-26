namespace VetmanagerPets
{
    partial class SettingsForm
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
            this.domenLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.domenField = new System.Windows.Forms.TextBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.passField = new System.Windows.Forms.TextBox();
            this.connectBtn = new System.Windows.Forms.Button();
            this.CloseSettingsFormBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // domenLabel
            // 
            this.domenLabel.AutoSize = true;
            this.domenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.domenLabel.Location = new System.Drawing.Point(30, 35);
            this.domenLabel.Name = "domenLabel";
            this.domenLabel.Size = new System.Drawing.Size(60, 18);
            this.domenLabel.TabIndex = 1;
            this.domenLabel.Text = "Домен:";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(30, 77);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(50, 18);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Логин";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passLabel.Location = new System.Drawing.Point(30, 116);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(61, 18);
            this.passLabel.TabIndex = 3;
            this.passLabel.Text = "Пароль";
            // 
            // domenField
            // 
            this.domenField.Location = new System.Drawing.Point(102, 36);
            this.domenField.Name = "domenField";
            this.domenField.Size = new System.Drawing.Size(279, 20);
            this.domenField.TabIndex = 4;
            this.domenField.TextChanged += new System.EventHandler(this.domenField_TextChanged);
            // 
            // loginField
            // 
            this.loginField.Location = new System.Drawing.Point(102, 78);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(279, 20);
            this.loginField.TabIndex = 5;
            this.loginField.TextChanged += new System.EventHandler(this.loginField_TextChanged);
            // 
            // passField
            // 
            this.passField.Location = new System.Drawing.Point(102, 117);
            this.passField.Name = "passField";
            this.passField.PasswordChar = '*';
            this.passField.Size = new System.Drawing.Size(279, 20);
            this.passField.TabIndex = 6;
            this.passField.TextChanged += new System.EventHandler(this.passField_TextChanged);
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(102, 218);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(140, 32);
            this.connectBtn.TabIndex = 7;
            this.connectBtn.Text = "Связать";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // CloseSettingsFormBtn
            // 
            this.CloseSettingsFormBtn.Location = new System.Drawing.Point(297, 218);
            this.CloseSettingsFormBtn.Name = "CloseSettingsFormBtn";
            this.CloseSettingsFormBtn.Size = new System.Drawing.Size(140, 32);
            this.CloseSettingsFormBtn.TabIndex = 8;
            this.CloseSettingsFormBtn.Text = "Отмена";
            this.CloseSettingsFormBtn.UseVisualStyleBackColor = true;
            this.CloseSettingsFormBtn.Click += new System.EventHandler(this.CloseSettingsFormBtn_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 262);
            this.Controls.Add(this.CloseSettingsFormBtn);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.domenField);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.domenLabel);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройка API";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label domenLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox domenField;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Button CloseSettingsFormBtn;
    }
}