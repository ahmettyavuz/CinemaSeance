namespace CinemaSeans.UI
{
    partial class FormSeansUpdate
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblfinishhourminute = new System.Windows.Forms.Label();
            this.lblstarthourminute = new System.Windows.Forms.Label();
            this.cmbStartMinute = new System.Windows.Forms.ComboBox();
            this.cmbFinishMinute = new System.Windows.Forms.ComboBox();
            this.cmbFinishHour = new System.Windows.Forms.ComboBox();
            this.cmbStartHour = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(296, 130);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 34);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Değiştir";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Bitiş Saati";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Başlangıç Saati";
            // 
            // lblfinishhourminute
            // 
            this.lblfinishhourminute.AutoSize = true;
            this.lblfinishhourminute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblfinishhourminute.Location = new System.Drawing.Point(265, 82);
            this.lblfinishhourminute.Name = "lblfinishhourminute";
            this.lblfinishhourminute.Size = new System.Drawing.Size(19, 25);
            this.lblfinishhourminute.TabIndex = 36;
            this.lblfinishhourminute.Text = ":";
            // 
            // lblstarthourminute
            // 
            this.lblstarthourminute.AutoSize = true;
            this.lblstarthourminute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblstarthourminute.Location = new System.Drawing.Point(265, 32);
            this.lblstarthourminute.Name = "lblstarthourminute";
            this.lblstarthourminute.Size = new System.Drawing.Size(19, 25);
            this.lblstarthourminute.TabIndex = 35;
            this.lblstarthourminute.Text = ":";
            // 
            // cmbStartMinute
            // 
            this.cmbStartMinute.FormattingEnabled = true;
            this.cmbStartMinute.Items.AddRange(new object[] {
            "00",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55"});
            this.cmbStartMinute.Location = new System.Drawing.Point(300, 32);
            this.cmbStartMinute.Name = "cmbStartMinute";
            this.cmbStartMinute.Size = new System.Drawing.Size(95, 24);
            this.cmbStartMinute.TabIndex = 34;
            // 
            // cmbFinishMinute
            // 
            this.cmbFinishMinute.FormattingEnabled = true;
            this.cmbFinishMinute.Items.AddRange(new object[] {
            "00",
            "05",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55"});
            this.cmbFinishMinute.Location = new System.Drawing.Point(300, 83);
            this.cmbFinishMinute.Name = "cmbFinishMinute";
            this.cmbFinishMinute.Size = new System.Drawing.Size(95, 24);
            this.cmbFinishMinute.TabIndex = 33;
            // 
            // cmbFinishHour
            // 
            this.cmbFinishHour.FormattingEnabled = true;
            this.cmbFinishHour.Items.AddRange(new object[] {
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "00",
            "1",
            "2",
            "3"});
            this.cmbFinishHour.Location = new System.Drawing.Point(157, 82);
            this.cmbFinishHour.Name = "cmbFinishHour";
            this.cmbFinishHour.Size = new System.Drawing.Size(93, 24);
            this.cmbFinishHour.TabIndex = 32;
            // 
            // cmbStartHour
            // 
            this.cmbStartHour.FormattingEnabled = true;
            this.cmbStartHour.Items.AddRange(new object[] {
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "00",
            "1",
            "2",
            "3"});
            this.cmbStartHour.Location = new System.Drawing.Point(157, 32);
            this.cmbStartHour.Name = "cmbStartHour";
            this.cmbStartHour.Size = new System.Drawing.Size(93, 24);
            this.cmbStartHour.TabIndex = 31;
            // 
            // FormSeansUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 199);
            this.Controls.Add(this.lblfinishhourminute);
            this.Controls.Add(this.lblstarthourminute);
            this.Controls.Add(this.cmbStartMinute);
            this.Controls.Add(this.cmbFinishMinute);
            this.Controls.Add(this.cmbFinishHour);
            this.Controls.Add(this.cmbStartHour);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormSeansUpdate";
            this.Text = "Seans Güncelleme";
            this.Load += new System.EventHandler(this.FormSeansUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblfinishhourminute;
        private System.Windows.Forms.Label lblstarthourminute;
        private System.Windows.Forms.ComboBox cmbStartMinute;
        private System.Windows.Forms.ComboBox cmbFinishMinute;
        private System.Windows.Forms.ComboBox cmbFinishHour;
        private System.Windows.Forms.ComboBox cmbStartHour;
    }
}