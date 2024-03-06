using System.Diagnostics;
using System.Globalization;

namespace Big_Mamma_Pizzaria
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("skriv lige dit nav: ");
            string name = Console.ReadLine();
            Console.Write("skriv lige dit mobil nr:  ");
            int mobilNr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hej " + name + " Welcome to Big Mamma Pizzaria");
            Console.Write("vægler lige din ønsker: ");
            int PizzaNr = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("du har væglt nr" +PizzaNr+ "på menuen");

             

           Store store1 = new Store();
           store1.Start();
           Console.WriteLine(store1.ToString());







           



            
            Console.ReadLine();

            Console.ReadKey();
        }
       




           
           
        }
    }

