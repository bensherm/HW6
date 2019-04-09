using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
    {
        class Program
        {
            static void Main(string[] args)
            {

           
            string userinput;
            

            do
            {

                Console.Write("Enter a Temp Value or Exit:");
                userinput = Console.ReadLine();
                int cels;
                int fahr;
               
                if (userinput == "exit")
                {
                    continue;
                }
                
                    Console.WriteLine("Fahrenheit or Celsius?");
                    userinput = Console.ReadLine();

                    if (userinput == "Fahrenheit")
                    {
                        cels = int.Parse(Console.ReadLine());
                        fahr = (cels * 9) / 5 + 32;
                        Console.WriteLine("Temperature in Fahrenheit is(°F) : " + fahr);

                        Console.ReadLine();
                    }

                    else if (userinput == "Celsius")
                    {
                        fahr = int.Parse(Console.ReadLine());
                        cels = ((fahr - 32) * 5 / 9);
                        Console.WriteLine("Temperature in Celsius is(°C) : " + cels);
                        Console.ReadLine();
                    }
            } while (true);
        }
    }
}



