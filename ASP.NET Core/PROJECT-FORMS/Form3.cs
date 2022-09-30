using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Entities;
using BusinessLogicLayer;
using DataAccessLayer;
using System.IO;

namespace PROJECT_FORMS
{
    public partial class Form3 : Form
    {
        int id = default;
        gameManager gameManager = new gameManager();
        public Form3(int id)
        {
            InitializeComponent();
            this.Text = "Game edit";
            this.id = id;
            LoadData();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {

        }
        public void LoadData()
        {
            Game game = gameManager.GetGameWith(id);
            MemoryStream stream = new MemoryStream(game.image);
            pcBox.Image = Image.FromStream(stream);
            tbGameName.Text = game.title;
            tbDeveloper.Text = game.developer;
            tbGenre.Text = game.genre;
            tbHours.Text = game.gameTime.ToString();
            dateTimePicker1.Value = game.releaseDate;
            tbDescription.Text = game.description;
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog OD = new OpenFileDialog();
            OD.FileName = "";
            OD.Filter = "Supported Images|*.jpg;*.jpeg;*.png";
            if (OD.ShowDialog() == DialogResult.OK)
                pcBox.Load(OD.FileName);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool check  = gameManager.DeleteGame(id);
            if (check)
            {
                this.Close();  
            }
            else
            {
                throw new Exception("An Error has occurred!");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
