using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAverage
{
    internal class Student
    {
        public string? name;
        public double grade1, grade2;

        //Average
        public double average()
        {
            return (grade1 + grade2)/2;
        }
        //Situation
        public string situation(double average)
        {
            return average >= 7 ? "Approved" : "Disapproved";
        }
        //Message
        public void message()
        {
            double getAverage = average();
            string getSituation = situation(getAverage);
            Console.WriteLine(name + " it is " +getSituation+" with average of "+getAverage);
        }
    }
}
