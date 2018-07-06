using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospital_Management_System
{
    class patientDTO
    {
        private int patientId, doctorId, testId;
        private string name, gender,roomNo, age, address, phone, checkinDate;


        public patientDTO(int patientId , string name, string gender, string age, string address, string phone, string roomNo, int doctorId, int testId, string checkinDate)
        {
            // TODO: Complete member initialization
            this.patientId = patientId ;
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.address = address;
            this.phone = phone;
            this.roomNo = roomNo;
            this.doctorId = doctorId;
            this.testId = testId;
            this.checkinDate = checkinDate;
        }


        public patientDTO(string name, string gender, string age, string address, string phone, string roomNo, int doctorId, int testId, string checkinDate)
        {
            // TODO: Complete member initialization
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.address = address;
            this.phone = phone;
            this.roomNo = roomNo;
            this.doctorId = doctorId;
            this.testId = testId;
            this.checkinDate = checkinDate;
        }


        public int TestId
        {
            get { return testId; }
            set { testId = value; }
        }

        public int DoctorId
        {
            get { return doctorId; }
            set { doctorId = value; }
        }

        public string RoomNo
        {
            get { return roomNo; }
            set { roomNo = value; }
        }

        public int PatientId
        {
            get { return patientId; }
            set { patientId = value; }
        }
        

        public string CheckinDate
        {
            get { return checkinDate; }
            set { checkinDate = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
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
