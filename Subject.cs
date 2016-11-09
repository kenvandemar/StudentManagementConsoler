using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    class Subject
    {
        public string SubjectId { get; set; }
        public string SubjectName { get; set; }
        
        public Subject(string subjectId, string subjectName)
        {
            this.SubjectId = subjectId;
            this.SubjectName = subjectName;
        }
    }
}
