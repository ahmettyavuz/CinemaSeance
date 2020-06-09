namespace Cinema.WinUI
{
    partial class FormSessionAdd
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
            this.lblSessionAdd = new System.Windows.Forms.Label();
            this.cmbMovie = new System.Windows.Forms.ComboBox();
            this.cmbSeance = new System.Windows.Forms.ComboBox();
            this.cmbTheater = new System.Windows.Forms.ComboBox();
            this.lblMovie = new System.Windows.Forms.Label();
            this.lblTheater = new System.Windows.Forms.Label();
            this.lblSeance = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtpShowDate = new System.Windows.Forms.DateTimePicker();
            this.lblShowDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSessionAdd
            // 
            this.lblSessionAdd.AutoSize = true;
            this.lblSessionAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSessionAdd.Location = new System.Drawing.Point(105, 19);
            this.lblSessionAdd.Name = "lblSessionAdd";
            this.lblSessionAdd.Size = new System.Drawing.Size(157, 29);
            this.lblSessionAdd.TabIndex = 0;
            this.lblSessionAdd.Text = "Oturum Ekle";
            // 
            // cmbMovie
            // 
            this.cmbMovie.FormattingEnabled = true;
            this.cmbMovie.Location = new System.Drawing.Point(85, 91);
            this.cmbMovie.Name = "cmbMovie";
            this.cmbMovie.Size = new System.Drawing.Size(209, 24);
            this.cmbMovie.TabIndex = 1;
            // 
            // cmbSeance
            // 
            this.cmbSeance.FormattingEnabled = true;
            this.cmbSeance.Location = new System.Drawing.Point(85, 221);
            this.cmbSeance.Name = "cmbSeance";
            this.cmbSeance.Size = new System.Drawing.Size(209, 24);
            this.cmbSeance.TabIndex = 2;
            // 
            // cmbTheater
            // 
            this.cmbTheater.FormattingEnabled = true;
            this.cmbTheater.Location = new System.Drawing.Point(85, 155);
            this.cmbTheater.Name = "cmbTheater";
            this.cmbTheater.Size = new System.Drawing.Size(209, 24);
            this.cmbTheater.TabIndex = 3;
            // 
            // lblMovie
            // 
            this.lblMovie.AutoSize = true;
            this.lblMovie.Location = new System.Drawing.Point(22, 91);
            this.lblMovie.Name = "lblMovie";
            this.lblMovie.Size = new System.Drawing.Size(37, 17);
            this.lblMovie.TabIndex = 4;
            this.lblMovie.Text = "Film:";
            // 
            // lblTheater
            // 
            this.lblTheater.AutoSize = true;
            this.lblTheater.Location = new System.Drawing.Point(15, 158);
            this.lblTheater.Name = "lblTheater";
            this.lblTheater.Size = new System.Drawing.Size(48, 17);
            this.lblTheater.TabIndex = 5;
            this.lblTheater.Text = "Salon:";
            // 
            // lblSeance
            // 
            this.lblSeance.AutoSize = true;
            this.lblSeance.Location = new System.Drawing.Point(11, 221);
            this.lblSeance.Name = "lblSeance";
            this.lblSeance.Size = new System.Drawing.Size(52, 17);
            this.lblSeance.TabIndex = 6;
            this.lblSeance.Text = "Seans:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(219, 318);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // dtpShowDate
            // 
            this.dtpShowDate.Location = new System.Drawing.Point(85, 281);
            this.dtpShowDate.Name = "dtpShowDate";
            this.dtpShowDate.Size = new System.Drawing.Size(209, 22);
            this.dtpShowDate.TabIndex = 8;
            // 
            // lblShowDate
            // 
            this.lblShowDate.AutoSize = true;
            this.lblShowDate.Location = new System.Drawing.Point(11, 281);
            this.lblShowDate.Name = "lblShowDate";
            this.lblShowDate.Size = new System.Drawing.Size(45, 17);
            this.lblShowDate.TabIndex = 9;
            this.lblShowDate.Text = "Tarih:";
            // 
            // FormSessionAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 393);
            this.Controls.Add(this.lblShowDate);
            this.Controls.Add(this.dtpShowDate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblSeance);
            this.Controls.Add(this.lblTheater);
            this.Controls.Add(this.lblMovie);
            this.Controls.Add(this.cmbTheater);
            this.Controls.Add(this.cmbSeance);
            this.Controls.Add(this.cmbMovie);
            this.Controls.Add(this.lblSessionAdd);
            this.Name = "FormSessionAdd";
            this.Text = "Oturum Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSessionAdd;
        private System.Windows.Forms.ComboBox cmbMovie;
        private System.Windows.Forms.ComboBox cmbSeance;
        private System.Windows.Forms.ComboBox cmbTheater;
        private System.Windows.Forms.Label lblMovie;
        private System.Windows.Forms.Label lblTheater;
        private System.Windows.Forms.Label lblSeance;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtpShowDate;
        private System.Windows.Forms.Label lblShowDate;
    }
}