namespace E_Contact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labContact = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labGender = new System.Windows.Forms.Label();
            this.labAddress = new System.Windows.Forms.Label();
            this.labLast = new System.Windows.Forms.Label();
            this.labFirst = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.butADD = new System.Windows.Forms.Button();
            this.butUPD = new System.Windows.Forms.Button();
            this.butCLR = new System.Windows.Forms.Button();
            this.butDEL = new System.Windows.Forms.Button();
            this.labSEA = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(575, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(234, 123);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 32);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // labContact
            // 
            this.labContact.AutoSize = true;
            this.labContact.BackColor = System.Drawing.Color.Transparent;
            this.labContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labContact.Location = new System.Drawing.Point(105, 123);
            this.labContact.Name = "labContact";
            this.labContact.Size = new System.Drawing.Size(104, 25);
            this.labContact.TabIndex = 2;
            this.labContact.Text = "Contact ID";
            this.labContact.Click += new System.EventHandler(this.Label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(234, 210);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(251, 32);
            this.textBox2.TabIndex = 3;
            // 
            // labGender
            // 
            this.labGender.AutoSize = true;
            this.labGender.BackColor = System.Drawing.Color.Transparent;
            this.labGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGender.Location = new System.Drawing.Point(107, 585);
            this.labGender.Name = "labGender";
            this.labGender.Size = new System.Drawing.Size(77, 25);
            this.labGender.TabIndex = 4;
            this.labGender.Text = "Gender";
            this.labGender.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // labAddress
            // 
            this.labAddress.AutoSize = true;
            this.labAddress.BackColor = System.Drawing.Color.Transparent;
            this.labAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAddress.Location = new System.Drawing.Point(105, 396);
            this.labAddress.Name = "labAddress";
            this.labAddress.Size = new System.Drawing.Size(85, 25);
            this.labAddress.TabIndex = 5;
            this.labAddress.Text = "Address";
            this.labAddress.Click += new System.EventHandler(this.LabAddress_Click);
            // 
            // labLast
            // 
            this.labLast.AutoSize = true;
            this.labLast.BackColor = System.Drawing.Color.Transparent;
            this.labLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLast.Location = new System.Drawing.Point(105, 305);
            this.labLast.Name = "labLast";
            this.labLast.Size = new System.Drawing.Size(106, 25);
            this.labLast.TabIndex = 6;
            this.labLast.Text = "Last Name";
            // 
            // labFirst
            // 
            this.labFirst.AutoSize = true;
            this.labFirst.BackColor = System.Drawing.Color.Transparent;
            this.labFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFirst.Location = new System.Drawing.Point(105, 210);
            this.labFirst.Name = "labFirst";
            this.labFirst.Size = new System.Drawing.Size(106, 25);
            this.labFirst.TabIndex = 7;
            this.labFirst.Text = "First Name";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(596, 188);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(736, 411);
            this.textBox4.TabIndex = 9;
            this.textBox4.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(234, 305);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(251, 32);
            this.textBox5.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox1.Location = new System.Drawing.Point(234, 584);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(251, 33);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // butADD
            // 
            this.butADD.BackColor = System.Drawing.Color.Maroon;
            this.butADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butADD.ForeColor = System.Drawing.Color.Orange;
            this.butADD.Location = new System.Drawing.Point(310, 666);
            this.butADD.Name = "butADD";
            this.butADD.Size = new System.Drawing.Size(148, 53);
            this.butADD.TabIndex = 12;
            this.butADD.Text = "ADD";
            this.butADD.UseVisualStyleBackColor = false;
            this.butADD.Click += new System.EventHandler(this.Button1_Click);
            // 
            // butUPD
            // 
            this.butUPD.BackColor = System.Drawing.Color.Red;
            this.butUPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butUPD.ForeColor = System.Drawing.Color.Chartreuse;
            this.butUPD.Location = new System.Drawing.Point(517, 666);
            this.butUPD.Name = "butUPD";
            this.butUPD.Size = new System.Drawing.Size(148, 53);
            this.butUPD.TabIndex = 13;
            this.butUPD.Text = "Update";
            this.butUPD.UseVisualStyleBackColor = false;
            // 
            // butCLR
            // 
            this.butCLR.BackColor = System.Drawing.Color.Cyan;
            this.butCLR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCLR.ForeColor = System.Drawing.Color.MidnightBlue;
            this.butCLR.Location = new System.Drawing.Point(923, 666);
            this.butCLR.Name = "butCLR";
            this.butCLR.Size = new System.Drawing.Size(148, 53);
            this.butCLR.TabIndex = 14;
            this.butCLR.Text = "Clear";
            this.butCLR.UseVisualStyleBackColor = false;
            // 
            // butDEL
            // 
            this.butDEL.BackColor = System.Drawing.SystemColors.ControlDark;
            this.butDEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDEL.Location = new System.Drawing.Point(724, 666);
            this.butDEL.Name = "butDEL";
            this.butDEL.Size = new System.Drawing.Size(148, 53);
            this.butDEL.TabIndex = 15;
            this.butDEL.Text = "Delete";
            this.butDEL.UseVisualStyleBackColor = false;
            // 
            // labSEA
            // 
            this.labSEA.AutoSize = true;
            this.labSEA.BackColor = System.Drawing.Color.Transparent;
            this.labSEA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSEA.Location = new System.Drawing.Point(611, 123);
            this.labSEA.Name = "labSEA";
            this.labSEA.Size = new System.Drawing.Size(75, 25);
            this.labSEA.TabIndex = 16;
            this.labSEA.Text = "Search";
            this.labSEA.Click += new System.EventHandler(this.LabSEA_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(724, 123);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(585, 32);
            this.textBox3.TabIndex = 17;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1259, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 774);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.labSEA);
            this.Controls.Add(this.butDEL);
            this.Controls.Add(this.butCLR);
            this.Controls.Add(this.butUPD);
            this.Controls.Add(this.butADD);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.labFirst);
            this.Controls.Add(this.labLast);
            this.Controls.Add(this.labAddress);
            this.Controls.Add(this.labGender);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labContact);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "E-Contact";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labContact;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labGender;
        private System.Windows.Forms.Label labAddress;
        private System.Windows.Forms.Label labLast;
        private System.Windows.Forms.Label labFirst;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button butADD;
        private System.Windows.Forms.Button butUPD;
        private System.Windows.Forms.Button butCLR;
        private System.Windows.Forms.Button butDEL;
        private System.Windows.Forms.Label labSEA;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

