using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MyServiceTest
{
    [DataContract]
    public class Person
    {
        [DataMember]
        public string Name { get; set; }
    }
}
