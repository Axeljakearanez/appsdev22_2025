namespace SimpleFavoriteCartoonFormApp
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
            comboBoxCharacters = new ComboBox();
            btnView = new Button();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            pictureBoxCharacter = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCharacter).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(117, 25);
            label1.Name = "label1";
            label1.Size = new Size(536, 38);
            label1.TabIndex = 0;
            label1.Text = "Simple Favorite Cartoon Character Picker";
            // 
            // comboBoxCharacters
            // 
            comboBoxCharacters.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            comboBoxCharacters.FormattingEnabled = true;
            comboBoxCharacters.Location = new Point(31, 159);
            comboBoxCharacters.Name = "comboBoxCharacters";
            comboBoxCharacters.Size = new Size(188, 33);
            comboBoxCharacters.TabIndex = 1;
            // 
            // btnView
            // 
            btnView.BackColor = Color.Transparent;
            btnView.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnView.Location = new Point(57, 223);
            btnView.Name = "btnView";
            btnView.Size = new Size(128, 32);
            btnView.TabIndex = 2;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(57, 288);
            button2.Name = "button2";
            button2.Size = new Size(128, 36);
            button2.TabIndex = 3;
            button2.Text = "Clear";
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(544, 89);
            label2.Name = "label2";
            label2.Size = new Size(68, 28);
            label2.TabIndex = 4;
            label2.Text = "Image";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(57, 110);
            label3.Name = "label3";
            label3.Size = new Size(143, 28);
            label3.TabIndex = 5;
            label3.Text = "Select an Item:";
            // 
            // pictureBoxCharacter
            // 
            pictureBoxCharacter.BackColor = SystemColors.ControlLightLight;
            pictureBoxCharacter.Location = new Point(404, 133);
            pictureBoxCharacter.Name = "pictureBoxCharacter";
            pictureBoxCharacter.Size = new Size(342, 246);
            pictureBoxCharacter.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCharacter.TabIndex = 6;
            pictureBoxCharacter.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(823, 517);
            Controls.Add(pictureBoxCharacter);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(btnView);
            Controls.Add(comboBoxCharacters);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxCharacter).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxCharacters;
        private Button btnView;
        private Button button2;
        private Label label2;
        private Label label3;
        private PictureBox pictureBoxCharacter;
    }
}
