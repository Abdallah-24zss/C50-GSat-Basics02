namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1

            //// 1- Create a Book class with a Title (string) and Pages (int).
            //// Create a Book object and store it in a variable of type object. Print it.

            object firstBook = new Book
            {
                Title = "C# Basics",
                Pages = 464
            };

            //Console.WriteLine(firstBook);

            #endregion

            #region Question 2

            // 2- Using the Book class above, print the result of
            // ToString(), Equals() (compare book with itself),
            // GetHashCode(), and GetType() on book.

            //Console.WriteLine(firstBook.ToString());
            //Console.WriteLine(firstBook.Equals(firstBook));
            //Console.WriteLine(firstBook.GetHashCode());
            //Console.WriteLine(firstBook.GetType());

            #endregion

            #region Question 3

            // 3- Look at the line below. Is it a compile-time error,
            // a runtime error, or a logical error? Fix it.
            // int pages = "464";

            // Compile-Time Error
            // int pages = 464;

            #endregion

            #region Question 4

            // 4- Write code that divides 10 by 0 inside a try block,
            // catches the exception, prints "Cannot divide by zero",
            // and then prints "Done" in a finally block.

            //try
            //{
            //    int num = 10;
            //    int zero = 0;
            //    int result = num / zero;
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Cannot divide by zero");
            //}
            //finally
            //{
            //    Console.WriteLine("Done");
            //}

            #endregion

            #region Question 5

            // 5- Declare an int pages = 300; then store it in a
            // double variable without using a cast.

            //int pages = 300;
            //double newPages = pages;

            #endregion

            #region Question 6

            // 6- Declare double price = 49.99;
            // convert it to int using explicit casting.

            //double price = 49.99;
            //int newPrice = (int)price;

            #endregion

            #region Question 7

            // 7- Convert string pagesText = "464" into an int
            // using the Convert class.

            //string pagesText = "464";
            //int convertedPages = Convert.ToInt32(pagesText);

            #endregion

            #region Question 8

            // 8- Convert yearText = "2023" using int.Parse().
            // Use int.TryParse() for badText = "abc".
            // Print "Invalid number" if it fails.

            //string yearText = "2023";
            //int year = int.Parse(yearText);

            //string badText = "abc";
            //int number;

            //if (int.TryParse(badText, out number))
            //{
            //    Console.WriteLine(number);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid number");
            //}

            #endregion

            #region Question 9

            // 9- Convert int pages = 464 into a string using ToString().
            // Print its type using GetType().

            //int pages2 = 464;
            //string textPages = pages2.ToString();
            //Console.WriteLine(textPages.GetType());

            #endregion

            #region Question 10

            // 10- Declare int copies = 100.
            // Box it into an object, then unbox it into an int.
            // Print both values.

            int copies = 100;
            object boxed = copies;
            int unboxed = (int)boxed;

            Console.WriteLine(boxed);
            Console.WriteLine(unboxed);

            #endregion
        }

    }
    class Book
    {
        public string Title;
        public int Pages;
    }
}