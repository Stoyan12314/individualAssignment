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
using DataAccessLayer;
using BusinessLogicLayer;
namespace PROJECT_FORMS
{
    public partial class Form1 : Form
    {
        DBgame dbGame = new DBgame();
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            OpenFileDialog OD = new OpenFileDialog();
            OD.FileName = "";
            OD.Filter = "Supported Images|*.jpg;*.jpeg;*.png";
            if (OD.ShowDialog() == DialogResult.OK)
                pcBox.Load(OD.FileName);


            //SqlConnection con = new SqlConnection(connectionString);
            //con.Open();
            //SqlCommand command = con.CreateCommand();
            //var image = new ImageConverter().ConvertTo(pictureBox1.Image, typeof(Byte[]));
            //command.Parameters.AddWithValue("@image", image);
            //command.CommandText = "INSERT INTO ImageTable (image) VALUES(@image)";
            //if (command.ExecuteNonQuery() > 0)
            //    MessageBox.Show("Image was added!");
            //else
            //    MessageBox.Show("Image was not added!");
            //con.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
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
              bool c =  dbGame.AddGame(new Game(tbDeveloper.Text, tbGenre.Text, Convert.ToInt32(tbHours.Text), dateTimePicker1.Value.Date, tbGameName.Text, tbDescription.Text), image);
                if (c) 
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Bruh");
                }
            }
            catch (Exception)
            {

                throw;
            }
            //Tuple<Byte[]>
           
        }
    }
}
