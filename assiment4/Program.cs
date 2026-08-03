using System.Runtime.InteropServices;

namespace assiment4
{
    internal class Program
    {
        static void print (string ss)
        {
            Console.WriteLine(ss);
        }
        static void PrintBookTitle(string title)
        {
            Console.WriteLine("Book title: " + title);
        }
        static void AddBonusPages(int pages)
        {
            pages += 50;
            Console.WriteLine(pages);
        }
        static void ApplyDiscount(double[] prices)
        {
            prices[0] -= 5;
            Console.WriteLine(prices[0]);
        }
        static void AddBonusPagesByRef(ref int pages)
        {
            pages += 50;
            Console.WriteLine(pages);

        }
        static void ReplaceArray(ref double[] prices)
        {
            prices = new double[] { 10.0, 12.5, 15.0 };
            Console.WriteLine(prices.Length);

        }
        static bool TryGetPrice(string title, out double price)
        {
            if (title == "Clean Code")
            {
                price = 25.5;
                return true;
            }
            else
            {
                price = 0;
                return false;
            }
        }

            /*  static void PrintBookInfo(string title, int pages = 300)
              {
                  Console.WriteLine("Title: " + title + ", Pages: " + pages);
              }*/
            static void book(string[] args)
            {
                PrintBookInfo(pages: 464, title: "Clean Code");
            }

        private static void PrintBookInfo(int pages, string title)
        {
            throw new NotImplementedException();
        }
        /* static void PrintBookInfo(string title, int pages = 300)
         {
             Console.WriteLine("Title: " + title + ", Pages: " + pages);
         }*/
        static void PrintAllTitles(params string[] titles)
        {
            foreach (string title in titles)
            {
                Console.WriteLine(title);
            }
        }
        
        static void Main(string[] args)
        {
            /*  double[] prices =
              {
                   25.5,
                  40.0, 
                  33.75
              };
              Console.WriteLine(prices[1]);
            */
            /* int[,]arr  =
   {
                   { 3, 5 },
                   { 1, 4 }
               }
               ;
               Console.WriteLine(arr[1, 0]);*/
            // print("Welcome to the Library!");
            // PrintBookTitle("Clean Code");
            // int pages = 400;
            // AddBonusPages(pages);
            /* double[] prices =
             {
                  25.5,
                 40.0
             };
             ApplyDiscount(prices);*/

            /* int pages = 400;
             AddBonusPagesByRef(ref pages);*/


            /* double[] prices = { 25.5, 40.0 };

             ReplaceArray(ref prices);*/
            /* double price;

             if (TryGetPrice("Clean Code", out price))
             {
                 Console.WriteLine("Price: " + price);
             }
             else
             {
                 Console.WriteLine("Book not found");
             }*/

            // PrintBookInfo("Clean Code");
            // PrintBookInfo("Refactoring", 464);
            // PrintBookInfo(pages: 464, title: "Clean Code");
            PrintAllTitles("Clean Code", "The Pragmatic Programmer", "Refactoring");


        }
    }
}
