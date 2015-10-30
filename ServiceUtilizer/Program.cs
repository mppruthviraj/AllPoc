using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ServiceUtilizer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MyMathServiceClient myMathServiceClient = new MyMathServiceClient("MathServcieConfig");
           

            var value = myMathServiceClient.Add(2,2);
            value++;
        }
    }
}
