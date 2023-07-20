using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAW_PROJECT.Entities
{
    internal class Room
    {
       public int roomID { get; set; }
        public int roomNO { get; set; }
        public bool availability { get; set; }
        public int subjectID { get; set; }  
        public Room()
        {

        }
        public Room(int roomID, int roomNO, bool availability, int subjectID)
        {
            this.roomID = roomID;
            this.roomNO = roomNO;
            this.availability = availability;
            this.subjectID = subjectID;
        }
    }
}
