using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethodImplementation
{

    class Program
    {
        public class TestClass2
        {

            public int w { get; set; }
            public int z { get; set; }
        }

        public class TestClass
        {
            public int x { get; set; }

            public TestClass2 testClassOneMore { get; set; }
            public int y { get; set; }

        }
        public static void Main(string[] args)
        {
            TestClass tc1 = new TestClass();
            tc1.x = 2;
            tc1.y = 2;
            TestClass2 testClass2 = new TestClass2();
            testClass2.w = 7;
            testClass2.z = 7;
            tc1.testClassOneMore = testClass2;



            TestClass tc2 = new TestClass();
            tc2.x = 2;
            tc2.y = 2;
            TestClass2 testClass3 = new TestClass2();
            testClass3.w = 7;
            testClass3.z = 7;
            tc2.testClassOneMore = testClass3;

            object result = tc1.CompareEquals(tc2);
        }
    }
}
