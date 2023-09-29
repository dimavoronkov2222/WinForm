namespace WinForm
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
            monthCalendar1 = new MonthCalendar();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(464, 121);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(130, 121);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(163, 27);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(140, 182);
            button1.Name = "button1";
            button1.Size = new Size(141, 29);
            button1.TabIndex = 2;
            button1.Text = "view on calendar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            piker1 = new DateTimePicker();
            piker2 = new DateTimePicker();
            label1 = new Label();
            result = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // piker1
            // 
            piker1.Location = new Point(75, 92);
            piker1.Name = "piker1";
            piker1.Size = new Size(250, 27);
            piker1.TabIndex = 0;
            // 
            // piker2
            // 
            piker2.Location = new Point(376, 92);
            piker2.Name = "piker2";
            piker2.Size = new Size(250, 27);
            piker2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(329, 181);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 2;
            label1.Text = "Result";
            // 
            // result
            // 
            result.AutoSize = true;
            result.Location = new Point(344, 215);
            result.Name = "result";
            result.Size = new Size(17, 20);
            result.TabIndex = 3;
            result.Text = "0";
            // 
            // button1
            // 
            button1.Location = new Point(326, 149);
            button1.Name = "button1";
            button1.Size = new Size(59, 29);
            button1.TabIndex = 4;
            button1.Text = "count";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Surname = new TextBox();
            Name1 = new TextBox();
            Patronymic = new TextBox();
            label4 = new Label();
            Gender_of_a_person = new TextBox();
            label5 = new Label();
            Year_and_date_of_birth = new TextBox();
            label6 = new Label();
            Family_status = new TextBox();
            label7 = new Label();
            Additional_Information = new TextBox();
            save_button = new Button();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 55);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Surname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(226, 55);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(326, 55);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 2;
            label3.Text = "Patronymic";
            // 
            // Surname
            // 
            Surname.Location = new Point(69, 78);
            Surname.Name = "Surname";
            Surname.Size = new Size(102, 27);
            Surname.TabIndex = 3;
            // 
            // Name1
            // 
            Name1.Location = new Point(195, 78);
            Name1.Name = "Name1";
            Name1.Size = new Size(102, 27);
            Name1.TabIndex = 4;
            // 
            // Patronymic
            // 
            Patronymic.Location = new Point(315, 78);
            Patronymic.Name = "Patronymic";
            Patronymic.Size = new Size(102, 27);
            Patronymic.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 118);
            label4.Name = "label4";
            label4.Size = new Size(136, 20);
            label4.TabIndex = 6;
            label4.Text = "Gender of a person";
            // 
            // Gender_of_a_person
            // 
            Gender_of_a_person.Location = new Point(54, 141);
            Gender_of_a_person.Name = "Gender_of_a_person";
            Gender_of_a_person.Size = new Size(125, 27);
            Gender_of_a_person.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(226, 118);
            label5.Name = "label5";
            label5.Size = new Size(153, 20);
            label5.TabIndex = 8;
            label5.Text = "Year and date of birth";
            // 
            // Year_and_date_of_birth
            // 
            Year_and_date_of_birth.Location = new Point(226, 141);
            Year_and_date_of_birth.Name = "Year_and_date_of_birth";
            Year_and_date_of_birth.Size = new Size(153, 27);
            Year_and_date_of_birth.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(472, 65);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 10;
            label6.Text = "Family status";
            // 
            // Family_status
            // 
            Family_status.Location = new Point(457, 88);
            Family_status.Name = "Family_status";
            Family_status.Size = new Size(125, 27);
            Family_status.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(440, 118);
            label7.Name = "label7";
            label7.Size = new Size(161, 20);
            label7.TabIndex = 12;
            label7.Text = "Additional Information";
            // 
            // Additional_Information
            // 
            Additional_Information.Location = new Point(440, 146);
            Additional_Information.Name = "Additional_Information";
            Additional_Information.Size = new Size(161, 27);
            Additional_Information.TabIndex = 13;
            // 
            // save_button
            // 
            save_button.Location = new Point(265, 211);
            save_button.Name = "save_button";
            save_button.Size = new Size(94, 44);
            save_button.TabIndex = 14;
            save_button.Text = "Save";
            save_button.UseVisualStyleBackColor = true;
            save_button.Click += save_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(monthCalendar1);
            Name = "Form1";
            Text = "Form1";
            Controls.Add(result);
            Controls.Add(label1);
            Controls.Add(piker2);
            Controls.Add(piker1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ClientSize = new Size(702, 433);
            Controls.Add(save_button);
            Controls.Add(Additional_Information);
            Controls.Add(label7);
            Controls.Add(Family_status);
            Controls.Add(label6);
            Controls.Add(Year_and_date_of_birth);
            Controls.Add(label5);
            Controls.Add(Gender_of_a_person);
            Controls.Add(label4);
            Controls.Add(Patronymic);
            Controls.Add(Name1);
            Controls.Add(Surname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "information person";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MonthCalendar monthCalendar1;
        private TextBox textBox1;
        private Button button1;
        private DateTimePicker piker1;
        private DateTimePicker piker2;
        private Label label1;
        private Label result;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Surname;
        private TextBox Name1;
        private TextBox Patronymic;
        private Label label4;
        private TextBox Gender_of_a_person;
        private Label label5;
        private TextBox Year_and_date_of_birth;
        private Label label6;
        private TextBox Family_status;
        private Label label7;
        private TextBox Additional_Information;
        private Button save_button;
        private SaveFileDialog saveFileDialog1;
    }
}