using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    public class InheritAbstractClass:AbstractExampple
    {
        public string publicValue1 { get; set; }

        private string privateValue2 { get; set; }

        protected string protectedValue3 { get; set; }

        public string IsExposedToOutsidePublic()
        {
            publicValue1 = "public method from inherited class(Child)";

            return "public method from inherited class(Child)";
        }

        private string IsExposedToOutsidePrivate()
        {
            privateValue2 = "private method from inherited class(Child)";
            return "private method from inherited class(Child)";
        }

        protected string IsExposedToOutsideProtected()
        {
            protectedValue3 = "protected method from inherited class(Child)";
            return "protected method from inherited class(Child)";
        }

        public override string AbstractMethodWithImplementation()
        {
            return "Abstract Method With Implemntationd(Child)";
        }
    }
}
