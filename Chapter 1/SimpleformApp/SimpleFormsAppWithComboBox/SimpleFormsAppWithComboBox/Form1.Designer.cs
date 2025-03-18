namespace SimpleFormsAppWithComboBox
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
            label3 = new Label();
            label4 = new Label();
            checkedListBoxFood = new CheckedListBox();
            comboBoxCuisine = new ComboBox();
            listBoxFavorites = new ListBox();
            btnSelect = new Button();
            btnAdd = new Button();
            btnRemove = new Button();
            btnClearAll = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(305, 9);
            label1.Name = "label1";
            label1.Size = new Size(400, 31);
            label1.TabIndex = 0;
            label1.Text = "SIMPLE FAVORITE FOOD PICKER APP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SeaShell;
            label2.Location = new Point(34, 80);
            label2.Name = "label2";
            label2.Size = new Size(116, 33);
            label2.TabIndex = 1;
            label2.Text = "Cuisine";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SeaShell;
            label3.Location = new Point(286, 74);
            label3.Name = "label3";
            label3.Size = new Size(140, 33);
            label3.TabIndex = 2;
            label3.Text = "Food List";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(499, 74);
            label4.Name = "label4";
            label4.Size = new Size(306, 33);
            label4.TabIndex = 3;
            label4.Text = "My Favorite Food List";
            // 
            // checkedListBoxFood
            // 
            checkedListBoxFood.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            checkedListBoxFood.FormattingEnabled = true;
            checkedListBoxFood.Location = new Point(261, 117);
            checkedListBoxFood.Name = "checkedListBoxFood";
            checkedListBoxFood.Size = new Size(195, 104);
            checkedListBoxFood.TabIndex = 4;
            // 
            // comboBoxCuisine
            // 
            comboBoxCuisine.Font = new Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            comboBoxCuisine.FormattingEnabled = true;
            comboBoxCuisine.Location = new Point(12, 117);
            comboBoxCuisine.Name = "comboBoxCuisine";
            comboBoxCuisine.Size = new Size(151, 33);
            comboBoxCuisine.TabIndex = 5;
            // 
            // listBoxFavorites
            // 
            listBoxFavorites.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            listBoxFavorites.FormattingEnabled = true;
            listBoxFavorites.ItemHeight = 24;
            listBoxFavorites.Location = new Point(514, 117);
            listBoxFavorites.Name = "listBoxFavorites";
            listBoxFavorites.Size = new Size(248, 196);
            listBoxFavorites.TabIndex = 6;
            // 
            // btnSelect
            // 
            btnSelect.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelect.Location = new Point(12, 173);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(151, 38);
            btnSelect.TabIndex = 7;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(261, 250);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(195, 36);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.Location = new Point(787, 173);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 38);
            btnRemove.TabIndex = 9;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnClearAll
            // 
            btnClearAll.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearAll.Location = new Point(787, 238);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(94, 34);
            btnClearAll.TabIndex = 10;
            btnClearAll.Text = "Clear All";
            btnClearAll.UseVisualStyleBackColor = true;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(958, 450);
            Controls.Add(btnClearAll);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(btnSelect);
            Controls.Add(listBoxFavorites);
            Controls.Add(comboBoxCuisine);
            Controls.Add(checkedListBoxFood);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckedListBox checkedListBoxFood;
        private ComboBox comboBoxCuisine;
        private ListBox listBoxFavorites;
        private Button btnSelect;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnClearAll;
    }
}
