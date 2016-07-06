using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace StudentService
{
    [DataContract]
    public class Student
    {
        [DataMember]
        public int StudID { get; set; }
        [DataMember]
        public string StudName { get; set; }
        [DataMember]
        public string StudGender { get; set; }
    }
}
