using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_task
{
    internal class Student
    {
        public string surname;
        public string name;
        public int age;
        public double gradeAvg;
        public List<(string, int)> subjects = new List<(string, int)> ();
        //список предметов реализован с помощью листа ^ можно было и по-другому, но и так работает)
        public Student(string surname,string name,int age, int math, int rus, int lit)
        {
            this.surname = surname;
            this.name = name;
            this.age = age;
            gradeAvg = (Convert.ToDouble(math+rus+lit))/3;
            subjects.Add(("математика", math));
            subjects.Add(("русский", rus));
            subjects.Add(("литература", lit));            
        }
        
    }
}