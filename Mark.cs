using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    class Mark
    {
        public string StudentID { get; set; }
        public string SubjectId { get; set; }
        public string LanThi { get; set; }
        public string DateExam { get; set; }
        public double Marks { get; set; }

        public Mark(string studentID, string subjectId, string lanThi, string dateExam, double marks)
        {
            this.StudentID = studentID;
            this.SubjectId = subjectId;
            this.LanThi = lanThi;
            this.DateExam = lanThi;
            this.Marks = marks;
        }

    }
}
