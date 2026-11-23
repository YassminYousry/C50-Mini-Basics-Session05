namespace session05
{
    class Book
    {
        private string password = "secret";
        internal int copiesInStock = 5;
    }  

    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();

            #region Q01
            //Console.WriteLine(book.password); 
            // Error  ..  'Book.password' is inaccessible due to its protection level
            #endregion

            #region Q02
            Console.WriteLine(book.copiesInStock); // 5
            //The internal access modifier allows access from any code within the same project
            #endregion
        }
    }
}
