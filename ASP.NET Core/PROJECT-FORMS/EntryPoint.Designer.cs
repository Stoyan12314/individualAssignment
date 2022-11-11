namespace PROJECT_FORMS
{
    partial class EntryPoint
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
            this.btnGames = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGames
            // 
            this.btnGames.Location = new System.Drawing.Point(91, 60);
            this.btnGames.Name = "btnGames";
            this.btnGames.Size = new System.Drawing.Size(111, 43);
            this.btnGames.TabIndex = 0;
            this.btnGames.Text = "Games";
            this.btnGames.UseVisualStyleBackColor = true;
            this.btnGames.Click += new System.EventHandler(this.btnGames_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(91, 131);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(111, 50);
            this.btnUsers.TabIndex = 1;
            this.btnUsers.Text = "Users/Reviews";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(91, 204);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 44);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // EntryPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 314);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnGames);
            this.Name = "EntryPoint";
            this.Text = "EntryPoint";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGames;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnExit;
    }
}