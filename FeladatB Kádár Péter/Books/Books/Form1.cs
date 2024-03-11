using Konyvesbolt;
using Konyvesbolt.Models;

namespace Books {
    public partial class Form1 : Form {

        public Bookshelf Bookshelf { get; set; } = new Bookshelf();

        public Form1() {
            InitializeComponent();
            BookCountLabel.Text = $"Az összes darabszám: {Bookshelf.TotalStock} db";
            CategorySelectComboBox.Items.AddRange(Bookshelf.Categories.ToArray());
            foreach(Book book in Bookshelf.GetHighestPricedBooks()) {
                PriciestBooksDataGrid.Rows.Add(book.Kategoria, book.Konyv, book.Ar);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            string selected = CategorySelectComboBox.GetItemText(CategorySelectComboBox.SelectedItem);
            BooksInCategoryListBox.Items.Clear();
            BooksInCategoryListBox.Items.AddRange(Bookshelf.GetByCategoryFormatted(selected).ToArray());
        }
    }
}
