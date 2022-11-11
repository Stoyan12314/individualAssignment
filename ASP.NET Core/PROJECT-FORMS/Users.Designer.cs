namespace PROJECT_FORMS
{
    partial class Users
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creation_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.badges = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_written_rev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user_id,
            this.user_name,
            this.password,
            this.creation_date,
            this.badges,
            this.num_written_rev});
            this.dataGridView.Location = new System.Drawing.Point(118, 37);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 60;
            this.dataGridView.Size = new System.Drawing.Size(732, 364);
            this.dataGridView.TabIndex = 4;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // user_id
            // 
            this.user_id.HeaderText = "user Id";
            this.user_id.MinimumWidth = 6;
            this.user_id.Name = "user_id";
            this.user_id.ReadOnly = true;
            this.user_id.Width = 55;
            // 
            // user_name
            // 
            this.user_name.HeaderText = "user name";
            this.user_name.MinimumWidth = 6;
            this.user_name.Name = "user_name";
            this.user_name.ReadOnly = true;
            this.user_name.Width = 125;
            // 
            // password
            // 
            this.password.HeaderText = "password";
            this.password.MinimumWidth = 6;
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Width = 125;
            // 
            // creation_date
            // 
            this.creation_date.HeaderText = "creation date";
            this.creation_date.MinimumWidth = 6;
            this.creation_date.Name = "creation_date";
            this.creation_date.ReadOnly = true;
            this.creation_date.Width = 125;
            // 
            // badges
            // 
            this.badges.HeaderText = "badges";
            this.badges.MinimumWidth = 6;
            this.badges.Name = "badges";
            this.badges.ReadOnly = true;
            this.badges.Width = 125;
            // 
            // num_written_rev
            // 
            this.num_written_rev.HeaderText = "number written reviews";
            this.num_written_rev.MinimumWidth = 6;
            this.num_written_rev.Name = "num_written_rev";
            this.num_written_rev.ReadOnly = true;
            this.num_written_rev.Width = 125;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 482);
            this.Controls.Add(this.dataGridView);
            this.Name = "Users";
            this.Text = "EditUsers";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn creation_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn badges;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_written_rev;
    }
}