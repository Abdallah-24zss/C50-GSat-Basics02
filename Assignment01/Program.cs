namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1

            // 1- Create a Book class with a Title (string) and Pages (int).
            // Create a Book object and store it in a variable of type object. Print it.

            object firstBook = new Book
            {
                Title = "C# Basics",
                Pages = 464
            };

            Console.WriteLine(firstBook);

            #endregion
        }

    }
    class Book
    {
        public string Title;
        public int Pages;
    }
}