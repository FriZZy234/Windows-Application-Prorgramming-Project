using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAW_PROJECT.Entities
{
    public class Teacher
    {
        public string Name { get; set; }
        public int TeacherID { get; set; }
        public int PhoneNumber { get; set; }

        public Teacher() { }
        
        public Teacher(string name,int teacherID, int phoneNumber) {
            Name = name;
            TeacherID= teacherID;
            PhoneNumber = phoneNumber;
        }

    }
    
}
