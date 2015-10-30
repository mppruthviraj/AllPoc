using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    class Program
    {
        public static void Main(string[] args)
        {
            SampleClass smpClass = new SampleClass();
            SingleDelegate delegateEx = SampleClass.Add;
            delegateEx += SampleClass.Mul;
            delegateEx += SampleClass.Sub;
            delegateEx(10,12);
            Console.ReadLine();

        }
    }
}
