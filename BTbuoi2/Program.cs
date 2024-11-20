using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTbuoi2
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Anh", Age = 16 },
                new Student { Id = 2, Name = "Hoang", Age = 14 },
                new Student { Id = 3, Name = "Chien", Age = 19 },
                new Student { Id = 4, Name = "An", Age = 21 },
                new Student { Id = 5, Name = "Phuc", Age = 15 }
            };

            Console.WriteLine("Danh sach toan bo sinh:");
            students.ForEach(s => Console.WriteLine($"Id: {s.Id}, Name: {s.Name}, Age: {s.Age}"));
            Console.WriteLine();

            Console.WriteLine("Danh sach hoc sinh co tuoi tu 15 den 18:");
            var studentsInRange = students.Where(s => s.Age >= 15 && s.Age <= 18);
            foreach (var student in studentsInRange)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }
            Console.WriteLine();

            Console.WriteLine("Danh sach hoc sinh co ten bat dau bang chu 'A':");
            var studentsWithA = students.Where(s => s.Name.StartsWith("A"));
            foreach (var student in studentsWithA)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }
            Console.WriteLine();

            Console.WriteLine("Tong tuoi cua cac hoc sinh:");
            int totalAge = students.Sum(s => s.Age);
            Console.WriteLine($"Tong tuoi: {totalAge}");
            Console.WriteLine();

            Console.WriteLine("Hoc sinh co tuoi lon nhat:");
            var oldestStudent = students.OrderByDescending(s => s.Age).FirstOrDefault();
            if (oldestStudent != null)
            {
                Console.WriteLine($"Id: {oldestStudent.Id}, Name: {oldestStudent.Name}, Age: {oldestStudent.Age}");
            }
            Console.WriteLine();

            Console.WriteLine("Danh sach hoc sinh sap xep theo tuoi tang dan:");
            var sortedStudents = students.OrderBy(s => s.Age);
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }
        }
    }
}