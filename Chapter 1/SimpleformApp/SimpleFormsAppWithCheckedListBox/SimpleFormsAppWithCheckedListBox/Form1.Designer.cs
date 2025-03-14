namespace SimpleFormsAppWithCheckedListBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            checkedListbox = new CheckedListBox();
            add = new Button();
            label3 = new Label();
            listBox = new ListBox();
            remove = new Button();
            clear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(184, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(297, 28);
            label1.TabIndex = 0;
            label1.Text = "Simple Favorite Movie Picker App";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(43, 83);
            label2.Name = "label2";
            label2.Size = new Size(188, 23);
            label2.TabIndex = 1;
            label2.Text = "Horror Movie/Series List";
            // 
            // checkedListbox
            // 
            checkedListbox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkedListbox.FormattingEnabled = true;
            checkedListbox.Location = new Point(56, 131);
            checkedListbox.Name = "checkedListbox";
            checkedListbox.Size = new Size(158, 151);
            checkedListbox.TabIndex = 2;
            // 
            // add
            // 
            add.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add.Location = new Point(531, 131);
            add.Name = "add";
            add.Size = new Size(87, 35);
            add.TabIndex = 3;
            add.Text = "Add";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(318, 83);
            label3.Name = "label3";
            label3.Size = new Size(228, 23);
            label3.TabIndex = 4;
            label3.Text = "Horror Movies/Series Selected";
            // 
            // listBox
            // 
            listBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 18;
            listBox.Location = new Point(342, 131);
            listBox.Name = "listBox";
            listBox.Size = new Size(139, 148);
            listBox.TabIndex = 5;
            // 
            // remove
            // 
            remove.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            remove.Location = new Point(531, 191);
            remove.Name = "remove";
            remove.Size = new Size(91, 34);
            remove.TabIndex = 6;
            remove.Text = "Remove";
            remove.UseVisualStyleBackColor = true;
            remove.Click += remove_Click;
            // 
            // clear
            // 
            clear.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clear.Location = new Point(531, 250);
            clear.Name = "clear";
            clear.Size = new Size(87, 33);
            clear.TabIndex = 7;
            clear.Text = "Clear";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(726, 399);
            Controls.Add(clear);
            Controls.Add(remove);
            Controls.Add(listBox);
            Controls.Add(label3);
            Controls.Add(add);
            Controls.Add(checkedListbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private CheckedListBox checkedListbox;
        private Button add;
        private Label label3;
        private ListBox listBox;
        private Button remove;
        private Button clear;
    }
}
