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

namespace AdressBookCsvApp
{
    public partial class AddressBookUICsv : Form
    {
        public AddressBookUICsv()
        {
            InitializeComponent();
        }

        private string fileLocation = @"D:\addressbook.csv";

        private void saveButton1_Click(object sender, EventArgs e)
        {
            int isvalid = 1;
            if (File.Exists(fileLocation))
            {
                FileStream aStream = new FileStream(fileLocation, FileMode.Open);
                CsvFileReader aReader = new CsvFileReader(aStream);
                List<string> aPersonRec = new List<string>();

                while (aReader.ReadRow(aPersonRec))
                {


                    string perNo = aPersonRec[2];
                    if (perNo == personalcontactTextBox3.Text)
                    {
                        isvalid = 0;
                        break;
                    }


                }

                aStream.Close();

            }
            if (isvalid == 0)
            {
                MessageBox.Show("Warnig! Duplicate personal contact number");
            }
            else if (isvalid == 1)
            {
                FileStream aFileStream = new FileStream(fileLocation, FileMode.Append);
                CsvFileWriter aWriter = new CsvFileWriter(aFileStream);
                List<string> aPersonrec = new List<string>();

                aPersonrec.Add(nameTextBox1.Text);
                aPersonrec.Add(emailTextBox2.Text);
                aPersonrec.Add(personalcontactTextBox3.Text);
                aPersonrec.Add(homecontactTextBox4.Text);
                aPersonrec.Add(addressTextBox5.Text);

                aWriter.WriteRow(aPersonrec);
                MessageBox.Show("A new entry added");
                aFileStream.Close();
            }
        }

        private void showButton2_Click(object sender, EventArgs e)
        {
            FileStream aStream = new FileStream(fileLocation, FileMode.Open);
            CsvFileReader aReader = new CsvFileReader(aStream);
            List<string> aPersonRec = new List<string>();
            showListView1.Items.Clear();
            while (aReader.ReadRow(aPersonRec))
            {
                string name = aPersonRec[0];
                string mail = aPersonRec[1];
                string perno = aPersonRec[2];
                string homeno = aPersonRec[3];
                string address = aPersonRec[4];
                showListView1.Items.Add(name + "    " + mail + "   " + perno + "   " + homeno + "    " + address);
            }
            aStream.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string unknown = searchComboBox1.Text;

            FileStream aStream = new FileStream(fileLocation, FileMode.Open);
            CsvFileReader aReader = new CsvFileReader(aStream);
            List<string> aPersonRec = new List<string>();
            showListView1.Items.Clear();
            
            if (unknown == "Name")
            {

                while (aReader.ReadRow(aPersonRec))
                {
                    bool isvalid = false;
                    foreach (char c in searchTextBox6.Text)
                    {
                        if (aPersonRec[0].ToLower().Contains(c.ToString().ToLower()))
                        {
                            isvalid = true;
                            break;
                        }

                    }


                        if (isvalid)
                        {
                            showListView1.Items.Add(aPersonRec[0] + "   " + aPersonRec[1] + "   " + aPersonRec[2] +
                                                    "   " +
                                                    aPersonRec[3] + "   " + aPersonRec[4]);
                        }
                    
                }
                aStream.Close();
            }
            if (unknown == "Email")
            {
               
                while (aReader.ReadRow(aPersonRec))
                {
                    bool isvalid = false;
                    foreach (char c in searchTextBox6.Text)
                    {
                        if (aPersonRec[1].ToLower().Contains(c.ToString().ToLower()))
                        {
                            isvalid = true;
                            break;
                        }
                    }
                    if (isvalid == true)
                    {
                        showListView1.Items.Add(aPersonRec[0] + "  " + aPersonRec[1] + "  " + aPersonRec[2] + "  " +
                                                aPersonRec[3] + "  " + aPersonRec[4]);
                    }
                }
                aStream.Close();
            }
            if (unknown == "Personal Contact No")
            {
                bool isvalid = false;
                while (aReader.ReadRow(aPersonRec))
                {
                    

                    if (aPersonRec[2] == searchTextBox6.Text)
                    {
                        isvalid = true;
                        break;
                    }

                }
                if (isvalid == true)
                    {
                        showListView1.Items.Add(aPersonRec[0] + "  " + aPersonRec[1] + "  " + aPersonRec[2] + "  " +
                                                aPersonRec[3] + "  " + aPersonRec[4]);
                    }
                
                aStream.Close();
            }


        }
    }
}
    
