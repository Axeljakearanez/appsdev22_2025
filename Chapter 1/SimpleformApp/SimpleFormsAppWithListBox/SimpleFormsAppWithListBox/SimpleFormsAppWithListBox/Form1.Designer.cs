namespace SimpleFormsAppWithListBox
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
            lstbox = new ListBox();
            textBox1 = new TextBox();
            add = new Button();
            remove = new Button();
            clear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(145, 9);
            label1.Name = "label1";
            label1.Size = new Size(178, 21);
            label1.TabIndex = 0;
            label1.Text = "Simple Name Reviewer";
            // 
            // lstbox
            // 
            lstbox.FormattingEnabled = true;
            lstbox.ItemHeight = 15;
            lstbox.Location = new Point(12, 46);
            lstbox.Name = "lstbox";
            lstbox.Size = new Size(120, 199);
            lstbox.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(223, 198);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // add
            // 
            add.Location = new Point(231, 46);
            add.Name = "add";
            add.Size = new Size(75, 23);
            add.TabIndex = 3;
            add.Text = "Add";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // remove
            // 
            remove.Location = new Point(231, 91);
            remove.Name = "remove";
            remove.Size = new Size(75, 23);
            remove.TabIndex = 4;
            remove.Text = "Remove";
            remove.UseVisualStyleBackColor = true;
            remove.Click += button2_Click;
            // 
            // clear
            // 
            clear.Location = new Point(231, 139);
            clear.Name = "clear";
            clear.Size = new Size(75, 23);
            clear.TabIndex = 5;
            clear.Text = "Clear";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 450);
            Controls.Add(clear);
            Controls.Add(remove);
            Controls.Add(add);
            Controls.Add(textBox1);
            Controls.Add(lstbox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstbox;
        private TextBox textBox1;
        private Button add;
        private Button remove;
        private Button clear;
    }
}
