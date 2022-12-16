using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label6.Enabled = false;
            label7.Enabled = false;
            textBox3.Enabled = false;
            numericUpDown3.Enabled = false;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label6.Enabled = true;
            label7.Enabled = true;
            textBox3.Enabled = true;
            numericUpDown3.Enabled = true;
        }

        Zamestnanec zamestnanec;
        Vedouci vedouci;

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                zamestnanec = new Zamestnanec(textBox1.Text, textBox2.Text, dateTimePicker1.Value, (short)numericUpDown1.Value);
                zamestnanec.PocetDni();
            }
            else
            {
                vedouci = new Vedouci(textBox1.Text, textBox2.Text, dateTimePicker1.Value, (short)numericUpDown1.Value, (int)numericUpDown3.Value, textBox3.Text);
                vedouci.PocetDni();
            }
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                zamestnanec.OdpracujHodiny((short)numericUpDown2.Value);
                zamestnanec.VypoctiMzdu();
            }
            else
            {
                vedouci.OdpracujHodiny((short)numericUpDown2.Value);
                vedouci.VypoctiMzdu();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                odpoved.Text = zamestnanec.Vypis();
            }
            else
            {
                odpoved.Text = vedouci.Vypis();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
