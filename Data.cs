using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace QuanLySinhVien
{
    class Data
    {
        //static: khong can instance ra object
        //public static ArrayList StudentList = new ArrayList();
         public static  List<Student> StudentList = new List<Student>();
         public static List<Subject> SubjectList = new List<Subject>();
         public static List<Mark> MarkList = new List<Mark>();

        public static void KhoiTaoDuLieu()
        {
            //Sinh vien list
            StudentList.Add(new Student("1", "Nguyen Thi Minh"));
            StudentList.Add(new Student("2", "Nguyen Thi Lan"));
            StudentList.Add(new Student("3", "Nguyen Thi Cuong"));
            StudentList.Add(new Student("4", "Nguyen Minh Tram"));
            StudentList.Add(new Student("5", "Nguyen Lan Mai"));

            //Subject List
            SubjectList.Add(new Subject("SJ01", "HTML"));
            SubjectList.Add(new Subject("SJ02", "C#"));
            SubjectList.Add(new Subject("SJ03", "CSS"));

            //Mark List
            MarkList.Add(new Mark("1", "SJ01", "1", "12/10/2016", 6.5));
            MarkList.Add(new Mark("2", "SJ02", "4", "16/10/2016", 9));
            MarkList.Add(new Mark("3", "SJ01", "2", "19/10/2016", 6));
            MarkList.Add(new Mark("4", "SJ03", "1", "22/10/2016", 8));
            MarkList.Add(new Mark("5", "SJ02", "3", "25/10/2016", 7));
        }
    }
}
