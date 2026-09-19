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

            #region Solution of Question 2

            Console.WriteLine(newBook.ToString());
            Console.WriteLine(newBook.Equals(newBook));
            Console.WriteLine(newBook.GetHashCode());
            Console.WriteLine(newBook.GetType());

            #endregion
        }
    }

    class Book
    {
        public string Title;
        public int Pages;

        public override string ToString()
        {
            return $"Book Title: {Title}, Number of Pages: {Pages}";
        }

        public override bool Equals(object? obj)
        {
            Book anotherBook = (Book)obj;
            return this.Title == anotherBook.Title && this.Pages == anotherBook.Pages;
        }

    }
    
}
