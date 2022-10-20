using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Shakha_Translate_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection bagla = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SHAKHAE\Downloads\dbSozluk.mdb");
        private void Form1_Load(object sender, EventArgs e)
        {
            bagla.Open();
            OleDbCommand komot = new OleDbCommand("Select Ingilis from sozluk", bagla);
            OleDbDataReader dr = komot.ExecuteReader();
            while(dr.Read())
            {
                listBox1.Items.Add(dr[0]).ToString();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //textBox2.Text = listBox1.SelectedItem.ToString();
        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string sd = textBox1.Text;
            bagla.Open();
            OleDbCommand komut = new OleDbCommand("select Ingilis from sozluk where Ingilis like'" +sd + "%'", bagla);
            OleDbDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                listBox1.Items.Add(dr[0]);
            }
            bagla.Close();
        }
    }         
}
