namespace LAB_05
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
            this.namebox = new System.Windows.Forms.TextBox();
            this.companybox = new System.Windows.Forms.TextBox();
            this.quantitybox = new System.Windows.Forms.TextBox();
            this.pricebox = new System.Windows.Forms.TextBox();
            this.addmedicinebutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.avlnamebox = new System.Windows.Forms.TextBox();
            this.avlquantitybox = new System.Windows.Forms.TextBox();
            this.availablitybutton = new System.Windows.Forms.Button();
            this.sellbutton = new System.Windows.Forms.Button();
            this.balancebutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Company";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price";
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(75, 50);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(100, 22);
            this.namebox.TabIndex = 4;
            // 
            // companybox
            // 
            this.companybox.Location = new System.Drawing.Point(75, 81);
            this.companybox.Name = "companybox";
            this.companybox.Size = new System.Drawing.Size(100, 22);
            this.companybox.TabIndex = 5;
            // 
            // quantitybox
            // 
            this.quantitybox.Location = new System.Drawing.Point(75, 112);
            this.quantitybox.Name = "quantitybox";
            this.quantitybox.Size = new System.Drawing.Size(100, 22);
            this.quantitybox.TabIndex = 6;
            // 
            // pricebox
            // 
            this.pricebox.Location = new System.Drawing.Point(75, 148);
            this.pricebox.Name = "pricebox";
            this.pricebox.Size = new System.Drawing.Size(100, 22);
            this.pricebox.TabIndex = 7;
            // 
            // addmedicinebutton
            // 
            this.addmedicinebutton.BackColor = System.Drawing.Color.Gold;
            this.addmedicinebutton.Location = new System.Drawing.Point(75, 187);
            this.addmedicinebutton.Name = "addmedicinebutton";
            this.addmedicinebutton.Size = new System.Drawing.Size(100, 41);
            this.addmedicinebutton.TabIndex = 9;
            this.addmedicinebutton.Text = "Add Medicine";
            this.addmedicinebutton.UseVisualStyleBackColor = false;
            this.addmedicinebutton.Click += new System.EventHandler(this.Add_Medicine_on_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Add Medicine";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(256, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Availability and Sell\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(269, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(258, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Quantity";
            // 
            // avlnamebox
            // 
            this.avlnamebox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.avlnamebox.Location = new System.Drawing.Point(319, 50);
            this.avlnamebox.Name = "avlnamebox";
            this.avlnamebox.Size = new System.Drawing.Size(100, 22);
            this.avlnamebox.TabIndex = 14;
            // 
            // avlquantitybox
            // 
            this.avlquantitybox.Location = new System.Drawing.Point(319, 84);
            this.avlquantitybox.Name = "avlquantitybox";
            this.avlquantitybox.Size = new System.Drawing.Size(100, 22);
            this.avlquantitybox.TabIndex = 15;
            // 
            // availablitybutton
            // 
            this.availablitybutton.BackColor = System.Drawing.Color.Gold;
            this.availablitybutton.Location = new System.Drawing.Point(425, 44);
            this.availablitybutton.Name = "availablitybutton";
            this.availablitybutton.Size = new System.Drawing.Size(100, 34);
            this.availablitybutton.TabIndex = 16;
            this.availablitybutton.Text = "Availablity\r\n";
            this.availablitybutton.UseVisualStyleBackColor = false;
            this.availablitybutton.Click += new System.EventHandler(this.Check_Availablity_on_Click);
            // 
            // sellbutton
            // 
            this.sellbutton.BackColor = System.Drawing.Color.Gold;
            this.sellbutton.Location = new System.Drawing.Point(319, 123);
            this.sellbutton.Name = "sellbutton";
            this.sellbutton.Size = new System.Drawing.Size(100, 41);
            this.sellbutton.TabIndex = 17;
            this.sellbutton.Text = "Sell Medicine";
            this.sellbutton.UseVisualStyleBackColor = false;
            this.sellbutton.Click += new System.EventHandler(this.Sell_Medicine_on_Click);
            // 
            // balancebutton
            // 
            this.balancebutton.BackColor = System.Drawing.Color.Gold;
            this.balancebutton.Location = new System.Drawing.Point(306, 270);
            this.balancebutton.Name = "balancebutton";
            this.balancebutton.Size = new System.Drawing.Size(178, 123);
            this.balancebutton.TabIndex = 18;
            this.balancebutton.Text = "Check\r\nBalance\r\n";
            this.balancebutton.UseVisualStyleBackColor = false;
            this.balancebutton.Click += new System.EventHandler(this.Check_Balance_on_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.BackColor = System.Drawing.Color.Gold;
            this.clearbutton.Location = new System.Drawing.Point(75, 234);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(100, 41);
            this.clearbutton.TabIndex = 19;
            this.clearbutton.Text = "Clear";
            this.clearbutton.UseVisualStyleBackColor = false;
            this.clearbutton.Click += new System.EventHandler(this.Clear_on_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(535, 450);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.balancebutton);
            this.Controls.Add(this.sellbutton);
            this.Controls.Add(this.availablitybutton);
            this.Controls.Add(this.avlquantitybox);
            this.Controls.Add(this.avlnamebox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addmedicinebutton);
            this.Controls.Add(this.pricebox);
            this.Controls.Add(this.quantitybox);
            this.Controls.Add(this.companybox);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pharmacy Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.TextBox companybox;
        private System.Windows.Forms.TextBox quantitybox;
        private System.Windows.Forms.TextBox pricebox;
        private System.Windows.Forms.Button addmedicinebutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox avlnamebox;
        private System.Windows.Forms.TextBox avlquantitybox;
        private System.Windows.Forms.Button availablitybutton;
        private System.Windows.Forms.Button sellbutton;
        private System.Windows.Forms.Button balancebutton;
        private System.Windows.Forms.Button clearbutton;
    }
}

