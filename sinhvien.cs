using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    class sinhvien
    {
        public string studentID;

        private string _Ten;

        public string Ten
        {
            get { return _Ten.ToUpper(); }
            set { _Ten = value; }
        }
        //Neu Property chi co Set: Write only
        //Neu chi co Get: Read Only

        //Constructor: Khong co kieu tra ve
        //Name: trung voi ten class
        //Mot class co the co nhieu constructor nhung cac Constructor phai khac so luong tham so 
        //hoac kieu neu co cung so luong tham so
       

        public sinhvien(string pMa, string pTen)
        {
            this.studentID = pMa;
            this.Ten = pTen;
        }
        // => Overloading: Co nhieu constructor trong 1 class
        public sinhvien(string pMa)
        {
            this.studentID = pMa;
            this.Ten = "@*Cho cap nhat";
        }

        //Phuong Thuc toString()
        public override string ToString()
        {   
            return Ten + " Lay tu toString";
        }
    }
}
