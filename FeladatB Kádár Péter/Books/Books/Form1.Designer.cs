namespace Books {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            PriciestBooksDataGrid = new DataGridView();
            Category = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            BooksInCategoryListBox = new ListBox();
            BookCountLabel = new Label();
            label1 = new Label();
            CategorySelectComboBox = new ComboBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)PriciestBooksDataGrid).BeginInit();
            SuspendLayout();
            // 
            // PriciestBooksDataGrid
            // 
            PriciestBooksDataGrid.AllowUserToAddRows = false;
            PriciestBooksDataGrid.AllowUserToDeleteRows = false;
            PriciestBooksDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PriciestBooksDataGrid.Columns.AddRange(new DataGridViewColumn[] { Category, Title, Price });
            PriciestBooksDataGrid.Location = new Point(12, 188);
            PriciestBooksDataGrid.Name = "PriciestBooksDataGrid";
            PriciestBooksDataGrid.ReadOnly = true;
            PriciestBooksDataGrid.RowTemplate.Height = 25;
            PriciestBooksDataGrid.Size = new Size(362, 200);
            PriciestBooksDataGrid.TabIndex = 0;
            // 
            // Category
            // 
            Category.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Category.FillWeight = 93.27411F;
            Category.HeaderText = "Kategória";
            Category.Name = "Category";
            Category.ReadOnly = true;
            // 
            // Title
            // 
            Title.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Title.FillWeight = 93.27411F;
            Title.HeaderText = "Cím";
            Title.Name = "Title";
            Title.ReadOnly = true;
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Price.FillWeight = 63.45178F;
            Price.HeaderText = "Ár";
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // BooksInCategoryListBox
            // 
            BooksInCategoryListBox.FormattingEnabled = true;
            BooksInCategoryListBox.ItemHeight = 15;
            BooksInCategoryListBox.Location = new Point(426, 188);
            BooksInCategoryListBox.Name = "BooksInCategoryListBox";
            BooksInCategoryListBox.Size = new Size(362, 199);
            BooksInCategoryListBox.TabIndex = 1;
            // 
            // BookCountLabel
            // 
            BookCountLabel.AutoSize = true;
            BookCountLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BookCountLabel.Location = new Point(12, 145);
            BookCountLabel.Name = "BookCountLabel";
            BookCountLabel.Size = new Size(194, 21);
            BookCountLabel.TabIndex = 2;
            BookCountLabel.Text = "Az összes darabszám: 0 db";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(289, 15);
            label1.Name = "label1";
            label1.Size = new Size(200, 21);
            label1.TabIndex = 3;
            label1.Text = "Válasszon egy kategóriát";
            // 
            // CategorySelectComboBox
            // 
            CategorySelectComboBox.FormattingEnabled = true;
            CategorySelectComboBox.Location = new Point(276, 49);
            CategorySelectComboBox.Name = "CategorySelectComboBox";
            CategorySelectComboBox.Size = new Size(228, 23);
            CategorySelectComboBox.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Snow;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(276, 87);
            button1.Name = "button1";
            button1.Size = new Size(228, 23);
            button1.TabIndex = 5;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(CategorySelectComboBox);
            Controls.Add(label1);
            Controls.Add(BookCountLabel);
            Controls.Add(BooksInCategoryListBox);
            Controls.Add(PriciestBooksDataGrid);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Könyvek";
            ((System.ComponentModel.ISupportInitialize)PriciestBooksDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView PriciestBooksDataGrid;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Price;
        private ListBox BooksInCategoryListBox;
        private Label BookCountLabel;
        private Label label1;
        private ComboBox CategorySelectComboBox;
        private Button button1;
    }
}
