﻿namespace VetmanagerPets.Views
{
    partial class DeleteForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.confirmDeleteBtn = new System.Windows.Forms.Button();
            this.cancelDeleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вы действительно хотите удалить питомца?";
            // 
            // confirmDeleteBtn
            // 
            this.confirmDeleteBtn.Location = new System.Drawing.Point(98, 79);
            this.confirmDeleteBtn.Name = "confirmDeleteBtn";
            this.confirmDeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.confirmDeleteBtn.TabIndex = 1;
            this.confirmDeleteBtn.Text = "Да";
            this.confirmDeleteBtn.UseVisualStyleBackColor = true;
            this.confirmDeleteBtn.Click += new System.EventHandler(this.confirmDeleteBtn_Click);
            // 
            // cancelDeleteBtn
            // 
            this.cancelDeleteBtn.Location = new System.Drawing.Point(230, 79);
            this.cancelDeleteBtn.Name = "cancelDeleteBtn";
            this.cancelDeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelDeleteBtn.TabIndex = 2;
            this.cancelDeleteBtn.Text = "Отмена";
            this.cancelDeleteBtn.UseVisualStyleBackColor = true;
            this.cancelDeleteBtn.Click += new System.EventHandler(this.cancelDeleteBtn_Click);
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 115);
            this.Controls.Add(this.cancelDeleteBtn);
            this.Controls.Add(this.confirmDeleteBtn);
            this.Controls.Add(this.label1);
            this.Name = "DeleteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удаление питомца";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirmDeleteBtn;
        private System.Windows.Forms.Button cancelDeleteBtn;
    }
}