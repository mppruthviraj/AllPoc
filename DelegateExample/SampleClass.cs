using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    public delegate void SingleDelegate(int a, int b);
    public class SampleClass
    {
        public static void Add(int x, int y)
        {
            Console.WriteLine("Addition Value: " + (x + y));
        }
        public static void Sub(int x, int y)
        {
            Console.WriteLine("Subtraction Value: " + (x - y));
        }
        public static void Mul(int x, int y)
        {
            Console.WriteLine("Multiply Value: " + (x * y));
        }
    }
}
