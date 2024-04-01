using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Accessmodifiers
{
    public class Group
    {
        public Student[] Students = { };
        public string No { get; set; }
        public int StudentLimit { get; set; }

        public Group(string no, int studentlimit)
        {
            No = no;
            StudentLimit = studentlimit;

        }

        public string AddStudent(Student student)
        {
            if (Students.Length + 1 <= StudentLimit)
            {
                Array.Resize(ref Students, Students.Length + 1);
                Students[Students.Length - 1] = student;
                return "elave olundu";
            }
            else { return "StudentLimit dolub"; }
            return No;

        }
        public void ShowAllStudents()
        {
            for (int i = 0; i < Students.Length; i++)
            {
                var student = Students[i].ShowInfo();

                Console.WriteLine(student);
            }
        }
        public Student[] Filtered(char a)
        {
            Student[] sss = { };
            for (int i = 0; i < Students.Length; i++)
            {
                string name = Students[i].FullName;
                for (int j = 0; j < name.Length; j++)
                {
                    if (name[j] == a)
                    {
                        Array.Resize(ref sss, sss.Length + 1);
                        sss[sss.Length - 1] = Students[i];
                        break;
                    }
                }
            }
            return sss;
        }




    }
}
