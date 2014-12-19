namespace BookUIHashtableApp
{
    partial class Form1
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
            this.label6 = new System.Windows.Forms.Label();
            this.isbntextBox1 = new System.Windows.Forms.TextBox();
            this.isbntextBox2 = new System.Windows.Forms.TextBox();
            this.addbutton1 = new System.Windows.Forms.Button();
            this.findbutton2 = new System.Windows.Forms.Button();
            this.detailstextBox1 = new System.Windows.Forms.TextBox();
            this.detailstextBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add book info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ISBN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Book Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Search book";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ISBN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Book Details";
            // 
            // isbntextBox1
            // 
            this.isbntextBox1.Location = new System.Drawing.Point(176, 89);
            this.isbntextBox1.Name = "isbntextBox1";
            this.isbntextBox1.Size = new System.Drawing.Size(100, 20);
            this.isbntextBox1.TabIndex = 6;
            // 
            // isbntextBox2
            // 
            this.isbntextBox2.Location = new System.Drawing.Point(176, 287);
            this.isbntextBox2.Name = "isbntextBox2";
            this.isbntextBox2.Size = new System.Drawing.Size(100, 20);
            this.isbntextBox2.TabIndex = 7;
            // 
            // addbutton1
            // 
            this.addbutton1.Location = new System.Drawing.Point(383, 132);
            this.addbutton1.Name = "addbutton1";
            this.addbutton1.Size = new System.Drawing.Size(75, 23);
            this.addbutton1.TabIndex = 10;
            this.addbutton1.Text = "Add";
            this.addbutton1.UseVisualStyleBackColor = true;
            this.addbutton1.Click += new System.EventHandler(this.addbutton1_Click);
            // 
            // findbutton2
            // 
            this.findbutton2.Location = new System.Drawing.Point(383, 354);
            this.findbutton2.Name = "findbutton2";
            this.findbutton2.Size = new System.Drawing.Size(75, 23);
            this.findbutton2.TabIndex = 11;
            this.findbutton2.Text = "Find";
            this.findbutton2.UseVisualStyleBackColor = true;
            this.findbutton2.Click += new System.EventHandler(this.findbutton2_Click);
            // 
            // detailstextBox1
            // 
            this.detailstextBox1.Location = new System.Drawing.Point(176, 139);
            this.detailstextBox1.Multiline = true;
            this.detailstextBox1.Name = "detailstextBox1";
            this.detailstextBox1.Size = new System.Drawing.Size(100, 73);
            this.detailstextBox1.TabIndex = 12;
            // 
            // detailstextBox2
            // 
            this.detailstextBox2.Location = new System.Drawing.Point(176, 354);
            this.detailstextBox2.Multiline = true;
            this.detailstextBox2.Name = "detailstextBox2";
            this.detailstextBox2.Size = new System.Drawing.Size(100, 84);
            this.detailstextBox2.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 478);
            this.Controls.Add(this.detailstextBox2);
            this.Controls.Add(this.detailstextBox1);
            this.Controls.Add(this.findbutton2);
            this.Controls.Add(this.addbutton1);
            this.Controls.Add(this.isbntextBox2);
            this.Controls.Add(this.isbntextBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "BookInfoUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox isbntextBox1;
        private System.Windows.Forms.TextBox isbntextBox2;
        private System.Windows.Forms.Button addbutton1;
        private System.Windows.Forms.Button findbutton2;
        private System.Windows.Forms.TextBox detailstextBox1;
        private System.Windows.Forms.TextBox detailstextBox2;
    }
}

