namespace session2
{
    class Book
    {
        public string title;
         public int pages;
    }
    internal class Program 
    {
        static void Main(string[] args)
        {
            //Book book = new Book();


            /*question 1
             book.title = "The Great Gatsby";
             book.pages = 180;

             Console.WriteLine(book.title);
             Console.WriteLine(book.pages);*/

            /*question2
                Console.WriteLine(book.ToString());
                Console.WriteLine(book.Equals(book)); 
                Console.WriteLine(book.GetHashCode());
                Console.WriteLine(book.GetType());*/


            /*question 3
             compile error
              int pages = 464;
                       */


            /*question 4

            try
            {
              int x = 0;
              int result = 10 / x;
            }
            catch(DivideByZeroException ex)
            {
              Console.WriteLine("Cannot divide by zero.");
            }
            finally
            {
              Console.WriteLine("Done");
            } */


            /*question 5
            int pages = 300;
            double number = pages;
                        */


            /*question 6
            double price = 49.99;
            int number = (int)price;
                         */


            /*question 7
            string PagesText = "464";
            int pages = Convert.ToInt32(PagesText);
            */


            /*question 8
            string YearText = "2023";
            int year = int.Parse(YearText);

            string BadText = "abc";
            if (int.TryParse(BadText, out int number))
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Invalid number");
            }*/



            /* question 9
            int pages = 464;
            string p = pages.ToString();
            Console.WriteLine(p);
            Console.WriteLine(p.GetType());
            */



            /* question 10
            int copies = 100;
            object obj = copies;
            int newCopies = (int)obj;
            Console.WriteLine(obj);
            Console.WriteLine(newCopies);
            */



            /*question 11
            int? year = null;
            Console.WriteLine(year.HasValue);
            year = 2023;
            Console.WriteLine(year.HasValue);
            Console.WriteLine(year.Value);
            */



            /*question 12
            string? reviewer = null;
            Console.WriteLine(reviewer == null);
            */


            /*question 13
            Book? book = null;
            string? title = book?.title;
            Console.WriteLine(title);*/

            /*question 14
            Book? book = null;
            string? title = book?.title;
            Console.WriteLine(title ?? "Untitled");
            title ??= "Untitled";
            Console.WriteLine(title);
            */

            /* question 15
            string? name = "Ahmed";
            string confirmedName = name!;
            Console.WriteLine(confirmedName);
            */




        }
    }
}
