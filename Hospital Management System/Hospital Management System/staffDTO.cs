using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospital_Management_System
{
    class staffDTO
    {
        int staffId;
        string name, gender, age, roomNo, phone, salary;

        public staffDTO(string name, string gender, string age, string roomNo, string phone, string salary)
        {
            // TODO: Complete member initialization
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.roomNo = roomNo;
            this.phone = phone;
            this.salary = salary;
        }

        public staffDTO(int staffId, string name, string gender, string age, string roomNo, string phone, string salary)
        {
            // TODO: Complete member initialization
            this.staffId = staffId;
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.roomNo = roomNo;
            this.phone = phone;
            this.salary = salary;
        }

        public int StaffId
        {
            get { return staffId; }
            set { staffId = value; }
        }
        

        public string Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string RoomNo
        {
            get { return roomNo; }
            set { roomNo = value; }
        }

        public string Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
