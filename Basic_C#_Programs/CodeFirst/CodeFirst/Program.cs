using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    class Program
    {
        static private void AddGrades()
        {
            using (var ctx = new SchoolContext())
            {
                if (!ctx.Grades.Where(x => x.GradeId == 1).Any())
                {
                    var g = new Grade() { GradeId = 1, GradeName = "Grade 1", Section = "Section A" };
                    ctx.Grades.Add(g);
                }
                if (!ctx.Grades.Where(x => x.GradeId == 2).Any())
                {
                    var g = new Grade() { GradeId = 2, GradeName = "Grade 2", Section = "Section B" };
                    ctx.Grades.Add(g);
                }
                if (!ctx.Grades.Where(x => x.GradeId == 3).Any())
                {
                    var g = new Grade() { GradeId = 3, GradeName = "Grade 3", Section = "Section C" };
                    ctx.Grades.Add(g);
                }
                ctx.SaveChanges();
            }
        }
        static void Main(string[] args)
        {
            AddGrades();     
            using (var ctx = new SchoolContext())
            {
                Console.Write("Enter a Student Name: ");//ask for a student name to add the data base
                string studentName = Console.ReadLine();
                Console.Write("Enter Student grade: ");
                int studentGrade = Convert.ToInt32(Console.ReadLine());
                var g = ctx.Grades.Where(x => x.GradeId == studentGrade).First();
                if (g != null)
                {
                    var stud = new Student() { StudentName = studentName, Grade = g};
                    ctx.Students.Add(stud);
                    ctx.SaveChanges();
                }
                Console.ReadKey();
                              
            }
        }
    }
}
