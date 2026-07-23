using System;
using System.Collections.Generic;
namespace LINQLAB
{
    class Student
    {
        public int studentId { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string Department { get; set; }
        public int semester { get; set; }
        public Double CGPA { get; set; }

        public Student(int studentId, string name, int age, string department, int semester, double cGPA)
        {
            this.studentId = studentId;
            this.name = name;
            this.age = age;
            Department = department;
            this.semester = semester;
            CGPA = cGPA;
        }
    }

    class resultUsingLinq
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(1, "Manav", 19, "CE", 5, 9.26));
            students.Add(new Student(2, "Anuj", 19, "IT", 5, 9.27));
            students.Add(new Student(3, "Virat", 19, "Sports", 5, 7.70));
            students.Add(new Student(4, "Rohit", 19, "Sports", 5, 8.45));
            students.Add(new Student(5, "Krishn", 19, "EC", 5, 9.12));
            students.Add(new Student(6, "Dev", 19, "CE", 5, 7.77));
            students.Add(new Student(7, "Rahul", 19, "CE", 5, 6.78));


            var result = from n in students where n.CGPA > 8.00 select n;

            Console.WriteLine("Students who got 8 or more CGPA are : \n");

            foreach (Student student in result)
            {
                Console.WriteLine(student.name);
            }

            Console.WriteLine("\n\nStudents From Computer Engineering Rank-wise on the basis of CGPA are: \n");
            var cgpa_desc = from s in students where s.Department is "CE" orderby s.CGPA descending select s;

            foreach (Student student in cgpa_desc)
            {
                Console.WriteLine(student.name + " : " + student.CGPA);
            }

            Console.WriteLine("\n\nTop three students ranked 1st,2nd,3rd respectively of the University are : \n");
            var ranker = (from s in students select s).OrderByDescending(s => s.CGPA).Take(3);
            foreach (Student student in ranker)
            {
                Console.WriteLine(student.name + " : " + student.CGPA);
            }

            Console.WriteLine("\n\nDepartment Wise students are : \n");
            var dept = (from s in students select s.Department).Distinct();
            foreach (var department in dept)
            {
                int num = (from s in students where s.Department == department select s).Count();
                Console.WriteLine("Total Students from " + department + " department are : " + num);
            }

        }
    }
}
