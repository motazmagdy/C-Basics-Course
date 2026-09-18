namespace Basics
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            #region Solution of Question 1 
            object newBook = new Book();
            Console.WriteLine($"Book , {newBook}");
            #endregion
        }
    }


    #region Creating (Book) Class 
    class Book
    {
        string Title ;
        int Pages ;
    }

    #endregion 
}
