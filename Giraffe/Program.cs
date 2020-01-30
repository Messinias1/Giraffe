using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            // Object Methods
            Student student1 = new Student("Carl", "Software Engineer", 3.5);
            Student student2 = new Student("Bob", "Teacher", 3.1);

            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());

            // Classes and Objects
            Book book1 = new Book("Harry Potter", "JK Rowling", 400);
            Book book2 = new Book("The Lord Of The Rings", "JRR Tolkien", 700);
            book2.title = "The Hobbit";

            Book book3 = new Book();
            book3.title = "Heavier Than Heaven";
            book3.author = "Charles R Cross";
            book3.pages = 393;

            Console.WriteLine(book2.title);
            Console.WriteLine(book3.pages);
        }
    }
}
