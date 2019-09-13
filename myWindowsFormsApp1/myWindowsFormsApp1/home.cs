using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myWindowsFormsApp1
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void savebutton1_Click(object sender, EventArgs e)
        {
         
            string name= nameTextBox1.Text;
            string contact = contactTextBox2.Text;
            string address = addressTextBox3.Text;
            string item = itemcomboBox1.Text;
            string quantity = quantityTextBox5.Text;
            //MessageBox.Show("hello "+ name);
           
                if(itemcomboBox1.Text == "")
                {
                MessageBox.Show("Select an item");
                }
            
            richTextBox1.Text = ("Customer Info: "+ "\n " +name +"\n "
                +contact +"\n "+address +"\n "+item +"\n "+quantity) ;
        }

        
    }
}
