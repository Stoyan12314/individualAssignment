namespace PROJECT_FORMS
{
    partial class Form3
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
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.gbAddImage = new System.Windows.Forms.GroupBox();
            this.pcBox = new System.Windows.Forms.PictureBox();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.lbReleaseDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbHours = new System.Windows.Forms.Label();
            this.tbHours = new System.Windows.Forms.TextBox();
            this.lbGenre = new System.Windows.Forms.Label();
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.lbDeveloper = new System.Windows.Forms.Label();
            this.tbDeveloper = new System.Windows.Forms.TextBox();
            this.lbGameName = new System.Windows.Forms.Label();
            this.tbGameName = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbAddImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(185, 508);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(114, 29);
            this.btnSaveChanges.TabIndex = 29;
            this.btnSaveChanges.Text = "Save changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbDescription);
            this.groupBox1.Location = new System.Drawing.Point(414, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 291);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Description";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(21, 56);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(419, 190);
            this.tbDescription.TabIndex = 13;
            // 
            // gbAddImage
            // 
            this.gbAddImage.Controls.Add(this.pcBox);
            this.gbAddImage.Controls.Add(this.btnAddImage);
            this.gbAddImage.Location = new System.Drawing.Point(90, 55);
            this.gbAddImage.Name = "gbAddImage";
            this.gbAddImage.Size = new System.Drawing.Size(299, 291);
            this.gbAddImage.TabIndex = 31;
            this.gbAddImage.TabStop = false;
            this.gbAddImage.Text = "Add image";
            // 
            // pcBox
            // 
            this.pcBox.Location = new System.Drawing.Point(31, 26);
            this.pcBox.Name = "pcBox";
            this.pcBox.Size = new System.Drawing.Size(243, 215);
            this.pcBox.TabIndex = 0;
            this.pcBox.TabStop = false;
            // 
            // btnAddImage
            // 
            this.btnAddImage.Location = new System.Drawing.Point(79, 247);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(150, 29);
            this.btnAddImage.TabIndex = 2;
            this.btnAddImage.Text = "Select image";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // lbReleaseDate
            // 
            this.lbReleaseDate.AutoSize = true;
            this.lbReleaseDate.Location = new System.Drawing.Point(414, 232);
            this.lbReleaseDate.Name = "lbReleaseDate";
            this.lbReleaseDate.Size = new System.Drawing.Size(134, 20);
            this.lbReleaseDate.TabIndex = 28;
            this.lbReleaseDate.Text = "Enter Release Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(593, 225);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // lbHours
            // 
            this.lbHours.AutoSize = true;
            this.lbHours.Location = new System.Drawing.Point(414, 179);
            this.lbHours.Name = "lbHours";
            this.lbHours.Size = new System.Drawing.Size(171, 20);
            this.lbHours.TabIndex = 26;
            this.lbHours.Text = "Enter Hours to complete";
            // 
            // tbHours
            // 
            this.tbHours.Location = new System.Drawing.Point(678, 172);
            this.tbHours.Name = "tbHours";
            this.tbHours.Size = new System.Drawing.Size(125, 27);
            this.tbHours.TabIndex = 25;
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Location = new System.Drawing.Point(414, 146);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(85, 20);
            this.lbGenre.TabIndex = 24;
            this.lbGenre.Text = "Enter genre";
            // 
            // tbGenre
            // 
            this.tbGenre.Location = new System.Drawing.Point(678, 139);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.Size = new System.Drawing.Size(125, 27);
            this.tbGenre.TabIndex = 23;
            // 
            // lbDeveloper
            // 
            this.lbDeveloper.AutoSize = true;
            this.lbDeveloper.Location = new System.Drawing.Point(413, 106);
            this.lbDeveloper.Name = "lbDeveloper";
            this.lbDeveloper.Size = new System.Drawing.Size(114, 20);
            this.lbDeveloper.TabIndex = 22;
            this.lbDeveloper.Text = "Enter developer";
            // 
            // tbDeveloper
            // 
            this.tbDeveloper.Location = new System.Drawing.Point(678, 99);
            this.tbDeveloper.Name = "tbDeveloper";
            this.tbDeveloper.Size = new System.Drawing.Size(125, 27);
            this.tbDeveloper.TabIndex = 21;
            // 
            // lbGameName
            // 
            this.lbGameName.AutoSize = true;
            this.lbGameName.Location = new System.Drawing.Point(413, 66);
            this.lbGameName.Name = "lbGameName";
            this.lbGameName.Size = new System.Drawing.Size(126, 20);
            this.lbGameName.TabIndex = 20;
            this.lbGameName.Text = "Enter game name";
            // 
            // tbGameName
            // 
            this.tbGameName.Location = new System.Drawing.Point(678, 59);
            this.tbGameName.Name = "tbGameName";
            this.tbGameName.Size = new System.Drawing.Size(125, 27);
            this.tbGameName.TabIndex = 19;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(185, 554);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 29);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 604);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbAddImage);
            this.Controls.Add(this.lbReleaseDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbHours);
            this.Controls.Add(this.tbHours);
            this.Controls.Add(this.lbGenre);
            this.Controls.Add(this.tbGenre);
            this.Controls.Add(this.lbDeveloper);
            this.Controls.Add(this.tbDeveloper);
            this.Controls.Add(this.lbGameName);
            this.Controls.Add(this.tbGameName);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbAddImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.GroupBox gbAddImage;
        private System.Windows.Forms.PictureBox pcBox;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.Label lbReleaseDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbHours;
        private System.Windows.Forms.TextBox tbHours;
        private System.Windows.Forms.Label lbGenre;
        private System.Windows.Forms.TextBox tbGenre;
        private System.Windows.Forms.Label lbDeveloper;
        private System.Windows.Forms.TextBox tbDeveloper;
        private System.Windows.Forms.Label lbGameName;
        private System.Windows.Forms.TextBox tbGameName;
        private System.Windows.Forms.Button btnDelete;
    }
}