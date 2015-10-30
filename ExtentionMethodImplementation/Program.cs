using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethodImplementation
{
    public static class MyClass
    {
        public static object CompareEquals<T>(this T data, T data2)
        {

            PropertyInfo[] props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in props)
            {
                object dataFromCompare = data.GetType().GetProperty(prop.Name).GetValue(data, null);
                object dataToCompare = data2.GetType().GetProperty(prop.Name).GetValue(data2, null);
                Type type = data.GetType().GetProperty(prop.Name).GetValue(data2, null).GetType();
                int i = 0;
                if (prop.PropertyType.IsClass)
                {
                    ////Still to be coded
                    //Type typeToBeConverted = typeof(type);
                     Activator.CreateInstance(type);
                    TypeConverter typeConverter = TypeDescriptor.GetConverter(type);
                    object convertedFromValue = typeConverter.ConvertFrom(dataFromCompare);
                    object convertedToValue = typeConverter.ConvertFrom(dataToCompare);

                   object result = dataToCompare.CompareEquals(dataToCompare);
                   bool convertedResult = (bool)result;
                   if (!convertedResult)
                       return false;
                }


                if (!dataFromCompare.Equals(dataToCompare))
                    return false;
            }
            
            return true;
        }

    }
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
            public int y { get; set; }
            public TestClass2 testClassOneMore {get;set;}

        }
        public static void Main(string[] args)
        {
            TestClass tc1 = new TestClass();
            tc1.x = 2;
            tc1.y = 2;
            TestClass2 testClass2 = new TestClass2();
            testClass2.w = 8;
            testClass2.z = 7;
            tc1.testClassOneMore = testClass2;



            TestClass tc2 = new TestClass();
            tc2.x = 2;
            tc2.y = 2;
            TestClass2 testClass3 = new TestClass2();
            testClass3.w = 7;
            testClass3.z = 7;
            tc2.testClassOneMore = testClass3;



            tc1.CompareEquals(tc2);
        }
    }
}
