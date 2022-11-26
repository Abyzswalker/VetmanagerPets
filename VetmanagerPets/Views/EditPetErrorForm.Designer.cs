namespace VetmanagerPets.Views
{
    partial class EditPetErrorForm
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
            this.AddPetErrorBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddPetErrorBtn
            // 
            this.AddPetErrorBtn.Location = new System.Drawing.Point(138, 73);
            this.AddPetErrorBtn.Name = "AddPetErrorBtn";
            this.AddPetErrorBtn.Size = new System.Drawing.Size(90, 23);
            this.AddPetErrorBtn.TabIndex = 3;
            this.AddPetErrorBtn.Text = "Ok";
            this.AddPetErrorBtn.UseVisualStyleBackColor = true;
            this.AddPetErrorBtn.Click += new System.EventHandler(this.AddPetErrorBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(67, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ошибка добавления питомца.";
            // 
            // EditPetErrorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 108);
            this.Controls.Add(this.AddPetErrorBtn);
            this.Controls.Add(this.label1);
            this.Name = "EditPetErrorForm";
            this.Text = "EditPetErrorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddPetErrorBtn;
        private System.Windows.Forms.Label label1;
    }
}