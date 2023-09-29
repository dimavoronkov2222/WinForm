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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Surname = new TextBox();
            Name = new TextBox();
            Patronymic = new TextBox();
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
            // Name
            // 
            Name.Location = new Point(195, 78);
            Name.Name = "Name";
            Name.Size = new Size(102, 27);
            Name.TabIndex = 4;
            // 
            // Patronymic
            // 
            Patronymic.Location = new Point(315, 78);
            Patronymic.Name = "Patronymic";
            Patronymic.Size = new Size(102, 27);
            Patronymic.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 433);
            Controls.Add(Patronymic);
            Controls.Add(Name);
            Controls.Add(Surname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Surname;
        private TextBox Name;
        private TextBox Patronymic;
    }
}