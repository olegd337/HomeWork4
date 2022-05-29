namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var reader1 = new Reader();
            reader1.FIO = "vasya";
            var book1 = new Book();
            book1.authorName = "autor 1";
            book1.bookName = "book name 1";
            var book2 = new Book();
            book2.authorName = "author 2";
            book2.bookName = "book name 2";
            reader1.takeBook(book1, book2);
        }
    }
}