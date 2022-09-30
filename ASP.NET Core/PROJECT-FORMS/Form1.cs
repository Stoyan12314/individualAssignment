using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using BusinessLogicLayer;
using DataAccessLayer;
using Entities;
namespace PROJECT_FORMS
{
    public partial class Form1 : Form
    {
        gameManager gameManager;
        public Form1()
        {
            InitializeComponent();
            gameManager = new gameManager();            
            this.Text = "Game creation";
        }

        private void Add_Click(object sender, EventArgs e)
        {
            OpenFileDialog OD = new OpenFileDialog();
            OD.FileName = "";
            OD.Filter = "Supported Images|*.jpg;*.jpeg;*.png";
            if (OD.ShowDialog() == DialogResult.OK)
                pcBox.Load(OD.FileName);
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateGame_Click(object sender, EventArgs e)
        {
            try
            {
                
                Byte[] image = (byte[])new ImageConverter().ConvertTo(pcBox.Image, typeof(Byte[]));
                bool check = gameManager.AddGame(new Game(tbDeveloper.Text, tbGenre.Text, Convert.ToInt32(tbHours.Text), dateTimePicker1.Value.Date, tbGameName.Text, tbDescription.Text, image));
                if (check) 
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    throw new ArgumentException("An error has accured!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(gameManager);
            form.ShowDialog();
        }
    }
}
