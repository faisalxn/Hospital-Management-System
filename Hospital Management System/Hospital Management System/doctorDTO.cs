using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospital_Management_System
{
    class doctorDTO
    {
        private int doctorId;

        private string name, age, gender, degree, specialistIn, phone, salary;

        public doctorDTO(string name, string age, string gender, string degree, string specialistIn, string phone, string salary)
        {
            // TODO: Complete member initialization
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.degree = degree;
            this.specialistIn = specialistIn;
            this.phone = phone;
            this.salary = salary;
        }

        public doctorDTO(int doctorId, string name, string age, string gender, string degree, string specialistIn, string phone, string salary)
        {
            // TODO: Complete member initialization
            this.doctorId = doctorId;
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.degree = degree;
            this.specialistIn = specialistIn;
            this.phone = phone;
            this.salary = salary;
        }

        public int DoctorId
        {
            get { return doctorId; }
            set { doctorId = value; }
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

        public string SpecialistIn
        {
            get { return specialistIn; }
            set { specialistIn = value; }
        }

        public string Degree
        {
            get { return degree; }
            set { degree = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }



        
    }
}
