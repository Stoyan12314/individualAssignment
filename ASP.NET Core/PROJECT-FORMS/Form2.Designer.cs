namespace PROJECT_FORMS
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.lbInfo = new System.Windows.Forms.ListBox();
            this.gameManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.game_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.game_image = new System.Windows.Forms.DataGridViewImageColumn();
            this.developer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gameManagerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbInfo
            // 
            this.lbInfo.FormattingEnabled = true;
            this.lbInfo.ItemHeight = 20;
            this.lbInfo.Location = new System.Drawing.Point(50, 18);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(696, 364);
            this.lbInfo.TabIndex = 0;
            // 
            // gameManagerBindingSource
            // 
            this.gameManagerBindingSource.DataSource = typeof(BusinessLogicLayer.gameManager);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.game_id,
            this.game_image,
            this.developer,
            this.genre,
            this.gameTime,
            this.releaseDate,
            this.avgScore,
            this.description});
            this.dataGridView1.Location = new System.Drawing.Point(50, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 60;
            this.dataGridView1.Size = new System.Drawing.Size(959, 364);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // game_id
            // 
            this.game_id.HeaderText = "game Id";
            this.game_id.MinimumWidth = 6;
            this.game_id.Name = "game_id";
            this.game_id.ReadOnly = true;
            this.game_id.Width = 55;
            // 
            // game_image
            // 
            this.game_image.FillWeight = 160F;
            this.game_image.HeaderText = "game image";
            this.game_image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.game_image.MinimumWidth = 6;
            this.game_image.Name = "game_image";
            this.game_image.ReadOnly = true;
            this.game_image.Width = 101;
            // 
            // developer
            // 
            this.developer.HeaderText = "developer";
            this.developer.MinimumWidth = 6;
            this.developer.Name = "developer";
            this.developer.ReadOnly = true;
            this.developer.Width = 125;
            // 
            // genre
            // 
            this.genre.HeaderText = "genre";
            this.genre.MinimumWidth = 6;
            this.genre.Name = "genre";
            this.genre.ReadOnly = true;
            this.genre.Width = 125;
            // 
            // gameTime
            // 
            this.gameTime.HeaderText = "time to complete";
            this.gameTime.MinimumWidth = 6;
            this.gameTime.Name = "gameTime";
            this.gameTime.ReadOnly = true;
            this.gameTime.Width = 125;
            // 
            // releaseDate
            // 
            this.releaseDate.HeaderText = "release date ";
            this.releaseDate.MinimumWidth = 6;
            this.releaseDate.Name = "releaseDate";
            this.releaseDate.ReadOnly = true;
            this.releaseDate.Width = 125;
            // 
            // avgScore
            // 
            this.avgScore.HeaderText = "avg score";
            this.avgScore.MinimumWidth = 6;
            this.avgScore.Name = "avgScore";
            this.avgScore.ReadOnly = true;
            this.avgScore.Width = 125;
            // 
            // description
            // 
            this.description.HeaderText = "description";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 125;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbInfo);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gameManagerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbInfo;
        private System.Windows.Forms.BindingSource gameManagerBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn game_id;
        private System.Windows.Forms.DataGridViewImageColumn game_image;
        private System.Windows.Forms.DataGridViewTextBoxColumn developer;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
    }
}