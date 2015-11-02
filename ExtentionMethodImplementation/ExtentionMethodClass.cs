using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethodImplementation
{
     public static class ExtentionMethodClass
    {
         public static object CompareEquals<T>(this T data, T data2)
         {

             PropertyInfo[] props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
             foreach (PropertyInfo prop in props)
             {
                 object dataFromCompare = data.GetType().GetProperty(prop.Name).GetValue(data, null);
                 object dataToCompare = data2.GetType().GetProperty(prop.Name).GetValue(data2, null);
                 Type type = data.GetType().GetProperty(prop.Name).GetValue(data2, null).GetType();
                 if (prop.PropertyType.IsClass)
                 {
                     dynamic convertedFromValue = Convert.ChangeType(dataFromCompare, type);
                     dynamic convertedToValue = Convert.ChangeType(dataToCompare, type);

                     object result = ExtentionMethodClass.CompareEquals(convertedFromValue, convertedToValue);
                     bool convertedResult = (bool)result;
                     if (!convertedResult)
                         return false;
                 }


                 else if (!dataFromCompare.Equals(dataToCompare))
                     return false;
             }

             return true;
         }
    }
}
