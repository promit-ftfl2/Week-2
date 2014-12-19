using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryUIApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private Dictionary<string, string> citizenInfo = new Dictionary<string, string>();


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool hasThisid = citizenInfo.ContainsKey(textBox3.Text);
            if (hasThisid)
            {
                string detailsInfo = citizenInfo[textBox3.Text];
                MessageBox.Show(detailsInfo);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            citizenInfo.Add(textBox1.Text,textBox2.Text);
            MessageBox.Show("Information has been added");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string allInfo="";
            foreach (KeyValuePair<string,string> pair in citizenInfo )
            {
                allInfo += pair.Key + " " + pair.Value + "\n";
            }
            MessageBox.Show(allInfo);
        }
    }
}
