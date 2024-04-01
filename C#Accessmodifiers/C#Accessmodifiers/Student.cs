using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Accessmodifiers
{
    public class Student
    {
        
            public Student(string fullname,string groupno,double avgpoint)
            {
                FullName = fullname;
                GroupNo = groupno;
                AvgPoint = avgpoint;
            }
            public string FullName { get; set; }
            public string GroupNo { get; set; }
            public double AvgPoint { get; set; }

        public string ShowInfo()
        {
            return $"{this.FullName} {this.GroupNo} {this.AvgPoint}";
        }

        


    }
}
