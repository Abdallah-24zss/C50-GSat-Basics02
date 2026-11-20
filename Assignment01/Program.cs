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
            int pages = 464;

            #endregion
        }

    }
    class Book
    {
        public string Title;
        public int Pages;
    }
}