namespace SimpleformApp
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
            firstname = new TextBox();
            lastname = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Submit = new Button();
            SuspendLayout();
            // 
            // firstname
            // 
            firstname.Location = new Point(97, 98);
            firstname.Name = "firstname";
            firstname.Size = new Size(100, 23);
            firstname.TabIndex = 0;
            firstname.TextChanged += textBox1_TextChanged;
            // 
            // lastname
            // 
            lastname.Location = new Point(97, 201);
            lastname.Name = "lastname";
            lastname.Size = new Size(100, 23);
            lastname.TabIndex = 1;
            lastname.TextChanged += lastname_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 56);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 2;
            label1.Text = "FirstName";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 164);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 3;
            label2.Text = "Lastname";
            label2.Click += label2_Click;
            // 
            // Submit
            // 
            Submit.Location = new Point(97, 265);
            Submit.Name = "Submit";
            Submit.Size = new Size(75, 23);
            Submit.TabIndex = 4;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(383, 378);
            Controls.Add(Submit);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lastname);
            Controls.Add(firstname);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstname;
        private TextBox lastname;
        private Label label1;
        private Label label2;
        private Button Submit;
    }
}
