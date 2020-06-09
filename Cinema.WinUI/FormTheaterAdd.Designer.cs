namespace Cinema.WinUI
{
    partial class FormTheaterAdd
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
            this.lblTheater = new System.Windows.Forms.Label();
            this.txtTheaterName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTheater
            // 
            this.lblTheater.AutoSize = true;
            this.lblTheater.Location = new System.Drawing.Point(12, 37);
            this.lblTheater.Name = "lblTheater";
            this.lblTheater.Size = new System.Drawing.Size(52, 13);
            this.lblTheater.TabIndex = 0;
            this.lblTheater.Text = "Salon Adı";
            // 
            // txtTheaterName
            // 
            this.txtTheaterName.Location = new System.Drawing.Point(69, 34);
            this.txtTheaterName.Name = "txtTheaterName";
            this.txtTheaterName.Size = new System.Drawing.Size(277, 20);
            this.txtTheaterName.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(271, 60);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // FormTheaterAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 95);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTheaterName);
            this.Controls.Add(this.lblTheater);
            this.Name = "FormTheaterAdd";
            this.Text = "FormTheaterAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTheater;
        private System.Windows.Forms.TextBox txtTheaterName;
        private System.Windows.Forms.Button btnAdd;
    }
}