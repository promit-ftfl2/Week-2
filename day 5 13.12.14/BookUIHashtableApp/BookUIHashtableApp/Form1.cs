using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookUIHashtableApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Hashtable bookInfo=new Hashtable();

        private void addbutton1_Click(object sender, EventArgs e)
        {
            if (bookInfo.ContainsKey(isbntextBox1.Text) == true)
            {
                MessageBox.Show("Already added ISBN");
            }
            else
            {




                bookInfo.Add(isbntextBox1.Text, detailstextBox1.Text);
                MessageBox.Show("Information has been added");
            }
        }

        private void findbutton2_Click(object sender, EventArgs e)
        {
            if (bookInfo.ContainsKey(isbntextBox2.Text))
            {
                string bookDetails = (string) bookInfo[isbntextBox2.Text];
                detailstextBox2.Text = bookDetails;
            }
            else
            {
                MessageBox.Show("There is no nobook with your given ISBN");
            }

        }
    }
}
