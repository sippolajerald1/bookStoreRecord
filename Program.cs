using System;
namespace recordDemo
{
    class Program
    {
        public record Bookstore(int ID, string Title, string Author, double Price);

        public static void Main()
        {
            Bookstore book = new(1, "Call of the Wild", "Jack London", 20.00);
            Console.WriteLine(book);
            Bookstore book1 = new(2, "White Fang", "Jack London", 20.00);
            Console.WriteLine(book1);
            Bookstore book2 = new(3, "Conagher", "Louis LaMoore", 15.00);
            Console.WriteLine(book2);
        }
    }
}
