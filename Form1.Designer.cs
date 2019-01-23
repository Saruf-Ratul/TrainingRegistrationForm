namespace TrainingRegistrationForm
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
            this.regButton = new System.Windows.Forms.Button();
            this.receiptButton = new System.Windows.Forms.Button();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.courseComboBox = new System.Windows.Forms.ComboBox();
            this.durationComboBox = new System.Windows.Forms.ComboBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.pricetextBox1 = new System.Windows.Forms.TextBox();
            this.pricetextBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Organization Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Duration of Course:\t";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Number of Seat:";
            // 
            // regButton
            // 
            this.regButton.Location = new System.Drawing.Point(113, 303);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(115, 23);
            this.regButton.TabIndex = 10;
            this.regButton.Text = "Registration ";
            this.regButton.UseVisualStyleBackColor = true;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // receiptButton
            // 
            this.receiptButton.Location = new System.Drawing.Point(274, 303);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(115, 23);
            this.receiptButton.TabIndex = 11;
            this.receiptButton.Text = "Receipt";
            this.receiptButton.UseVisualStyleBackColor = true;
            this.receiptButton.Click += new System.EventHandler(this.receiptButton_Click);
            // 
            // nameComboBox
            // 
            this.nameComboBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Items.AddRange(new object[] {
            "BITM",
            "BTEB",
            "BSTI",
            "CGSP",
            "ICT"});
            this.nameComboBox.Location = new System.Drawing.Point(208, 43);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(223, 21);
            this.nameComboBox.TabIndex = 12;
            this.nameComboBox.Text = "Select Organization";
            // 
            // courseComboBox
            // 
            this.courseComboBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.courseComboBox.FormattingEnabled = true;
            this.courseComboBox.Items.AddRange(new object[] {
            "C++",
            "C#",
            "Java",
            "HTML",
            ".NET"});
            this.courseComboBox.Location = new System.Drawing.Point(208, 77);
            this.courseComboBox.Name = "courseComboBox";
            this.courseComboBox.Size = new System.Drawing.Size(223, 21);
            this.courseComboBox.TabIndex = 13;
            this.courseComboBox.Text = "Select Course";
            // 
            // durationComboBox
            // 
            this.durationComboBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.durationComboBox.FormattingEnabled = true;
            this.durationComboBox.Items.AddRange(new object[] {
            "One Month",
            "Three Month",
            "Six Month",
            "One Year"});
            this.durationComboBox.Location = new System.Drawing.Point(208, 156);
            this.durationComboBox.Name = "durationComboBox";
            this.durationComboBox.Size = new System.Drawing.Size(223, 21);
            this.durationComboBox.TabIndex = 14;
            this.durationComboBox.Text = "Select Duration";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(208, 237);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(223, 20);
            this.numberTextBox.TabIndex = 15;
            // 
            // pricetextBox1
            // 
            this.pricetextBox1.Location = new System.Drawing.Point(208, 118);
            this.pricetextBox1.Name = "pricetextBox1";
            this.pricetextBox1.Size = new System.Drawing.Size(223, 20);
            this.pricetextBox1.TabIndex = 16;
            this.pricetextBox1.TextChanged += new System.EventHandler(this.pricetextBox1_TextChanged);
            // 
            // pricetextBox2
            // 
            this.pricetextBox2.Location = new System.Drawing.Point(208, 203);
            this.pricetextBox2.Name = "pricetextBox2";
            this.pricetextBox2.Size = new System.Drawing.Size(223, 20);
            this.pricetextBox2.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 450);
            this.Controls.Add(this.pricetextBox2);
            this.Controls.Add(this.pricetextBox1);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.durationComboBox);
            this.Controls.Add(this.courseComboBox);
            this.Controls.Add(this.nameComboBox);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Personal Information";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.ComboBox nameComboBox;
        private System.Windows.Forms.ComboBox courseComboBox;
        private System.Windows.Forms.ComboBox durationComboBox;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.TextBox pricetextBox1;
        private System.Windows.Forms.TextBox pricetextBox2;
    }
}

