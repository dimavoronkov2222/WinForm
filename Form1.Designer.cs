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
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(result);
            Controls.Add(label1);
            Controls.Add(piker2);
            Controls.Add(piker1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker piker1;
        private DateTimePicker piker2;
        private Label label1;
        private Label result;
        private Button button1;
    }
}