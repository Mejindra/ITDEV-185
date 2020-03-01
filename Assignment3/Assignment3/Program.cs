using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
         public class MainClass
         {
            public static void Main()
            {
                bool Equal = Calculator.AreEqual<string >("A", "A");
                {
                    if (Equal)
                    {
                        Console.WriteLine("Equal");
                    }
                    else
                    {
                        Console.WriteLine("Not Equal");
                    }
                    Console.WriteLine("Press Enter to exit..........");
                    Console.ReadKey();
                }
            }
         }
        public class Calculator
        {
            public static bool AreEqual<T>(T value1, T value2)
            {
                return value1.Equals(value2);
            }

        }
        
    }
}
