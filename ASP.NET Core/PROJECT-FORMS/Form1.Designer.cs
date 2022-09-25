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
            this.Add = new System.Windows.Forms.Button();
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
            this.lbDescription = new System.Windows.Forms.Label();
            this.btnCreateGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pcBox
            // 
            this.pcBox.Location = new System.Drawing.Point(19, 12);
            this.pcBox.Name = "pcBox";
            this.pcBox.Size = new System.Drawing.Size(243, 215);
            this.pcBox.TabIndex = 0;
            this.pcBox.TabStop = false;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(89, 249);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(94, 29);
            this.Add.TabIndex = 2;
            this.Add.Text = "btnAdd";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // tbGameName
            // 
            this.tbGameName.Location = new System.Drawing.Point(582, 31);
            this.tbGameName.Name = "tbGameName";
            this.tbGameName.Size = new System.Drawing.Size(125, 27);
            this.tbGameName.TabIndex = 3;
            // 
            // lbGameName
            // 
            this.lbGameName.AutoSize = true;
            this.lbGameName.Location = new System.Drawing.Point(318, 31);
            this.lbGameName.Name = "lbGameName";
            this.lbGameName.Size = new System.Drawing.Size(126, 20);
            this.lbGameName.TabIndex = 4;
            this.lbGameName.Text = "Enter game name";
            // 
            // lbDeveloper
            // 
            this.lbDeveloper.AutoSize = true;
            this.lbDeveloper.Location = new System.Drawing.Point(318, 71);
            this.lbDeveloper.Name = "lbDeveloper";
            this.lbDeveloper.Size = new System.Drawing.Size(114, 20);
            this.lbDeveloper.TabIndex = 6;
            this.lbDeveloper.Text = "Enter developer";
            // 
            // tbDeveloper
            // 
            this.tbDeveloper.Location = new System.Drawing.Point(582, 71);
            this.tbDeveloper.Name = "tbDeveloper";
            this.tbDeveloper.Size = new System.Drawing.Size(125, 27);
            this.tbDeveloper.TabIndex = 5;
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Location = new System.Drawing.Point(318, 111);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(85, 20);
            this.lbGenre.TabIndex = 8;
            this.lbGenre.Text = "Enter genre";
            // 
            // tbGenre
            // 
            this.tbGenre.Location = new System.Drawing.Point(582, 111);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.Size = new System.Drawing.Size(125, 27);
            this.tbGenre.TabIndex = 7;
            // 
            // lbHours
            // 
            this.lbHours.AutoSize = true;
            this.lbHours.Location = new System.Drawing.Point(318, 151);
            this.lbHours.Name = "lbHours";
            this.lbHours.Size = new System.Drawing.Size(171, 20);
            this.lbHours.TabIndex = 10;
            this.lbHours.Text = "Enter Hours to complete";
            // 
            // tbHours
            // 
            this.tbHours.Location = new System.Drawing.Point(582, 144);
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
            this.lbReleaseDate.Location = new System.Drawing.Point(318, 187);
            this.lbReleaseDate.Name = "lbReleaseDate";
            this.lbReleaseDate.Size = new System.Drawing.Size(134, 20);
            this.lbReleaseDate.TabIndex = 12;
            this.lbReleaseDate.Text = "Enter Release Date";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(416, 233);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(372, 156);
            this.tbDescription.TabIndex = 13;
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(287, 236);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(123, 20);
            this.lbDescription.TabIndex = 14;
            this.lbDescription.Text = "Enter Description";
            // 
            // btnCreateGame
            // 
            this.btnCreateGame.Location = new System.Drawing.Point(349, 427);
            this.btnCreateGame.Name = "btnCreateGame";
            this.btnCreateGame.Size = new System.Drawing.Size(114, 29);
            this.btnCreateGame.TabIndex = 15;
            this.btnCreateGame.Text = "Create game";
            this.btnCreateGame.UseVisualStyleBackColor = true;
            this.btnCreateGame.Click += new System.EventHandler(this.btnCreateGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 615);
            this.Controls.Add(this.btnCreateGame);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.tbDescription);
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
            this.Controls.Add(this.Add);
            this.Controls.Add(this.pcBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcBox;
        private System.Windows.Forms.Button Add;
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
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Button btnCreateGame;
    }
}
