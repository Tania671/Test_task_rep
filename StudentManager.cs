using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_task
{
    internal class StudentManager
    {
        List<Student> studentList = new List<Student>();

        //добавление студента в список студентов
        public void AddStudent(string surname, string name, int age, int math, int rus, int lit)
        {            
            Student student = new Student(surname,name,age,math,rus,lit);//создание нового экземпляра класса
            studentList.Add(student);//добавление элемента в список экземпляров класса
        }

        //вывод на консоль списка студентов и их данные, сверху идет строка-шапочка
        public void WriteStudentsList()
        {
            Console.WriteLine("Фамилия Имя Возраст Математика Русский Литература");
            studentList.Sort(Sort);
            foreach (Student student in studentList) //для каждого элемента списка в консоль выводится строка с данными
            {
                Console.WriteLine(student.surname + " " + student.name + " " + student.age + " лет "
                    + student.subjects.ElementAt(0).Item2 + " " + student.subjects.ElementAt(1).Item2 + " " 
                    + student.subjects.ElementAt(2).Item2 + " ");
            }
        }

        //расчет и вывод на консоль средних баллов по предметам
        public void AvgSubjects()
        {
            if(studentList.Count>0){
            double avgMath = 0;
            double avgRus = 0;
            double avgLit = 0;
            for (int i = 0; i < studentList.Count; i++)
            {
                Student student = studentList[i];
                avgMath = avgMath+student.subjects.ElementAt(0).Item2;//тут считается сумма баллов по предмету
                avgRus = avgRus+student.subjects.ElementAt(1).Item2;
                avgLit = avgLit+student.subjects.ElementAt(2).Item2;
            }
            avgMath = avgMath/studentList.Count;//тут считаются средние
            avgRus = avgRus/studentList.Count;
            avgLit = avgLit/studentList.Count;
            Console.WriteLine("математика:"+ Math.Round(avgMath,2, MidpointRounding.ToNegativeInfinity)
                +"; русский:"+ Math.Round(avgRus, 2, MidpointRounding.ToNegativeInfinity)
                + "; литература:"+ Math.Round(avgLit, 2, MidpointRounding.ToNegativeInfinity));//тут округляется и выводится на консоль
            }
            else{Console.WriteLine("Список учеников пуст.");}//ловит попытку посчитать средние баллы пустого списка учеников
        }

        //сортировка по среднему баллу атестата
        private int Sort(Student stud1, Student stud2) 
        {
                if (stud1 == null && stud2 == null) return 0;
                else if (stud1 == null) return -1;
                else if (stud2 == null) return 1;
                else
                    return stud2.gradeAvg.CompareTo(stud1.gradeAvg);//сортировка от большего к меньшему
        }
    }
}
