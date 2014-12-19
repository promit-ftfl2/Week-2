using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileReadWriteApp
{
    public partial class ReadWriteUIApp : Form
    {
        public ReadWriteUIApp()
        {
            InitializeComponent();
        }

        private void savebutton1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string location = @"D:\info.txt";
            FileStream aFileStream=new FileStream(location , FileMode.Append);
            StreamWriter aStreamWriter=new StreamWriter(aFileStream);
            aStreamWriter.Write(name);
            aStreamWriter.Close();
            aFileStream.Close();

        }

        private void showbutton2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string location = @"D:\info.txt";
            FileStream aFileStream = new FileStream(location, FileMode.Open);
            StreamReader aStreamReader = new StreamReader(aFileStream);
            nameListBox.Items.Clear();
            while (!aStreamReader.EndOfStream)
            {
                string aLine = aStreamReader.ReadLine();
                nameListBox.Items.Add(aLine);
            }
            aStreamReader.Close();
            aFileStream.Close();

        }
    }
}
