namespace myWindowsFormsApp1
{
    partial class home
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
            this.savebutton1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.contactTextBox2 = new System.Windows.Forms.TextBox();
            this.addressTextBox3 = new System.Windows.Forms.TextBox();
            this.quantityTextBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.itemcomboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // savebutton1
            // 
            this.savebutton1.Location = new System.Drawing.Point(373, 51);
            this.savebutton1.Name = "savebutton1";
            this.savebutton1.Size = new System.Drawing.Size(75, 23);
            this.savebutton1.TabIndex = 0;
            this.savebutton1.Text = "Save";
            this.savebutton1.UseVisualStyleBackColor = true;
            this.savebutton1.Click += new System.EventHandler(this.savebutton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contact No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Order";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Quantity";
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.Location = new System.Drawing.Point(42, 54);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox1.TabIndex = 6;
            // 
            // contactTextBox2
            // 
            this.contactTextBox2.Location = new System.Drawing.Point(42, 108);
            this.contactTextBox2.Name = "contactTextBox2";
            this.contactTextBox2.Size = new System.Drawing.Size(100, 20);
            this.contactTextBox2.TabIndex = 7;
            // 
            // addressTextBox3
            // 
            this.addressTextBox3.Location = new System.Drawing.Point(42, 166);
            this.addressTextBox3.Name = "addressTextBox3";
            this.addressTextBox3.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox3.TabIndex = 8;
            this.addressTextBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // quantityTextBox5
            // 
            this.quantityTextBox5.Location = new System.Drawing.Point(42, 261);
            this.quantityTextBox5.Name = "quantityTextBox5";
            this.quantityTextBox5.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox5.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Customer Info";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(353, 108);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 107);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // itemcomboBox1
            // 
            this.itemcomboBox1.FormattingEnabled = true;
            this.itemcomboBox1.Items.AddRange(new object[] {
            "Black-100",
            "Cold-120",
            "Hot-90",
            "Regular-80"});
            this.itemcomboBox1.Location = new System.Drawing.Point(42, 220);
            this.itemcomboBox1.Name = "itemcomboBox1";
            this.itemcomboBox1.Size = new System.Drawing.Size(121, 21);
            this.itemcomboBox1.TabIndex = 13;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 308);
            this.Controls.Add(this.itemcomboBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.quantityTextBox5);
            this.Controls.Add(this.addressTextBox3);
            this.Controls.Add(this.contactTextBox2);
            this.Controls.Add(this.nameTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.savebutton1);
            this.Name = "home";
            this.Text = "home";
            this.Load += new System.EventHandler(this.home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button savebutton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameTextBox1;
        private System.Windows.Forms.TextBox contactTextBox2;
        private System.Windows.Forms.TextBox addressTextBox3;
        private System.Windows.Forms.TextBox quantityTextBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox itemcomboBox1;
    }
}

