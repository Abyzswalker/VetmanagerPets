namespace VetmanagerPets
{
    partial class СonnectionSuccessfulForm
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
            this.СonnectionSuccessfulBtn = new System.Windows.Forms.Button();
            this.СonnectionSuccessfulLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // СonnectionSuccessfulBtn
            // 
            this.СonnectionSuccessfulBtn.Location = new System.Drawing.Point(84, 86);
            this.СonnectionSuccessfulBtn.Name = "СonnectionSuccessfulBtn";
            this.СonnectionSuccessfulBtn.Size = new System.Drawing.Size(102, 23);
            this.СonnectionSuccessfulBtn.TabIndex = 0;
            this.СonnectionSuccessfulBtn.Text = "Ok";
            this.СonnectionSuccessfulBtn.UseVisualStyleBackColor = true;
            this.СonnectionSuccessfulBtn.Click += new System.EventHandler(this.СonnectionSuccessfulBtn_Click);
            // 
            // СonnectionSuccessfulLabel
            // 
            this.СonnectionSuccessfulLabel.AutoSize = true;
            this.СonnectionSuccessfulLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.СonnectionSuccessfulLabel.Location = new System.Drawing.Point(19, 36);
            this.СonnectionSuccessfulLabel.Name = "СonnectionSuccessfulLabel";
            this.СonnectionSuccessfulLabel.Size = new System.Drawing.Size(237, 16);
            this.СonnectionSuccessfulLabel.TabIndex = 1;
            this.СonnectionSuccessfulLabel.Text = "Настройки сохранены успешно";
            // 
            // СonnectionSuccessfulForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 121);
            this.Controls.Add(this.СonnectionSuccessfulLabel);
            this.Controls.Add(this.СonnectionSuccessfulBtn);
            this.Name = "СonnectionSuccessfulForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подключение успешно";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button СonnectionSuccessfulBtn;
        private System.Windows.Forms.Label СonnectionSuccessfulLabel;
    }
}