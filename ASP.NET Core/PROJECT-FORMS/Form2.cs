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

namespace PROJECT_FORMS
{
    public partial class Form2 : Form
    {
        gameManager gameManager;


        public Form2(gameManager gameManager)
        {
            InitializeComponent();
            this.Text = "Game overview";
            this.gameManager = gameManager;
            UpdateDataSet();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
        public void UpdateDataSet()
        {
            dataGridView1.Rows.Clear();
            foreach (Game game in gameManager.GetAllGames())
            {
                dataGridView1.Rows.Add(game.gameId, game.image, game.developer, game.genre, game.gameTime+" hours", game.releaseDate.ToString("dd/MM/yyyy"), game.avgScore, game.description);
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




            //int id = (int)selectedRow.Cells[0].Value;
            //byte[] image = (byte[])selectedRow.Cells[1].Value;
            //string developer = (string)selectedRow.Cells[2].Value;
            //string genre = (string)selectedRow.Cells[3].Value;
            //int gameTime = (int)selectedRow.Cells[4].Value; 
            //DateTime releaseDate = (DateTime)selectedRow.Cells[5].Value;
            //double avgScore = (double)selectedRow.Cells[6].Value;   
            //string description = (string)selectedRow.Cells[7].Value;

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
