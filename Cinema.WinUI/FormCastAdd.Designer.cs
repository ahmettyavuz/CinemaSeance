namespace CinemaSeans.UI
{
    partial class FormCastAdd
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblCastFirstName = new System.Windows.Forms.Label();
            this.lblCastLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(156, 118);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 24);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblCastFirstName
            // 
            this.lblCastFirstName.AutoSize = true;
            this.lblCastFirstName.Location = new System.Drawing.Point(34, 25);
            this.lblCastFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCastFirstName.Name = "lblCastFirstName";
            this.lblCastFirstName.Size = new System.Drawing.Size(20, 13);
            this.lblCastFirstName.TabIndex = 1;
            this.lblCastFirstName.Text = "Ad";
            // 
            // lblCastLastName
            // 
            this.lblCastLastName.AutoSize = true;
            this.lblCastLastName.Location = new System.Drawing.Point(34, 71);
            this.lblCastLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCastLastName.Name = "lblCastLastName";
            this.lblCastLastName.Size = new System.Drawing.Size(37, 13);
            this.lblCastLastName.TabIndex = 2;
            this.lblCastLastName.Text = "Soyad";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(98, 23);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(125, 20);
            this.txtFirstName.TabIndex = 3;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(98, 68);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(125, 20);
            this.txtLastName.TabIndex = 4;
            // 
            // FormCastAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 193);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblCastLastName);
            this.Controls.Add(this.lblCastFirstName);
            this.Controls.Add(this.btnAdd);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormCastAdd";
            this.Text = "Oyuncu Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblCastFirstName;
        private System.Windows.Forms.Label lblCastLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
    }
}