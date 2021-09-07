using System;

namespace Lesson7ConsoleApp {
    // Первое ДЗ
    class Rectangle {
        private double side1, side2;
        public double AreaCalculator() {
            return side1 * side2;
        }

        public double PerimeterCalculator() {
            return 2 * (side1 + side2);
        }

        public double Area {
            get {
                return AreaCalculator();
            }
        }

        public double Perimeter {
            get {
                return PerimeterCalculator();
            }
        }

        public Rectangle() {

        }

        public Rectangle(double side1, double side2) {
            this.side1 = side1;
            this.side2 = side2;
        }
    }
    class Program {
        static void Main() {
            Console.Write("Введите Side1: ");
            double.TryParse(Console.ReadLine(), out double a);

            Console.Write("Введите Side2: ");
            double.TryParse(Console.ReadLine(), out double b);

            Rectangle rec = new Rectangle(a, b);

            Console.WriteLine($ "Периметр: {rec.Perimeter}\nПлощадь: {rec.Area}");
        }
    }

    // Второе ДЗ
    class Title {
        public string TheTitle {
            get;
            set;
        }
        public void Show() {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($ "Title: {TheTitle}");
            Console.ResetColor();
        }
    }

    class Author {
        public string TheAuthor {
            get;
            set;
        }
        public void Show() {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($ "Author: {TheAuthor}");
            Console.ResetColor();
        }
    }

    class Content {
        public string TheContent {
            get;
            set;
        }
        public void Show() {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($ "Content: {TheContent}");
            Console.ResetColor();
        }
    }

    class Book {
        public Title title;
        public Author author;
        public Content content;

        public Book() {
            title = new Title();
            author = new Author();
            content = new Content();
        }
    }


    class Program {
        static void Main() {
            Console.Write("Введите заглавие: ");
            string title = Console.ReadLine();

            Console.Write("Введите автора: ");
            string author = Console.ReadLine();

            Console.Write("Введите содержимое книги в одну строку: ");
            string content = Console.ReadLine();

            Book book = new Book();
            book.title.TheTitle = title;
            book.author.TheAuthor = author;
            book.content.TheContent = content;

            book.title.Show();
            book.author.Show();
            book.content.Show();
        }
    }
}