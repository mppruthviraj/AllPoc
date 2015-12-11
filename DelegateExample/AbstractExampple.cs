using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    public abstract class AbstractExampple
    {

        public string publicValue1 { get; set; }

        private string privateValue2 { get; set; }

        protected string protectedValue3 { get; set; }

        public string IsExposedToOutsidePublic()
        {
            publicValue1 = "public method from abstract(Parent)";

            return "public method from abstract(Parent)";
        }

        private string IsExposedToOutsidePrivate()
        {
            privateValue2 = "private method from abstract(Parent)";
            return "private method from abstract(Parent)";
        }

        protected string IsExposedToOutsideProtected()
        {
            protectedValue3 = "protected method from abstract(Parent)";
            return "protected method from abstract(Parent)";
        }

        public abstract string AbstractMethodWithImplementation();
       
    }
}
