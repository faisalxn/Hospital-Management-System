using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospital_Management_System
{
    class testDTO
    {
        int testId, price;
        string name, category, roomNo;

        public testDTO(string name, string category, string roomNo, int price)
        {
            // TODO: Complete member initialization
            this.name = name;
            this.category = category;
            this.roomNo = roomNo;
            this.price = price;
        }

        public testDTO(int testId, string name, string category, string roomNo, int price)
        {
            // TODO: Complete member initialization
            this.testId = testId;
            this.name = name;
            this.category = category;
            this.roomNo = roomNo;
            this.price = price;
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public int TestId
        {
            get { return testId; }
            set { testId = value; }
        }
        

        public string RoomNo
        {
            get { return roomNo; }
            set { roomNo = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
