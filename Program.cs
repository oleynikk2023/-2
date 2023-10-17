using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛАБА2
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
            Address sv = new Address();

           
            sv.Index = 61000;
            sv.Country = "Ukraine";
            sv.City = "Kharkiv";
            sv.Street = "Klimovsky";
            sv.House = "12";
             

            
            Console.Out.WriteLine("Index; " + sv.Index);
            Console.Out.WriteLine("Cointry: " + sv.Country);

             Address sv = new Address();

             sv.Index =  61000;
            sv.Country = "Ukraine";
            sv.City = "Kharkiv";
            sv.Street = "Klimovsky";
            sv.House = "12";
             

             Console.Out.WriteLine("Index: " + sv.Index);
            Console.Out.WriteLine("Country: " + sv.Country);
            Console.Out.WriteLine("City: " + sv.City);
            Console.Out.WriteLine("Street: " + sv.Street);
            Console.Out.WriteLine("House: " + sv.House);
            Console.Out.WriteLine("Apartment: " + sv.Apartment);






        }
        static void Task2()
        {
             Converter svn = new Converter(36.96, 38.79, 8.37);
            Console.WriteLine("What do you want to do?);


                string user_selection = Console.ReadLine();
            int selection = Convert.ToInt16(user_selection);





        }
        static void Task4()
        {
             User user = new User("User", "Yana", "Oliinyk", 18);
             user.Output();
        }

    }
}
        }
    }
}
