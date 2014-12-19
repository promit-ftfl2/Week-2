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

namespace EmployeeSalaryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string pathName = @"E:\EmployeeInfo.txt";
        private void button1(object sender, EventArgs e)
        {
            int id = int.Parse(idTextBox.Text);
            long salary = long.Parse(salaryTextBox.Text);
            File.AppendAllText(pathName, id + "," + nameTextBox.Text + "," + salary + "\r\n");
            MessageBox.Show("Employee information has been successfully saved.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists(pathName))
            {
                listBox1.Items.Clear();
                long sum = 0;
                foreach (string line in File.ReadAllLines(pathName))
                {
                    listBox1.Items.Add(line);
                    string[] str = line.Split(',');
                    sum += long.Parse(str[2]);
                }
                totalTextBox.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("The requested file does not exist.");
            }
        }

    }
}
