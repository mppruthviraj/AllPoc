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
         /// <summary>
         /// Method to compare two objects of same class
         /// </summary>
         /// <typeparam name="T"></typeparam>
         /// <param name="objectFromCompare"></param>
         /// <param name="objectToCompare"></param>
         /// <returns></returns>
         public static object CompareEquals<T>(this T objectFromCompare, T objectToCompare)//Generic method
         {
             //Gets all the properties of the class
             PropertyInfo[] props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
             foreach (PropertyInfo prop in props)
             {
                 object dataFromCompare = objectFromCompare.GetType().GetProperty(prop.Name).GetValue(objectFromCompare, null);
                 object dataToCompare = objectToCompare.GetType().GetProperty(prop.Name).GetValue(objectToCompare, null);
                 Type type = objectFromCompare.GetType().GetProperty(prop.Name).GetValue(objectToCompare, null).GetType();
                 if (prop.PropertyType.IsClass)
                 {
                     dynamic convertedFromValue = Convert.ChangeType(dataFromCompare, type);
                     dynamic convertedToValue = Convert.ChangeType(dataToCompare, type);

                     object result = ExtentionMethodClass.CompareEquals(convertedFromValue, convertedToValue);

                     bool compareResult = (bool)result;
                     if (!compareResult)
                         return false;
                 }


                 else if (!dataFromCompare.Equals(dataToCompare))
                     return false;
             }

             return true;
         }
    }
}
