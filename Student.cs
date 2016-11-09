using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    class Student
    {
      
        public string StudentId{ get; set; }
        public string StudentName { get; set; }
        public Student(string pMa, string Pten)
        {
            this.StudentId = pMa;
            this.StudentName = Pten;
        }
    }
}
