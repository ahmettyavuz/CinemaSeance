namespace CinemaSeans.UI
{
    partial class FormSeansAdd
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
            this.lblstartTime = new System.Windows.Forms.Label();
            this.lblFinishTime = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblfinishhourminute = new System.Windows.Forms.Label();
            this.lblstarthourminute = new System.Windows.Forms.Label();
            this.cmbStartMinute = new System.Windows.Forms.ComboBox();
            this.cmbFinishMinute = new System.Windows.Forms.ComboBox();
            this.cmbFinishHour = new System.Windows.Forms.ComboBox();
            this.cmbStartHour = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(145, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seans";
            // 
            // lblstartTime
            // 
            this.lblstartTime.AutoSize = true;
            this.lblstartTime.Location = new System.Drawing.Point(12, 65);
            this.lblstartTime.Name = "lblstartTime";
            this.lblstartTime.Size = new System.Drawing.Size(105, 17);
            this.lblstartTime.TabIndex = 3;
            this.lblstartTime.Text = "Başlangıç Saati";
            // 
            // lblFinishTime
            // 
            this.lblFinishTime.AutoSize = true;
            this.lblFinishTime.Location = new System.Drawing.Point(12, 115);
            this.lblFinishTime.Name = "lblFinishTime";
            this.lblFinishTime.Size = new System.Drawing.Size(70, 17);
            this.lblFinishTime.TabIndex = 5;
            this.lblFinishTime.Text = "Bitiş Saati";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(288, 161);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 34);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblfinishhourminute
            // 
            this.lblfinishhourminute.AutoSize = true;
            this.lblfinishhourminute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblfinishhourminute.Location = new System.Drawing.Point(257, 107);
            this.lblfinishhourminute.Name = "lblfinishhourminute";
            this.lblfinishhourminute.Size = new System.Drawing.Size(19, 25);
            this.lblfinishhourminute.TabIndex = 21;
            this.lblfinishhourminute.Text = ":";
            // 
            // lblstarthourminute
            // 
            this.lblstarthourminute.AutoSize = true;
            this.lblstarthourminute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblstarthourminute.Location = new System.Drawing.Point(257, 57);
            this.lblstarthourminute.Name = "lblstarthourminute";
            this.lblstarthourminute.Size = new System.Drawing.Size(19, 25);
            this.lblstarthourminute.TabIndex = 20;
            this.lblstarthourminute.Text = ":";
            // 
            // cmbStartMinute
            // 
            this.cmbStartMinute.FormattingEnabled = true;
            this.cmbStartMinute.Items.AddRange(new object[] {
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
            this.cmbStartMinute.Location = new System.Drawing.Point(292, 57);
            this.cmbStartMinute.Name = "cmbStartMinute";
            this.cmbStartMinute.Size = new System.Drawing.Size(95, 24);
            this.cmbStartMinute.TabIndex = 19;
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
            this.cmbFinishMinute.Location = new System.Drawing.Point(292, 108);
            this.cmbFinishMinute.Name = "cmbFinishMinute";
            this.cmbFinishMinute.Size = new System.Drawing.Size(95, 24);
            this.cmbFinishMinute.TabIndex = 18;
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
            "01",
            "02",
            "03"});
            this.cmbFinishHour.Location = new System.Drawing.Point(149, 107);
            this.cmbFinishHour.Name = "cmbFinishHour";
            this.cmbFinishHour.Size = new System.Drawing.Size(93, 24);
            this.cmbFinishHour.TabIndex = 17;
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
            "01",
            "02",
            "03"});
            this.cmbStartHour.Location = new System.Drawing.Point(149, 57);
            this.cmbStartHour.Name = "cmbStartHour";
            this.cmbStartHour.Size = new System.Drawing.Size(93, 24);
            this.cmbStartHour.TabIndex = 16;
            // 
            // FormSeansAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 228);
            this.Controls.Add(this.lblfinishhourminute);
            this.Controls.Add(this.lblstarthourminute);
            this.Controls.Add(this.cmbStartMinute);
            this.Controls.Add(this.cmbFinishMinute);
            this.Controls.Add(this.cmbFinishHour);
            this.Controls.Add(this.cmbStartHour);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblFinishTime);
            this.Controls.Add(this.lblstartTime);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormSeansAdd";
            this.Text = "Seans Ekleme";
            this.Load += new System.EventHandler(this.FormSeansMovieAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblstartTime;
        private System.Windows.Forms.Label lblFinishTime;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblfinishhourminute;
        private System.Windows.Forms.Label lblstarthourminute;
        private System.Windows.Forms.ComboBox cmbStartMinute;
        private System.Windows.Forms.ComboBox cmbFinishMinute;
        private System.Windows.Forms.ComboBox cmbFinishHour;
        private System.Windows.Forms.ComboBox cmbStartHour;
    }
}