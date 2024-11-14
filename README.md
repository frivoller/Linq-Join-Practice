# Kütüphane Yönetim Sistemi / Library Management System

Bu proje, kitaplar ve yazarlar arasında ilişki kurarak basit bir kütüphane yönetim sistemi oluşturmayı amaçlamaktadır. Sistem, `Yazarlar` ve `Kitaplar` adında iki tablo içerir.

This project aims to create a simple library management system by establishing a relationship between books and authors. The system consists of two tables: `Authors` and `Books`.

## Özellikler / Features

- Yazarlar ve kitaplar için iki tablo tanımlanmıştır.
- LINQ sorguları kullanılarak kitap başlıkları ve yazar adları birleştirilir ve ekrana yazdırılır.
- Kolayca genişletilebilir ve geliştirilebilir yapıdadır.

- Two tables are defined for authors and books.
- Using LINQ queries, book titles and author names are combined and printed to the screen.
- Easily extendable and improvable structure.

## Tabloların Yapısı / Structure of Tables

### Yazarlar / Authors
- **AuthorId**: Yazarın benzersiz kimliği. (int)
- **Name**: Yazarın adı. (string)

- **AuthorId**: Unique identifier for the author. (int)
- **Name**: Name of the author. (string)

### Kitaplar / Books
- **BookId**: Kitabın benzersiz kimliği. (int)
- **Title**: Kitabın başlığı. (string)
- **AuthorId**: Kitabın yazarının kimliği. (Yazarlar tablosundaki AuthorId ile ilişkilidir)

- **BookId**: Unique identifier for the book. (int)
- **Title**: Title of the book. (string)
- **AuthorId**: Author ID of the book. (Linked with AuthorId in the Authors table)
