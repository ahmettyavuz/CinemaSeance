namespace CinemaSeans.UI
{
    partial class FormPasswordChange
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
            this.lblOldPass = new System.Windows.Forms.Label();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.txtNewPass2 = new System.Windows.Forms.TextBox();
            this.lblNewpass2 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOldPass
            // 
            this.lblOldPass.AutoSize = true;
            this.lblOldPass.Location = new System.Drawing.Point(9, 43);
            this.lblOldPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOldPass.Name = "lblOldPass";
            this.lblOldPass.Size = new System.Drawing.Size(51, 13);
            this.lblOldPass.TabIndex = 0;
            this.lblOldPass.Text = "Eski Şifre";
            // 
            // txtOldPass
            // 
            this.txtOldPass.Location = new System.Drawing.Point(124, 41);
            this.txtOldPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Size = new System.Drawing.Size(142, 20);
            this.txtOldPass.TabIndex = 1;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(124, 97);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(142, 20);
            this.txtNewPass.TabIndex = 3;
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Location = new System.Drawing.Point(9, 99);
            this.lblNewPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(52, 13);
            this.lblNewPass.TabIndex = 2;
            this.lblNewPass.Text = "Yeni Şifre";
            // 
            // txtNewPass2
            // 
            this.txtNewPass2.Location = new System.Drawing.Point(124, 151);
            this.txtNewPass2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNewPass2.Name = "txtNewPass2";
            this.txtNewPass2.Size = new System.Drawing.Size(142, 20);
            this.txtNewPass2.TabIndex = 5;
            // 
            // lblNewpass2
            // 
            this.lblNewpass2.AutoSize = true;
            this.lblNewpass2.Location = new System.Drawing.Point(9, 154);
            this.lblNewpass2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewpass2.Name = "lblNewpass2";
            this.lblNewpass2.Size = new System.Drawing.Size(86, 13);
            this.lblNewpass2.TabIndex = 4;
            this.lblNewpass2.Text = "Yeni Şifre Tekrar";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(190, 192);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 31);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Değiştir";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // FormPasswordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 266);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtNewPass2);
            this.Controls.Add(this.lblNewpass2);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.lblNewPass);
            this.Controls.Add(this.txtOldPass);
            this.Controls.Add(this.lblOldPass);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormPasswordChange";
            this.Text = "FormPasswordChange";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOldPass;
        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.TextBox txtNewPass2;
        private System.Windows.Forms.Label lblNewpass2;
        private System.Windows.Forms.Button btnUpdate;
    }
}