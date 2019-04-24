using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group();
            Console.WriteLine("Please enter your group number:");
            group.Name = Console.ReadLine();
            Student student = new Student();
            student.Group = group;
            Console.WriteLine("Please enter your name:");
            student.Name = Console.ReadLine();
            Console.WriteLine("Please enter your surname:");
            student.Surname = Console.ReadLine();
            Console.WriteLine("Salam {0} {1}.Sizin qrupunuz: {2}",student.Name,student.Surname, student.Group.Name);
            Console.ReadKey();
        }
    }
    class Group
    {
        public string Name { get; set; }
    }
    class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Group Group { get; set; }
        
    }

}
