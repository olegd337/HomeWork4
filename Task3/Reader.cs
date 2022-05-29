using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
 
    public class Reader
    {
        public string FIO;
        public int readerNumber;
        public string facultet;
        public string birthDate;
        public int phoneNumber;


        public void takeBook(int bookTaken)
        {
            Console.WriteLine($"{FIO} take {bookTaken} books");
        }
        public void takeBook(params string[] takenBooksName)
        {
            Console.Write($"{FIO} take books: ");
            foreach (var item in takenBooksName)
            {
                Console.Write($"'{item}' ");
            }
        }
        public void takeBook(params Book[] takenBooks)
        {
            foreach (var item in takenBooks)
            {
                Console.WriteLine($"{FIO} take book '{item.bookName}' by autor '{item.authorName}'");
            }
        }

        public void returnBook(int retrunBooks)
        {
            Console.WriteLine($"{FIO} return '{retrunBooks}' books");
        }
        public void returnBook(params string[] retrunBooksName)
        {
            Console.Write($"{FIO} take books: ");
            foreach (var item in retrunBooksName)
            {
                Console.Write($"'{item}' ");
            }
        }
    }
}
