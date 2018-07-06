using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospital_Management_System
{
    public class checkoutData
    {
        private int roomBill, medicineBill, serviceBill, testBill, subTotal, vat, total;
        private string name, gender, age, address, phone;

        public checkoutData(int roomBill, int medicineBill, int serviceBill, int testBill, int subTotal, int vat, int total, string name, string gender, string age, string address, string phone)
        {
            // TODO: Complete member initialization
            this.roomBill = roomBill;
            this.medicineBill = medicineBill;
            this.serviceBill = serviceBill;
            this.testBill = testBill;
            this.subTotal = subTotal;
            this.vat = vat;
            this.total = total;
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.address = address;
            this.phone = phone;
        }

        public int Total
        {
            get { return total; }
            set { total = value; }
        }

        public int Vat
        {
            get { return vat; }
            set { vat = value; }
        }

        public int SubTotal
        {
            get { return subTotal; }
            set { subTotal = value; }
        }

        public int TestBill
        {
            get { return testBill; }
            set { testBill = value; }
        }

        public int ServiceBill
        {
            get { return serviceBill; }
            set { serviceBill = value; }
        }

        public int MedicineBill
        {
            get { return medicineBill; }
            set { medicineBill = value; }
        }

        public int RoomBill
        {
            get { return roomBill; }
            set { roomBill = value; }
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
