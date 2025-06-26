using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cyber_School
{
    public enum Building
    {
        BuildingA = 1,
        BuildingB = 2,
        BuildingC = 3
    }
    public class Classroom : Validation
    {
        public int RoomId { get; private set; }
        public Building Building { get; private set; }
        public int SeatCount { get; private set; }

        public void Register()
        {
            System.Console.WriteLine("\nNew Classroom registration: ");
            RoomId = IntCheck("Enter is the classroom id:");
            Building = EnumCheck<Building>("Enter the Building in which the classroom is in:\n1.BuildingA\n2.BuildingB\n3.BuildingC");
            SeatCount = IntCheck("Enter how many seat are in the classroom:");
        }

        public void classroomPrint()
        {
            Console.WriteLine($"RoomId:{RoomId}\nBuilding:{Building}\nSeatCount:{SeatCount}");
        }

    }
}