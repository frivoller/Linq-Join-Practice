using System;
using System.Collections.Generic;
using System.Linq;

public class Author
{
    public int AuthorId { get; set; }
    public string Name { get; set; }
}

public class Book
{
    public int BookId { get; set; }
    public string Title { get; set; }
    public int AuthorId { get; set; }
}

public class LibrarySystem
{
    public static void Main()
    {
        // Yazarlar tablosu için örnek veriler
        List<Author> authors = new List<Author>
        {
            new Author { AuthorId = 1, Name = "Ahmet Hamdi Tanpınar" },
            new Author { AuthorId = 2, Name = "Orhan Pamuk" },
            new Author { AuthorId = 3, Name = "Elif Şafak" }
        };

        // Kitaplar tablosu için örnek veriler
        List<Book> books = new List<Book>
        {
            new Book { BookId = 1, Title = "Saatleri Ayarlama Enstitüsü", AuthorId = 1 },
            new Book { BookId = 2, Title = "Masumiyet Müzesi", AuthorId = 2 },
            new Book { BookId = 3, Title = "Aşk", AuthorId = 3 },
            new Book { BookId = 4, Title = "Kara Kitap", AuthorId = 2 }
        };

        // LINQ sorgusu ile kitap ve yazar bilgilerini birleştirme
        var query = from book in books
                    join author in authors on book.AuthorId equals author.AuthorId
                    select new { BookTitle = book.Title, AuthorName = author.Name };

        // Sonuçları ekrana yazdırma
        Console.WriteLine("Kitap Başlığı - Yazar Adı");
        Console.WriteLine("----------------------------");
        foreach (var item in query)
        {
            Console.WriteLine($"{item.BookTitle} - {item.AuthorName}");
        }
        Console.ReadKey();
    }

}