namespace Cinema.WinUI
{
    partial class FormCastUpdate
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
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblCastLastName = new System.Windows.Forms.Label();
            this.lblCastFirstName = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(144, 108);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(165, 22);
            this.txtLastName.TabIndex = 14;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(144, 52);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(165, 22);
            this.txtFirstName.TabIndex = 13;
            // 
            // lblCastLastName
            // 
            this.lblCastLastName.AutoSize = true;
            this.lblCastLastName.Location = new System.Drawing.Point(60, 111);
            this.lblCastLastName.Name = "lblCastLastName";
            this.lblCastLastName.Size = new System.Drawing.Size(48, 17);
            this.lblCastLastName.TabIndex = 12;
            this.lblCastLastName.Text = "Soyad";
            // 
            // lblCastFirstName
            // 
            this.lblCastFirstName.AutoSize = true;
            this.lblCastFirstName.Location = new System.Drawing.Point(60, 55);
            this.lblCastFirstName.Name = "lblCastFirstName";
            this.lblCastFirstName.Size = new System.Drawing.Size(25, 17);
            this.lblCastFirstName.TabIndex = 11;
            this.lblCastFirstName.Text = "Ad";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(221, 169);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 30);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FormCastUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 242);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblCastLastName);
            this.Controls.Add(this.lblCastFirstName);
            this.Controls.Add(this.btnUpdate);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormCastUpdate";
            this.Text = "Oyuncu Güncelle";
            this.Load += new System.EventHandler(this.FormCastUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblCastLastName;
        private System.Windows.Forms.Label lblCastFirstName;
        private System.Windows.Forms.Button btnUpdate;
    }
}