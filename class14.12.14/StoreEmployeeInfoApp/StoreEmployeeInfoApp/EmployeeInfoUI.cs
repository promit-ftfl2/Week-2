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

namespace StoreEmployeeInfoApp
{
    public partial class EmployeeInfoUI : Form
    {
        public EmployeeInfoUI()
        {
            InitializeComponent();
        }

        private string fileLocation = @"D:\employeeinfo.txt";
        private void saveButton_Click(object sender, EventArgs e)
        {
            
            FileStream aStream=new FileStream(fileLocation,FileMode.Append);
            StreamWriter aWriter=new StreamWriter(aStream);
           //List<string> infoList =new List<string>();
            string[] infoList=new string[3];
            //string name = nameTextBox.Text;
            //string id =IdTextBox.Text;
            //string salary = salryTextBox.Text;
           infoList[0] = nameTextBox.Text;
           infoList[1] = IdTextBox.Text;
           infoList[2] = salryTextBox.Text;
            aWriter.WriteLine(infoList[0]+","+infoList[1]+","+infoList[2]+"\n");
           // aWriter.Write(name + "," + id + "," + salary +"\n" );
            //aWriter.WriteLine();
            //File.AppendAllText(fileLocation, name + "," + id + "," + salary);
            aWriter.Close();
            aStream.Close();
            MessageBox.Show("A new entry added");
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            showListBox.Items.Clear();
            FileStream aStream=new FileStream(fileLocation,FileMode.Open);
            StreamReader aReader=new StreamReader(aStream);
            double sum=0;
            while (!aReader.EndOfStream)
            {
                string line=aReader.ReadLine();
                showListBox.Items.Add(line);
                
                string[] infoStrings = line.Split(',');
               sum = Convert.ToDouble(infoStrings[2]);
                sum += sum;
            }
            totalTextBox.Text = sum.ToString();
            aReader.Close();
            aStream.Close();
        }
    }
}
