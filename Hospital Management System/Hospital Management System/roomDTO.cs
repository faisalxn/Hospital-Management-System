using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospital_Management_System
{
    class roomDTO
    {
        private int price, staffId;
        private string roomNo;
        private string roomType;
        private string name;
        private string category;

        public roomDTO(string roomNo, int price, string roomType, int staffId)
        {
            // TODO: Complete member initialization
            this.roomNo = roomNo;
            this.price = price;
            this.roomType = roomType;
            this.staffId = staffId;
        }


        public int StaffId
        {
            get { return staffId; }
            set { staffId = value; }
        }

        public string RoomType
        {
            get { return roomType; }
            set { roomType = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public string RoomNo
        {
            get { return roomNo; }
            set { roomNo = value; }
        }



    }
}
