using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projektowanie_wizualne_lab3
{
    
    public partial class Form2 : Form
    {
        Form1 form1;
        public static string publisher = "";
        public static string genre = "";
        public static string author = "";
        public static string date_of_publish = "";
        public static string title = "";
        
        public Form2(Form1 newform)
        {
            InitializeComponent();
            this.form1 = newform;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelNazwa_Click(object sender, EventArgs e)
        {

        }

        private void labelGatunek_Click(object sender, EventArgs e)
        {

        }

        private void labelAutor_Click(object sender, EventArgs e)
        {

        }

        private void labelData_Click(object sender, EventArgs e)
        {

        }

        private void labelTytul_Click(object sender, EventArgs e)
        {

        }

        private void labelAccept_Click(object sender, EventArgs e)
        {
            LoadedValues value = new LoadedValues();

            value.publisher = textBox1.Text;
            value.genre = textBox2.Text;
            value.author = textBox3.Text;
            value.date_of_publish = textBox4.Text;
            value.title = textBox5.Text;
            form1.AddLoadedRow(value.publisher, value.genre, value.author, value.date_of_publish, value.title);
        }

        private void labelReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
