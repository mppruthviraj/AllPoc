using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MyServiceTest
{
    [ServiceContract]
    public interface IMyMathService
    {
        [OperationContract]
        double Add(double dblNum1, double dblNum2);
        [OperationContract]
        double Subtract(double dblNum1, double dblNum2);
        [OperationContract]
        double Multiply(double dblNum1, double dblNum2);
        [OperationContract]
        double Divide(double dblNum1, double dblNum2);

        [OperationContract]
        string GreetMe(Person person);
    }  
}
