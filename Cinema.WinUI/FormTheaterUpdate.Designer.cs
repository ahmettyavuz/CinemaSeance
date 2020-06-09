namespace Cinema.WinUI
{
    partial class FormTheaterUpdate
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtTheaterName = new System.Windows.Forms.TextBox();
            this.lblTheater = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(278, 62);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // txtTheaterName
            // 
            this.txtTheaterName.Location = new System.Drawing.Point(76, 36);
            this.txtTheaterName.Name = "txtTheaterName";
            this.txtTheaterName.Size = new System.Drawing.Size(277, 20);
            this.txtTheaterName.TabIndex = 4;
            // 
            // lblTheater
            // 
            this.lblTheater.AutoSize = true;
            this.lblTheater.Location = new System.Drawing.Point(19, 39);
            this.lblTheater.Name = "lblTheater";
            this.lblTheater.Size = new System.Drawing.Size(52, 13);
            this.lblTheater.TabIndex = 3;
            this.lblTheater.Text = "Salon Adı";
            // 
            // FormTheaterUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 95);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtTheaterName);
            this.Controls.Add(this.lblTheater);
            this.Name = "FormTheaterUpdate";
            this.Text = "FormTheaterUpdate";
            this.Load += new System.EventHandler(this.FormTheaterUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtTheaterName;
        private System.Windows.Forms.Label lblTheater;
    }
}