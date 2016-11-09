using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QuanLySinhVien
{
    class Program
    {
        static void Main(string[] args)
        {

            Data.KhoiTaoDuLieu();
            //foreach (Student item in Data.StudentList)
            //{
            //  
            int input = 0;
              
            while(input != 6)
            {
                Console.WriteLine("---STUDENT MARK MANAGEMENT SYSTEM---");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Please choose one of numbers below: ");
            Console.WriteLine("1. Add new student");
            Console.WriteLine("2. Edit student information");
            Console.WriteLine("3. Add new Subject");
            Console.WriteLine("4. Edit subject information");
            Console.WriteLine("5. Enter student mark");
            Console.WriteLine("6. Exit");

                input = Convert.ToInt16(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Please Enter new student Id: ");
                        string studId = Console.ReadLine();
                        Console.WriteLine("Pleas Enter new student name: ");
                        string studName = Console.ReadLine();

                        Data.StudentList.Add(new Student(studId, studName));

                        Console.WriteLine("Add new Student Successfully!");
                        foreach (Student item in Data.StudentList)
                        {
                            Console.WriteLine(item.StudentId);
                            Console.WriteLine(item.StudentName);
                        }
                        break;

                    case 2:
                        Console.WriteLine("Please select studentID to edit: ");
                        string studIdSelect = Console.ReadLine();
                        Console.WriteLine("Please Choose a new name for above studentID: ");
                        string studNameEdit = Console.ReadLine();

                        var newStudent = Data.StudentList.Where(d => d.StudentId == studIdSelect).FirstOrDefault();
                        if (newStudent != null)
                        {
                            newStudent.StudentName = studNameEdit;
                        }
                        Console.WriteLine("STUDENT INFORMATION UPDATED SUCCESSFULLY!");
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine("NEW STUDENT INFORMATION SHOWED BELOW: ");
                        foreach (Student item in Data.StudentList)
                        {
                            Console.WriteLine(item.StudentId);
                            Console.WriteLine(item.StudentName);
                            Console.WriteLine("===================================================");
                        }

                        break;

                    case 3:
                        Console.WriteLine("Please Enter Subject Id: ");
                        string subjId = Console.ReadLine();
                        Console.WriteLine("Please Enter new subject name");
                        string subjName = Console.ReadLine();
                        Data.SubjectList.Add(new Subject(subjId, subjName));
                        Console.WriteLine("ADD SUBJECT SUCCESSFULLY");
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("UPDATE SUBJECTS SHOWED BELOW: ");
                        foreach (Subject subjItem in Data.SubjectList)
                        {
                            Console.WriteLine(subjItem.SubjectId);
                            Console.WriteLine(subjItem.SubjectName);
                            Console.WriteLine("===================================================");
                        }

                        break;
                    case 4:
                        Console.WriteLine("Please select subjectId to edit: ");
                        string sbjIdSelect = Console.ReadLine();
                        string sbjNameEdit = Console.ReadLine();

                        var newSubject = Data.SubjectList.Where(s => s.SubjectId == sbjIdSelect).FirstOrDefault();

                        if (newSubject != null)
                        {
                            newSubject.SubjectName = sbjNameEdit;
                        }

                        Console.WriteLine("SUBJECT INFORMATION UPDATED SUCCESSFULLY!");
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine("NEW SUBJECT INFORMATION SHOWED BELOW: ");
                        foreach (Subject item in Data.SubjectList)
                        {
                            Console.WriteLine(item.SubjectId);
                            Console.WriteLine(item.SubjectName);
                            Console.WriteLine("===================================================");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Plesae choose Student Id to edit mark: ");
                        string studIdSelector = Console.ReadLine();
                        Console.WriteLine("Enter New Mark: ");
                        double mSelect = Convert.ToInt16(Console.ReadLine());

                        var newMark = Data.MarkList.Where(m => m.StudentID == studIdSelector).FirstOrDefault();
                        if (newMark != null)
                        {
                            newMark.StudentID = studIdSelector;
                            newMark.Marks = mSelect;
                        }
                        Console.WriteLine("MARK INFORMATION UPDATED SUCCESSFULLY!");

                        Console.WriteLine("Mark of studen ID {0} is updated to {1}", newMark.StudentID, newMark.Marks);

                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine("NEW MARK INFORMATION SHOWED BELOW: ");
                        foreach (Mark mItem in Data.MarkList)
                        {
                            Console.WriteLine("Mark of studen ID {0} is {1}", mItem.StudentID, mItem.Marks);                          
                        }
                        Console.WriteLine("===================================================");
                        break;
                    case 6:
                        Console.WriteLine("THANK YOU, PLEASE PRESS ANY KEY TO EXIT!");
                        Environment.Exit(input);                      
                        break;
                    default:
                        return;
                }
            }                
                    }
                }
            }
              



