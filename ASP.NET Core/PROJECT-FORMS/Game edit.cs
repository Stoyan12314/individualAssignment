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
using BusinessLogicLayer.InterfacesForGameManager;
namespace PROJECT_FORMS
{
    public partial class Form3 : Form
    {
        private IGetGameWith IGetGamesWith;
        private IUpdateGame IUpdateGame;
        private IDeleteGame IDeleteGame;

        int id = default;
        public Form3(int id)
        {
            InitializeComponent();
            IGetGamesWith = new gameManager(new DBgame());
            IUpdateGame = new gameManager(new DBgame());
            IDeleteGame = new gameManager(new DBgame());
            this.Text = "Game edit";
            this.id = id;
            LoadData();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
           
            Game game = UpdatedChanges();
            IUpdateGame.UpdateGame(game);
            this.Close();
        }
        public void LoadData()
        {
            Game game = IGetGamesWith.GetGameWith(id);
            MemoryStream stream = new MemoryStream(game.image);
            pcBox.Image = Image.FromStream(stream);
            tbGameName.Text = game.title;
            tbDeveloper.Text = game.developer;
            tbGenre.Text = game.genre;
            tbHours.Text = game.gameTime.ToString();
            dateTimePicker1.Value = game.releaseDate;
            tbDescription.Text = game.description;
        }
        public Game UpdatedChanges()
        {
            Byte[] image = (byte[])new ImageConverter().ConvertTo(pcBox.Image, typeof(Byte[]));
            Game game = new Game(id, tbDeveloper.Text, tbGenre.Text, Convert.ToInt32(tbHours.Text), dateTimePicker1.Value, tbGameName.Text, tbDescription.Text, image);
            return game;
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
            bool check  = IDeleteGame.DeleteGame(id);
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
