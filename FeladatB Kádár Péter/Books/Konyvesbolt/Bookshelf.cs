using Konyvesbolt.Models;

namespace Konyvesbolt {
    public class Bookshelf {

        public List<Book> Books { get; set; } = new();
        public HashSet<string> Categories { get; set; } = new();
        public int TotalStock {
            get {
                return Books.Sum(book => book.Db);
            }
        }

        public Bookshelf(string source = @"books.txt") {
            if(!File.Exists(source)) {
                return;
            }
            StreamReader reader = new(source);
            while(!reader.EndOfStream) {
                Book book = new(reader.ReadLine());
                Categories.Add(book.Kategoria);
                Books.Add(book);
            }
            reader.Close();
        }

        public List<Book> GetHighestPricedBooks() {
            int highestPrice = Books.OrderByDescending(book => book.Ar).First().Ar;
            return Books.Where(book => book.Ar == highestPrice).ToList();
        }

        public List<Book> GetByCategory(string category) {
            if(!Categories.Contains(category)) {
                return new();
            }
            return Books.Where(book => book.Kategoria == category).ToList();
        }

        public List<string> GetByCategoryFormatted(string category) {
            List<string> result = new();
            return GetByCategory(category).Select(book => book.ToString()).ToList();
        }

    }
}
