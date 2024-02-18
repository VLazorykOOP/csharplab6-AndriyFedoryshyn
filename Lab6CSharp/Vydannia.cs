using System;

// Інтерфейс Видання
interface IVydannia
{
    void DisplayInfo(); // виведення інформації про видання
    bool IsAuthor(string authorLastName); // перевірка, чи є автор з заданим прізвищем
}

// Клас Книга
class Book : IVydannia
{
    public string Title { get; set; }
    public string AuthorLastName { get; set; }
    public int Year { get; set; }
    public string Publisher { get; set; }

    public Book(string title, string authorLastName, int year, string publisher)
    {
        Title = title;
        AuthorLastName = authorLastName;
        Year = year;
        Publisher = publisher;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Book: {Title}, Author: {AuthorLastName}, Year: {Year}, Publisher: {Publisher}");
    }

    public bool IsAuthor(string authorLastName)
    {
        return AuthorLastName == authorLastName;
    }
}

// Клас Стаття
class Article : IVydannia
{
    public string Title { get; set; }
    public string AuthorLastName { get; set; }
    public string JournalName { get; set; }
    public int JournalNumber { get; set; }
    public int Year { get; set; }

    public Article(string title, string authorLastName, string journalName, int journalNumber, int year)
    {
        Title = title;
        AuthorLastName = authorLastName;
        JournalName = journalName;
        JournalNumber = journalNumber;
        Year = year;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Article: {Title}, Author: {AuthorLastName}, Journal: {JournalName}, Journal num: {JournalNumber}, Year: {Year}");
    }

    public bool IsAuthor(string authorLastName)
    {
        return AuthorLastName == authorLastName;
    }
}

// Клас Електронний ресурс
class ElectronicResource : IVydannia
{
    public string Title { get; set; }
    public string AuthorLastName { get; set; }
    public string Link { get; set; }
    public string Annotation { get; set; }

    public ElectronicResource(string title, string authorLastName, string link, string annotation)
    {
        Title = title;
        AuthorLastName = authorLastName;
        Link = link;
        Annotation = annotation;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"ElectronicResource: {Title}, Author: {AuthorLastName}, Link: {Link}, Annotation: {Annotation}");
    }

    public bool IsAuthor(string authorLastName)
    {
        return AuthorLastName == authorLastName;
    }
}

