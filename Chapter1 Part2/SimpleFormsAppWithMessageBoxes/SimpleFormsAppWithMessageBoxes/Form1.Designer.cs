namespace SimpleFormsAppWithMessageBoxes
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(82, 108);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(262, 34);
            label1.Name = "label1";
            label1.Size = new Size(199, 23);
            label1.TabIndex = 1;
            label1.Text = "Simple Application  Form";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(82, 80);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 2;
            label2.Text = " First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(82, 151);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 3;
            label3.Text = "Middle Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ImageAlign = ContentAlignment.TopLeft;
            label4.Location = new Point(82, 222);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 4;
            label4.Text = "Last Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(82, 297);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 5;
            label5.Text = "Suffix";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(82, 174);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 23);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(82, 256);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(121, 23);
            textBox3.TabIndex = 7;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(82, 315);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(121, 23);
            textBox4.TabIndex = 8;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(276, 374);
            button1.Name = "button1";
            button1.Size = new Size(137, 35);
            button1.TabIndex = 9;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(642, 510);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
    }
}
