namespace Basics
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            #region Solution of Question 1 
            object newBook = new Book();
            Console.WriteLine(newBook);
            #endregion
        }
    }


    class Book
    {
        string Title ;
        int Pages ;
    }

}
