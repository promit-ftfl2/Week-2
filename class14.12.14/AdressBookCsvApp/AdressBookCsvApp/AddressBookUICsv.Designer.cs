namespace AdressBookCsvApp
{
    partial class AddressBookUICsv
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.emailTextBox2 = new System.Windows.Forms.TextBox();
            this.personalcontactTextBox3 = new System.Windows.Forms.TextBox();
            this.homecontactTextBox4 = new System.Windows.Forms.TextBox();
            this.addressTextBox5 = new System.Windows.Forms.TextBox();
            this.saveButton1 = new System.Windows.Forms.Button();
            this.showButton2 = new System.Windows.Forms.Button();
            this.searchComboBox1 = new System.Windows.Forms.ComboBox();
            this.searchTextBox6 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.showListView1 = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Personal Contact no";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Home Contact NO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Home Address";
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.Location = new System.Drawing.Point(179, 45);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.Size = new System.Drawing.Size(124, 20);
            this.nameTextBox1.TabIndex = 5;
            // 
            // emailTextBox2
            // 
            this.emailTextBox2.Location = new System.Drawing.Point(179, 93);
            this.emailTextBox2.Name = "emailTextBox2";
            this.emailTextBox2.Size = new System.Drawing.Size(124, 20);
            this.emailTextBox2.TabIndex = 6;
            // 
            // personalcontactTextBox3
            // 
            this.personalcontactTextBox3.Location = new System.Drawing.Point(178, 137);
            this.personalcontactTextBox3.Name = "personalcontactTextBox3";
            this.personalcontactTextBox3.Size = new System.Drawing.Size(124, 20);
            this.personalcontactTextBox3.TabIndex = 7;
            // 
            // homecontactTextBox4
            // 
            this.homecontactTextBox4.Location = new System.Drawing.Point(179, 177);
            this.homecontactTextBox4.Name = "homecontactTextBox4";
            this.homecontactTextBox4.Size = new System.Drawing.Size(124, 20);
            this.homecontactTextBox4.TabIndex = 8;
            // 
            // addressTextBox5
            // 
            this.addressTextBox5.Location = new System.Drawing.Point(179, 219);
            this.addressTextBox5.Multiline = true;
            this.addressTextBox5.Name = "addressTextBox5";
            this.addressTextBox5.Size = new System.Drawing.Size(124, 43);
            this.addressTextBox5.TabIndex = 9;
            // 
            // saveButton1
            // 
            this.saveButton1.Location = new System.Drawing.Point(124, 280);
            this.saveButton1.Name = "saveButton1";
            this.saveButton1.Size = new System.Drawing.Size(75, 23);
            this.saveButton1.TabIndex = 10;
            this.saveButton1.Text = "Save";
            this.saveButton1.UseVisualStyleBackColor = true;
            this.saveButton1.Click += new System.EventHandler(this.saveButton1_Click);
            // 
            // showButton2
            // 
            this.showButton2.Location = new System.Drawing.Point(251, 280);
            this.showButton2.Name = "showButton2";
            this.showButton2.Size = new System.Drawing.Size(75, 23);
            this.showButton2.TabIndex = 11;
            this.showButton2.Text = "Show All";
            this.showButton2.UseVisualStyleBackColor = true;
            this.showButton2.Click += new System.EventHandler(this.showButton2_Click);
            // 
            // searchComboBox1
            // 
            this.searchComboBox1.FormattingEnabled = true;
            this.searchComboBox1.Items.AddRange(new object[] {
            "Name",
            "Email",
            "Personal Contact No"});
            this.searchComboBox1.Location = new System.Drawing.Point(179, 412);
            this.searchComboBox1.Name = "searchComboBox1";
            this.searchComboBox1.Size = new System.Drawing.Size(121, 21);
            this.searchComboBox1.TabIndex = 13;
            // 
            // searchTextBox6
            // 
            this.searchTextBox6.Location = new System.Drawing.Point(179, 461);
            this.searchTextBox6.Name = "searchTextBox6";
            this.searchTextBox6.Size = new System.Drawing.Size(121, 20);
            this.searchTextBox6.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(124, 512);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // showListView1
            // 
            this.showListView1.Location = new System.Drawing.Point(332, 45);
            this.showListView1.Name = "showListView1";
            this.showListView1.Size = new System.Drawing.Size(445, 574);
            this.showListView1.TabIndex = 17;
            this.showListView1.UseCompatibleStateImageBehavior = false;
            this.showListView1.View = System.Windows.Forms.View.List;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Select search Option ";
            // 
            // AddressBookUICsv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 631);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.showListView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.searchTextBox6);
            this.Controls.Add(this.searchComboBox1);
            this.Controls.Add(this.showButton2);
            this.Controls.Add(this.saveButton1);
            this.Controls.Add(this.addressTextBox5);
            this.Controls.Add(this.homecontactTextBox4);
            this.Controls.Add(this.personalcontactTextBox3);
            this.Controls.Add(this.emailTextBox2);
            this.Controls.Add(this.nameTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddressBookUICsv";
            this.Text = "AddressBookUICsv";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameTextBox1;
        private System.Windows.Forms.TextBox emailTextBox2;
        private System.Windows.Forms.TextBox personalcontactTextBox3;
        private System.Windows.Forms.TextBox homecontactTextBox4;
        private System.Windows.Forms.TextBox addressTextBox5;
        private System.Windows.Forms.Button saveButton1;
        private System.Windows.Forms.Button showButton2;
        private System.Windows.Forms.ComboBox searchComboBox1;
        private System.Windows.Forms.TextBox searchTextBox6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView showListView1;
        private System.Windows.Forms.Label label6;
    }
}

