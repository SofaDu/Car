using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            Liftback S7 = new Liftback();
            S7.Mark = "Audi S7";
            S7.VinNumber = "12986498124";
            S7.Color = "White";
            S7.Doors = 5;
            S7.HorsePower = 450;
            S7.TimeTo100 = 4.6;

            Console.WriteLine(S7);
        }
    }
}
