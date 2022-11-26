namespace VetmanagerPets
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clientsCombo = new System.Windows.Forms.ComboBox();
            this.openSettingsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deletePetBtn = new System.Windows.Forms.Button();
            this.editPetBtn = new System.Windows.Forms.Button();
            this.addPetBtn = new System.Windows.Forms.Button();
            this.petsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.petsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // clientsCombo
            // 
            this.clientsCombo.FormattingEnabled = true;
            this.clientsCombo.Location = new System.Drawing.Point(62, 12);
            this.clientsCombo.Name = "clientsCombo";
            this.clientsCombo.Size = new System.Drawing.Size(121, 21);
            this.clientsCombo.TabIndex = 1;
            // 
            // openSettingsBtn
            // 
            this.openSettingsBtn.Location = new System.Drawing.Point(629, 10);
            this.openSettingsBtn.Name = "openSettingsBtn";
            this.openSettingsBtn.Size = new System.Drawing.Size(159, 23);
            this.openSettingsBtn.TabIndex = 2;
            this.openSettingsBtn.Text = "Настройки API";
            this.openSettingsBtn.UseVisualStyleBackColor = true;
            this.openSettingsBtn.Click += new System.EventHandler(this.openSettingsBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Клиент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Питомцы клиента";
            // 
            // deletePetBtn
            // 
            this.deletePetBtn.Location = new System.Drawing.Point(563, 105);
            this.deletePetBtn.Name = "deletePetBtn";
            this.deletePetBtn.Size = new System.Drawing.Size(124, 23);
            this.deletePetBtn.TabIndex = 6;
            this.deletePetBtn.Text = "Удалить";
            this.deletePetBtn.UseVisualStyleBackColor = true;
            this.deletePetBtn.Click += new System.EventHandler(this.deletePetBtn_Click);
            // 
            // editPetBtn
            // 
            this.editPetBtn.Location = new System.Drawing.Point(406, 105);
            this.editPetBtn.Name = "editPetBtn";
            this.editPetBtn.Size = new System.Drawing.Size(109, 23);
            this.editPetBtn.TabIndex = 7;
            this.editPetBtn.Text = "Редактировать";
            this.editPetBtn.UseVisualStyleBackColor = true;
            this.editPetBtn.Click += new System.EventHandler(this.editPetBtn_Click);
            // 
            // addPetBtn
            // 
            this.addPetBtn.Location = new System.Drawing.Point(243, 105);
            this.addPetBtn.Name = "addPetBtn";
            this.addPetBtn.Size = new System.Drawing.Size(118, 23);
            this.addPetBtn.TabIndex = 8;
            this.addPetBtn.Text = "Добавить";
            this.addPetBtn.UseVisualStyleBackColor = true;
            this.addPetBtn.Click += new System.EventHandler(this.addPetBtn_Click);
            // 
            // petsDataGridView
            // 
            this.petsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.petsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.petsDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.petsDataGridView.Location = new System.Drawing.Point(0, 134);
            this.petsDataGridView.Name = "petsDataGridView";
            this.petsDataGridView.Size = new System.Drawing.Size(800, 316);
            this.petsDataGridView.TabIndex = 9;
            this.petsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.petsDataGridView_CellClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.petsDataGridView);
            this.Controls.Add(this.addPetBtn);
            this.Controls.Add(this.editPetBtn);
            this.Controls.Add(this.deletePetBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openSettingsBtn);
            this.Controls.Add(this.clientsCombo);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VetmanagerPets";
            ((System.ComponentModel.ISupportInitialize)(this.petsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox clientsCombo;
        private System.Windows.Forms.Button openSettingsBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deletePetBtn;
        private System.Windows.Forms.Button editPetBtn;
        private System.Windows.Forms.Button addPetBtn;
        private System.Windows.Forms.DataGridView petsDataGridView;
    }
}