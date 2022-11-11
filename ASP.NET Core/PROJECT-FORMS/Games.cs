using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Entities;
using BusinessLogicLayer;
using System.Collections;
using BusinessLogicLayer.InterfacesForGameManager;
using DataAccessLayer;
namespace PROJECT_FORMS
{
    public partial class Games : Form
    {
        private readonly IGetAllGames getAllGames;
      


        public Games()
        {
            InitializeComponent();
          
            getAllGames = new gameManager(new DBgame());
            UpdateDataSet();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
        public void UpdateDataSet()
        {
            dataGridView1.Rows.Clear();
            foreach (Game game in getAllGames.GetAllGames())
            {
                dataGridView1.Rows.Add(game.gameId, game.image, game.developer, game.genre, game.gameTime+" hours", game.releaseDate.ToString("dd/MM/yyyy"), game.description);
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
         
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            int id = (int)selectedRow.Cells[0].Value;

            Form3 newForm = new Form3(id);
            newForm.ShowDialog();




         

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            int id = (int)selectedRow.Cells[0].Value;

            Form3 newForm = new Form3(id);
            newForm.ShowDialog();

        }
    }
}
