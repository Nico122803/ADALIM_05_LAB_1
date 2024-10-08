namespace STUDENT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            Button_Browse = new Button();
            Button_Register = new Button();
            ComboBox_SelectP = new ComboBox();
            ComboBox_Year = new ComboBox();
            ComboBox_Month = new ComboBox();
            Combobox_Day = new ComboBox();
            RadioButton_Female = new RadioButton();
            RadioButton_Male = new RadioButton();
            TextBox_MiddleN = new TextBox();
            TextBox_FirstN = new TextBox();
            TextBox_LastN = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            Label_StudentR = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLight;
            pictureBox1.Location = new Point(409, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(257, 237);
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // Button_Browse
            // 
            Button_Browse.Location = new Point(476, 292);
            Button_Browse.Name = "Button_Browse";
            Button_Browse.Size = new Size(134, 31);
            Button_Browse.TabIndex = 37;
            Button_Browse.Text = "Browse";
            Button_Browse.UseVisualStyleBackColor = true;
            Button_Browse.Click += Button_Browse_Click;
            // 
            // Button_Register
            // 
            Button_Register.BackColor = Color.Blue;
            Button_Register.FlatStyle = FlatStyle.Flat;
            Button_Register.ForeColor = Color.White;
            Button_Register.Location = new Point(138, 367);
            Button_Register.Name = "Button_Register";
            Button_Register.Size = new Size(162, 35);
            Button_Register.TabIndex = 36;
            Button_Register.Text = "Register Student";
            Button_Register.UseVisualStyleBackColor = false;
            Button_Register.Click += Button_Register_Click;
            // 
            // ComboBox_SelectP
            // 
            ComboBox_SelectP.FormattingEnabled = true;
            ComboBox_SelectP.Items.AddRange(new object[] { "BS in Information Technology (BSIT)", "BS in Computer Science (BSCS)", "BS in Information Systems (BSIS)", "BS in Business Administration (BSBA)", "BS in Accountancy (BSA)", "BS in Accounting Information System (BSAIS)", "BS in Management Accounting (BSMA)", "BS in Retail Technology and Consumer Science (BSRTCS)", "BS in Hospitality Management (BSHM)", "BS in Culinary Management (BSCM)", "BA in Communication (BACOMM)", "Bachelor of Multimedia Arts (BMMA)", "Bachelor of Arts in PsychologyBS in Tourism Management (BSTM)" });
            ComboBox_SelectP.Location = new Point(134, 338);
            ComboBox_SelectP.Name = "ComboBox_SelectP";
            ComboBox_SelectP.Size = new Size(337, 23);
            ComboBox_SelectP.TabIndex = 35;
            ComboBox_SelectP.Text = "-Select program-";
            ComboBox_SelectP.SelectedIndexChanged += ComboBox_SelectP_SelectedIndexChanged;
            // 
            // ComboBox_Year
            // 
            ComboBox_Year.FormattingEnabled = true;
            ComboBox_Year.Location = new Point(306, 289);
            ComboBox_Year.Name = "ComboBox_Year";
            ComboBox_Year.Size = new Size(78, 23);
            ComboBox_Year.TabIndex = 34;
            ComboBox_Year.Text = "-Year-";
            ComboBox_Year.SelectedIndexChanged += ComboBox_Year_SelectedIndexChanged;
            // 
            // ComboBox_Month
            // 
            ComboBox_Month.FormattingEnabled = true;
            ComboBox_Month.Items.AddRange(new object[] { "January", "Febuary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            ComboBox_Month.Location = new Point(209, 289);
            ComboBox_Month.Name = "ComboBox_Month";
            ComboBox_Month.Size = new Size(91, 23);
            ComboBox_Month.TabIndex = 33;
            ComboBox_Month.Text = "-Month-";
            ComboBox_Month.SelectedIndexChanged += ComboBox_Month_SelectedIndexChanged;
            // 
            // Combobox_Day
            // 
            Combobox_Day.FormattingEnabled = true;
            Combobox_Day.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            Combobox_Day.Location = new Point(138, 289);
            Combobox_Day.Name = "Combobox_Day";
            Combobox_Day.Size = new Size(65, 23);
            Combobox_Day.TabIndex = 32;
            Combobox_Day.Text = "-Day-";
            Combobox_Day.SelectedIndexChanged += Combobox_Day_SelectedIndexChanged;
            // 
            // RadioButton_Female
            // 
            RadioButton_Female.AutoSize = true;
            RadioButton_Female.Location = new Point(272, 244);
            RadioButton_Female.Name = "RadioButton_Female";
            RadioButton_Female.Size = new Size(63, 19);
            RadioButton_Female.TabIndex = 31;
            RadioButton_Female.TabStop = true;
            RadioButton_Female.Text = "Female";
            RadioButton_Female.UseVisualStyleBackColor = true;
            // 
            // RadioButton_Male
            // 
            RadioButton_Male.AutoSize = true;
            RadioButton_Male.Location = new Point(215, 244);
            RadioButton_Male.Name = "RadioButton_Male";
            RadioButton_Male.Size = new Size(51, 19);
            RadioButton_Male.TabIndex = 30;
            RadioButton_Male.TabStop = true;
            RadioButton_Male.Text = "Male";
            RadioButton_Male.UseVisualStyleBackColor = true;
            // 
            // TextBox_MiddleN
            // 
            TextBox_MiddleN.Location = new Point(138, 215);
            TextBox_MiddleN.Name = "TextBox_MiddleN";
            TextBox_MiddleN.Size = new Size(246, 23);
            TextBox_MiddleN.TabIndex = 29;
            TextBox_MiddleN.TextChanged += TextBox_MiddleN_TextChanged;
            // 
            // TextBox_FirstN
            // 
            TextBox_FirstN.Location = new Point(138, 165);
            TextBox_FirstN.Name = "TextBox_FirstN";
            TextBox_FirstN.Size = new Size(246, 23);
            TextBox_FirstN.TabIndex = 28;
            TextBox_FirstN.TextChanged += TextBox_FirstN_TextChanged;
            // 
            // TextBox_LastN
            // 
            TextBox_LastN.Location = new Point(140, 112);
            TextBox_LastN.Name = "TextBox_LastN";
            TextBox_LastN.Size = new Size(246, 23);
            TextBox_LastN.TabIndex = 27;
            TextBox_LastN.TextChanged += TextBox_LastN_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(134, 315);
            label7.Name = "label7";
            label7.Size = new Size(146, 20);
            label7.TabIndex = 26;
            label7.Text = "Program to apply * ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(134, 266);
            label6.Name = "label6";
            label6.Size = new Size(110, 20);
            label6.TabIndex = 25;
            label6.Text = "Date of birth *";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(134, 242);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 24;
            label5.Text = "Gender *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(134, 191);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 23;
            label4.Text = "Middle name *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(138, 141);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 22;
            label3.Text = "First name *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(138, 88);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 21;
            label2.Text = "Last name *";
            // 
            // Label_StudentR
            // 
            Label_StudentR.AutoSize = true;
            Label_StudentR.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Label_StudentR.Location = new Point(134, 49);
            Label_StudentR.Name = "Label_StudentR";
            Label_StudentR.Size = new Size(243, 25);
            Label_StudentR.TabIndex = 20;
            Label_StudentR.Text = "Student Registration Form";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.Yellow;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(Button_Browse);
            Controls.Add(Button_Register);
            Controls.Add(ComboBox_SelectP);
            Controls.Add(ComboBox_Year);
            Controls.Add(ComboBox_Month);
            Controls.Add(Combobox_Day);
            Controls.Add(RadioButton_Female);
            Controls.Add(RadioButton_Male);
            Controls.Add(TextBox_MiddleN);
            Controls.Add(TextBox_FirstN);
            Controls.Add(TextBox_LastN);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Label_StudentR);
            Name = "Form1";
            Text = "Student Registration";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button Button_Browse;
        private Button Button_Register;
        private ComboBox ComboBox_SelectP;
        private ComboBox ComboBox_Year;
        private ComboBox ComboBox_Month;
        private ComboBox Combobox_Day;
        private RadioButton RadioButton_Female;
        private RadioButton RadioButton_Male;
        private TextBox TextBox_MiddleN;
        private TextBox TextBox_FirstN;
        private TextBox TextBox_LastN;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label Label_StudentR;
    }
}
