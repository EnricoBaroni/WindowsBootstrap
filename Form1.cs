using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsBootstrap
{
    public partial class FormBootstrap : Form
    {
        public FormBootstrap()
        {
            InitializeComponent();
           // listBox1.SelectedIndex = 0;
            //comboBox1.SelectedIndex = 2;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormBootstrap_Load(object sender, EventArgs e)
        {

        }

        private void buttMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El pepe dice: " + textBoxMessage.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("El pepe dice: " + listBox1.Text);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == false)
            {
                MessageBox.Show("El pepe dice: " + radioButton1.Text);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false)
            {
                MessageBox.Show("El pepe dice: " + radioButton2.Text);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("El pepe dice: " + checkBox1.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("El pepe dice: " + comboBox1.Text);
        }
    }
}
