namespace session05
{
    class Book
    {
        private string password = "secret";
    }  

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            Book book = new Book();

            Console.WriteLine(book.password); // Error  ..  'Book.password' is inaccessible due to its protection level
            #endregion
        }
    }
}
