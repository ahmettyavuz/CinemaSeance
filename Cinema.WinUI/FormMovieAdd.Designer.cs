namespace CinemaSeans.UI
{
    partial class FormMovieAdd
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
            this.chb3D = new System.Windows.Forms.CheckBox();
            this.nudMovieTime = new System.Windows.Forms.NumericUpDown();
            this.cmbMovieType = new System.Windows.Forms.ComboBox();
            this.lblMovieYear = new System.Windows.Forms.Label();
            this.lblMovieTime = new System.Windows.Forms.Label();
            this.lblMovieType = new System.Windows.Forms.Label();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstCasts = new System.Windows.Forms.ListBox();
            this.lblCastAdd = new System.Windows.Forms.Label();
            this.lstDirectors = new System.Windows.Forms.ListBox();
            this.lblDirectorAdd = new System.Windows.Forms.Label();
            this.txtMovieYear = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudMovieTime)).BeginInit();
            this.SuspendLayout();
            // 
            // chb3D
            // 
            this.chb3D.AutoSize = true;
            this.chb3D.Location = new System.Drawing.Point(37, 277);
            this.chb3D.Margin = new System.Windows.Forms.Padding(2);
            this.chb3D.Name = "chb3D";
            this.chb3D.Size = new System.Drawing.Size(40, 17);
            this.chb3D.TabIndex = 18;
            this.chb3D.Text = "3D";
            this.chb3D.UseVisualStyleBackColor = true;
            // 
            // nudMovieTime
            // 
            this.nudMovieTime.Location = new System.Drawing.Point(112, 157);
            this.nudMovieTime.Margin = new System.Windows.Forms.Padding(2);
            this.nudMovieTime.Name = "nudMovieTime";
            this.nudMovieTime.Size = new System.Drawing.Size(157, 20);
            this.nudMovieTime.TabIndex = 16;
            // 
            // cmbMovieType
            // 
            this.cmbMovieType.FormattingEnabled = true;
            this.cmbMovieType.Location = new System.Drawing.Point(112, 98);
            this.cmbMovieType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMovieType.Name = "cmbMovieType";
            this.cmbMovieType.Size = new System.Drawing.Size(158, 21);
            this.cmbMovieType.TabIndex = 15;
            // 
            // lblMovieYear
            // 
            this.lblMovieYear.AutoSize = true;
            this.lblMovieYear.Location = new System.Drawing.Point(34, 219);
            this.lblMovieYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMovieYear.Name = "lblMovieYear";
            this.lblMovieYear.Size = new System.Drawing.Size(41, 13);
            this.lblMovieYear.TabIndex = 14;
            this.lblMovieYear.Text = "Film Yılı";
            // 
            // lblMovieTime
            // 
            this.lblMovieTime.AutoSize = true;
            this.lblMovieTime.Location = new System.Drawing.Point(34, 158);
            this.lblMovieTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMovieTime.Name = "lblMovieTime";
            this.lblMovieTime.Size = new System.Drawing.Size(57, 13);
            this.lblMovieTime.TabIndex = 13;
            this.lblMovieTime.Text = "Film Süresi";
            // 
            // lblMovieType
            // 
            this.lblMovieType.AutoSize = true;
            this.lblMovieType.Location = new System.Drawing.Point(34, 101);
            this.lblMovieType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMovieType.Name = "lblMovieType";
            this.lblMovieType.Size = new System.Drawing.Size(50, 13);
            this.lblMovieType.TabIndex = 12;
            this.lblMovieType.Text = "Film Türü";
            // 
            // txtMovieName
            // 
            this.txtMovieName.Location = new System.Drawing.Point(112, 38);
            this.txtMovieName.Margin = new System.Windows.Forms.Padding(2);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(158, 20);
            this.txtMovieName.TabIndex = 11;
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Location = new System.Drawing.Point(34, 41);
            this.lblMovieName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(43, 13);
            this.lblMovieName.TabIndex = 10;
            this.lblMovieName.Text = "Film Adı";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(700, 325);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(143, 30);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // lstCasts
            // 
            this.lstCasts.FormattingEnabled = true;
            this.lstCasts.Location = new System.Drawing.Point(316, 41);
            this.lstCasts.Margin = new System.Windows.Forms.Padding(2);
            this.lstCasts.MultiColumn = true;
            this.lstCasts.Name = "lstCasts";
            this.lstCasts.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstCasts.Size = new System.Drawing.Size(233, 199);
            this.lstCasts.TabIndex = 23;
            // 
            // lblCastAdd
            // 
            this.lblCastAdd.AutoSize = true;
            this.lblCastAdd.Location = new System.Drawing.Point(313, 18);
            this.lblCastAdd.Name = "lblCastAdd";
            this.lblCastAdd.Size = new System.Drawing.Size(94, 13);
            this.lblCastAdd.TabIndex = 24;
            this.lblCastAdd.Text = "Oyuncuları Ekleyin";
            // 
            // lstDirectors
            // 
            this.lstDirectors.FormattingEnabled = true;
            this.lstDirectors.Location = new System.Drawing.Point(610, 41);
            this.lstDirectors.Margin = new System.Windows.Forms.Padding(2);
            this.lstDirectors.MultiColumn = true;
            this.lstDirectors.Name = "lstDirectors";
            this.lstDirectors.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstDirectors.Size = new System.Drawing.Size(233, 199);
            this.lstDirectors.TabIndex = 23;
            // 
            // lblDirectorAdd
            // 
            this.lblDirectorAdd.AutoSize = true;
            this.lblDirectorAdd.Location = new System.Drawing.Point(607, 18);
            this.lblDirectorAdd.Name = "lblDirectorAdd";
            this.lblDirectorAdd.Size = new System.Drawing.Size(105, 13);
            this.lblDirectorAdd.TabIndex = 24;
            this.lblDirectorAdd.Text = "Yönetmenleri Ekleyin";
            // 
            // txtMovieYear
            // 
            this.txtMovieYear.Location = new System.Drawing.Point(112, 216);
            this.txtMovieYear.Margin = new System.Windows.Forms.Padding(2);
            this.txtMovieYear.Name = "txtMovieYear";
            this.txtMovieYear.Size = new System.Drawing.Size(158, 20);
            this.txtMovieYear.TabIndex = 11;
            // 
            // FormMovieAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 381);
            this.Controls.Add(this.lblDirectorAdd);
            this.Controls.Add(this.lblCastAdd);
            this.Controls.Add(this.lstDirectors);
            this.Controls.Add(this.lstCasts);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.chb3D);
            this.Controls.Add(this.nudMovieTime);
            this.Controls.Add(this.cmbMovieType);
            this.Controls.Add(this.lblMovieYear);
            this.Controls.Add(this.lblMovieTime);
            this.Controls.Add(this.lblMovieType);
            this.Controls.Add(this.txtMovieYear);
            this.Controls.Add(this.txtMovieName);
            this.Controls.Add(this.lblMovieName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMovieAdd";
            this.Text = "FormMovieAdd";
            this.Load += new System.EventHandler(this.FormMovieAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMovieTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chb3D;
        private System.Windows.Forms.NumericUpDown nudMovieTime;
        private System.Windows.Forms.ComboBox cmbMovieType;
        private System.Windows.Forms.Label lblMovieYear;
        private System.Windows.Forms.Label lblMovieTime;
        private System.Windows.Forms.Label lblMovieType;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstCasts;
        private System.Windows.Forms.Label lblCastAdd;
        private System.Windows.Forms.ListBox lstDirectors;
        private System.Windows.Forms.Label lblDirectorAdd;
        private System.Windows.Forms.TextBox txtMovieYear;
    }
}