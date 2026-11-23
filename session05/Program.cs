namespace session05
{
    enum Genre
    {
        Fiction,
        NonFiction,
        Science
    }
    class Book
    {
        private string password = "secret";
        internal int copiesInStock = 5;
        public string Title;
        public Genre Genre;
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
            //Console.WriteLine(book.copiesInStock); // 5
            //The internal access modifier allows access from any code within the same project
            #endregion

            #region Q03
            //book.Title = ".NET";
            //Console.WriteLine($"{book.Title}");  //.NET
            #endregion

            #region Q04
            //book.Genre = Genre.Science;
            //Console.WriteLine($"{book.Genre}");  //Science
            #endregion

            #region Q05
            //Console.WriteLine($"Fiction = {(int)Genre.Fiction}"); //0
            //Console.WriteLine($"NonFiction = {(int)Genre.NonFiction}"); //1
            //Console.WriteLine($"Science = {(int)Genre.Science}"); //2
            #endregion

            #region Q06
            //int genreNumber = 1;
            //Genre genre = (Genre)genreNumber;
            //Console.WriteLine($"Genre after Casting: {genre}");  //NonFiction
            #endregion

            #region Q07
            //Genre genre = Genre.Fiction;
            //string genreText = genre.ToString();
            //Console.WriteLine($"Genre after Converting: {genreText}"); //
            #endregion

            #region Q08
            //string genreText = "Science";
            //Genre genre = Enum.Parse<Genre>(genreText);
            //Console.WriteLine($"Genre after Converting: {genre}");
            #endregion

            #region Q09
            string genreText = "Mystery";

            if (Enum.TryParse<Genre>(genreText, out Genre genre))
            {
                Console.WriteLine($"Genre: {genre}");
            }
            else
            {
                Console.WriteLine("Unknown genre");
            }
            #endregion
        }
    }
}
