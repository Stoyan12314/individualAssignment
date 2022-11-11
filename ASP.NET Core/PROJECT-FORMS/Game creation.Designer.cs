namespace PROJECT_FORMS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pcBox = new System.Windows.Forms.PictureBox();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.tbGameName = new System.Windows.Forms.TextBox();
            this.lbGameName = new System.Windows.Forms.Label();
            this.lbDeveloper = new System.Windows.Forms.Label();
            this.tbDeveloper = new System.Windows.Forms.TextBox();
            this.lbGenre = new System.Windows.Forms.Label();
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.lbHours = new System.Windows.Forms.Label();
            this.tbHours = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbReleaseDate = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.btnCreateGame = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbAddImage = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcBox)).BeginInit();
            this.gbAddImage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.btnAddImage.Click += new System.EventHandler(this.Add_Click);
            // 
            // tbGameName
            // 
            this.tbGameName.Location = new System.Drawing.Point(600, 16);
            this.tbGameName.Name = "tbGameName";
            this.tbGameName.Size = new System.Drawing.Size(125, 27);
            this.tbGameName.TabIndex = 3;
            // 
            // lbGameName
            // 
            this.lbGameName.AutoSize = true;
            this.lbGameName.Location = new System.Drawing.Point(335, 23);
            this.lbGameName.Name = "lbGameName";
            this.lbGameName.Size = new System.Drawing.Size(126, 20);
            this.lbGameName.TabIndex = 4;
            this.lbGameName.Text = "Enter game name";
            // 
            // lbDeveloper
            // 
            this.lbDeveloper.AutoSize = true;
            this.lbDeveloper.Location = new System.Drawing.Point(335, 63);
            this.lbDeveloper.Name = "lbDeveloper";
            this.lbDeveloper.Size = new System.Drawing.Size(114, 20);
            this.lbDeveloper.TabIndex = 6;
            this.lbDeveloper.Text = "Enter developer";
            // 
            // tbDeveloper
            // 
            this.tbDeveloper.Location = new System.Drawing.Point(600, 56);
            this.tbDeveloper.Name = "tbDeveloper";
            this.tbDeveloper.Size = new System.Drawing.Size(125, 27);
            this.tbDeveloper.TabIndex = 5;
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Location = new System.Drawing.Point(336, 103);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(85, 20);
            this.lbGenre.TabIndex = 8;
            this.lbGenre.Text = "Enter genre";
            // 
            // tbGenre
            // 
            this.tbGenre.Location = new System.Drawing.Point(600, 96);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.Size = new System.Drawing.Size(125, 27);
            this.tbGenre.TabIndex = 7;
            // 
            // lbHours
            // 
            this.lbHours.AutoSize = true;
            this.lbHours.Location = new System.Drawing.Point(336, 136);
            this.lbHours.Name = "lbHours";
            this.lbHours.Size = new System.Drawing.Size(171, 20);
            this.lbHours.TabIndex = 10;
            this.lbHours.Text = "Enter Hours to complete";
            // 
            // tbHours
            // 
            this.tbHours.Location = new System.Drawing.Point(600, 129);
            this.tbHours.Name = "tbHours";
            this.tbHours.Size = new System.Drawing.Size(125, 27);
            this.tbHours.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(515, 182);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // lbReleaseDate
            // 
            this.lbReleaseDate.AutoSize = true;
            this.lbReleaseDate.Location = new System.Drawing.Point(336, 189);
            this.lbReleaseDate.Name = "lbReleaseDate";
            this.lbReleaseDate.Size = new System.Drawing.Size(134, 20);
            this.lbReleaseDate.TabIndex = 12;
            this.lbReleaseDate.Text = "Enter Release Date";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(21, 56);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(419, 190);
            this.tbDescription.TabIndex = 13;
            // 
            // btnCreateGame
            // 
            this.btnCreateGame.Location = new System.Drawing.Point(43, 432);
            this.btnCreateGame.Name = "btnCreateGame";
            this.btnCreateGame.Size = new System.Drawing.Size(114, 29);
            this.btnCreateGame.TabIndex = 15;
            this.btnCreateGame.Text = "Create game";
            this.btnCreateGame.UseVisualStyleBackColor = true;
            this.btnCreateGame.Click += new System.EventHandler(this.btnCreateGame_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(172, 432);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 29);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete/Edit game";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbAddImage
            // 
            this.gbAddImage.Controls.Add(this.pcBox);
            this.gbAddImage.Controls.Add(this.btnAddImage);
            this.gbAddImage.Location = new System.Drawing.Point(12, 12);
            this.gbAddImage.Name = "gbAddImage";
            this.gbAddImage.Size = new System.Drawing.Size(299, 291);
            this.gbAddImage.TabIndex = 17;
            this.gbAddImage.TabStop = false;
            this.gbAddImage.Text = "Add image";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbDescription);
            this.groupBox1.Location = new System.Drawing.Point(336, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 291);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Description";
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(107, 468);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(114, 29);
            this.btnMainMenu.TabIndex = 19;
            this.btnMainMenu.Text = "Main menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 509);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreateGame);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcBox)).EndInit();
            this.gbAddImage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcBox;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.TextBox tbGameName;
        private System.Windows.Forms.Label lbGameName;
        private System.Windows.Forms.Label lbDeveloper;
        private System.Windows.Forms.TextBox tbDeveloper;
        private System.Windows.Forms.Label lbGenre;
        private System.Windows.Forms.TextBox tbGenre;
        private System.Windows.Forms.Label lbHours;
        private System.Windows.Forms.TextBox tbHours;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbReleaseDate;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Button btnCreateGame;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbAddImage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMainMenu;
    }
}
