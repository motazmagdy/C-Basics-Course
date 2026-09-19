namespace Basics
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            #region Solution of Question 1 

            Book newBook = new Book();
            Console.WriteLine(newBook);
            #endregion
        }
    }

    class Book
    {
        public string Title;
        public int Pages;

    }
    
}
