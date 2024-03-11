namespace Konyvesbolt.Models {

    public class Book {

        public int Sorszam { get; set; } = 0;
        public string Kategoria { get; set; } = string.Empty;
        public string Konyv { get; set; } = string.Empty;
        public int Ar { get; set; } = 0;
        public int Db { get; set; } = 0;

        public Book(string sorszam, string kategoria, string konyv, string ar, string db) {
            Sorszam = int.TryParse(sorszam, out int parsedSorszam) ? parsedSorszam : Sorszam;
            Kategoria = kategoria;
            Konyv = konyv;
            Ar = int.TryParse(ar, out int parsedAr) ? parsedAr : Ar;
            Db = int.TryParse(db, out int parsedDb) ? parsedDb : Db;
        }

        public Book(int sorszam, string kategoria, string konyv, int ar, int db) {
            Sorszam = sorszam;
            Kategoria = kategoria;
            Konyv = konyv;
            Ar = ar;
            Db = db;
        }

        public Book(string? line) {
            if(line == null) {
                return;
            }
            string[] parameters = line.Split(',');
            if(parameters.Length < 5) {
                throw new Exception($"Invalid book paramter line: {line}");
            }
            Sorszam = int.TryParse(parameters[0], out int parsedSorszam) ? parsedSorszam : Sorszam;
            Kategoria = parameters[1];
            Konyv = parameters[2];
            Ar = int.TryParse(parameters[3], out int parsedAr) ? parsedAr : Ar;
            Db = int.TryParse(parameters[4], out int parsedDb) ? parsedDb : Db;
        }

        public override string ToString() {
            return $"Cím: {Konyv}, Ár: {Ar}, Darabszám: {Db}";
        }

    }
}
