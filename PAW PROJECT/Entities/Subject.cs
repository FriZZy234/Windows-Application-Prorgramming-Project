using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAW_PROJECT.Entities
{
    internal class Subject
    {
        public int teacherID { get; set; }
        public string subject { get; set; }
        public int subjectID { get; set; }
        public string teacher { get; set; }
        public Subject()
        {

        }
        public Subject(int teacherID, string subject, int subjectID,string Teacher)
        {
            this.teacherID = teacherID;
            this.subject = subject;
            this.subjectID = subjectID;
            teacher = Teacher;
        }
    }
}
