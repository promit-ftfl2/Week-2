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
using CSVLib;

namespace CsvDllApp
{
    public partial class StudentNameKeepUI : Form
    {
        public StudentNameKeepUI()
        {
            InitializeComponent();
        }

        private string filelocation = @"E:\studentrecord.csv";
        private void saveButton_Click(object sender, EventArgs e)
        {
            int isvalid = 1;
            if (File.Exists(filelocation))
            {
                FileStream aStream = new FileStream(filelocation, FileMode.Open);
                CsvFileReader aReader = new CsvFileReader(aStream);
                List<string> aStudentRec = new List<string>();

                while (aReader.ReadRow(aStudentRec))
                {
                    string regNo = aStudentRec[0];
                    if (regNo == regTextBox1.Text)
                    {
                        isvalid = 0;

                        break;
                    }
                }
                aStream.Close();
            }
            if (isvalid == 0)
            {
                MessageBox.Show("Warning,Duplicate reg.no");
            }
            else if (isvalid == 1)
            {
                
                    FileStream aFileStream = new FileStream(filelocation, FileMode.Append);
                    CsvFileWriter aWriter = new CsvFileWriter(aFileStream);
                    List<string> aStudentrec = new List<string>();

                    aStudentrec.Add(regTextBox1.Text);
                    aStudentrec.Add(nameTextBox2.Text);

                    aWriter.WriteRow(aStudentrec);
                    MessageBox.Show("A student has been added");
                    aFileStream.Close();
                

            }


        }

        private void showButton_Click(object sender, EventArgs e)
        {
            FileStream aStream = new FileStream(filelocation, FileMode.Open);
            CsvFileReader aReader = new CsvFileReader(aStream);
            List<string> aStudentRec = new List<string>();
            showListBox1.Items.Clear();
            while (aReader.ReadRow(aStudentRec))
            {
                string regNo = aStudentRec[0];
                string name = aStudentRec[1];
                showListBox1.Items.Add(regNo + " " + name);
            }
            aStream.Close();

        }
    }
}
