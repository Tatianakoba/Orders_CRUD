namespace Main
{
    partial class Create_Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create_Client));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ClientName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CancelClientButton = new System.Windows.Forms.Button();
            this.CreateClientButton = new System.Windows.Forms.Button();
            this.ClientPassportField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(239, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Создание нового клиента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(59, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Фамилия Имя Отчество";
            // 
            // ClientName
            // 
            this.ClientName.Location = new System.Drawing.Point(261, 115);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(352, 20);
            this.ClientName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(59, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Серия и номер паспорта";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // CancelClientButton
            // 
            this.CancelClientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelClientButton.Location = new System.Drawing.Point(287, 301);
            this.CancelClientButton.Name = "CancelClientButton";
            this.CancelClientButton.Size = new System.Drawing.Size(173, 60);
            this.CancelClientButton.TabIndex = 2;
            this.CancelClientButton.Text = "Отмена";
            this.CancelClientButton.UseVisualStyleBackColor = true;
            this.CancelClientButton.Click += new System.EventHandler(this.CancelClientButton_Click);
            // 
            // CreateClientButton
            // 
            this.CreateClientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateClientButton.Location = new System.Drawing.Point(287, 235);
            this.CreateClientButton.Name = "CreateClientButton";
            this.CreateClientButton.Size = new System.Drawing.Size(173, 60);
            this.CreateClientButton.TabIndex = 2;
            this.CreateClientButton.Text = "Создать";
            this.CreateClientButton.UseVisualStyleBackColor = true;
            this.CreateClientButton.Click += new System.EventHandler(this.CancelClientButton_Click);
            // 
            // ClientPassportField
            // 
            this.ClientPassportField.Location = new System.Drawing.Point(260, 161);
            this.ClientPassportField.Name = "ClientPassportField";
            this.ClientPassportField.Size = new System.Drawing.Size(352, 20);
            this.ClientPassportField.TabIndex = 1;
            // 
            // Create_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreateClientButton);
            this.Controls.Add(this.CancelClientButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ClientPassportField);
            this.Controls.Add(this.ClientName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Create_Client";
            this.Text = "Создание нового Клиента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ClientName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CancelClientButton;
        private System.Windows.Forms.Button CreateClientButton;
        private System.Windows.Forms.TextBox ClientPassportField;
    }
}