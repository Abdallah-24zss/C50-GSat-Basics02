namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            object firstBook = new Book
            {
                Title = "C# Basics",
                Pages = 464
            };


            Console.WriteLine(firstBook);
            Console.WriteLine(firstBook.ToString());
            Console.WriteLine(firstBook.Equals(firstBook));
            Console.WriteLine(firstBook.GetHashCode());
            Console.WriteLine(firstBook.GetType());

            

            int Pages = 464;
            // Compile-Time Error 

           


            try
            {
                int num = 10;
                int zero = 0;
                int result = num / zero;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("Done");
            }



           
            int pages = 300;
            double newPages = pages;

            
            double price = 49.99;
            int newPrice = (int)price;

           
            string pagesText = "464";
            int convertedPages = Convert.ToInt32(pagesText);

           
            string yearText = "2023";
            int year = int.Parse(yearText);

            string badText = "abc";
            int number;


            if (int.TryParse(badText, out number))
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Invalid number");
            }


            int pages2 = 464;
            string textPages = pages2.ToString();
            Console.WriteLine(textPages.GetType());


            int copies = 100;
            object boxed = copies;
            int unboxed = (int)boxed;
            Console.WriteLine(boxed);
            Console.WriteLine(unboxed);
        }
    }

    class Book
    {
        public string Title;
        public int Pages;
    }
}