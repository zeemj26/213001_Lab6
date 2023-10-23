namespace Lab5_ExQ1
{
    internal class Program
    {
       using System;

public enum Department
    {
        ComputerScience,
        Mathematics,
        Physics,
        Chemistry
    }

    class Person
    {
        public string Name { get; set; }

        public Person()
        {
            Name = null;
        }

        public Person(string name)
        {
            Name = name;
        }
    }

    class Student : Person
    {
        public string RegNo { get; set; }
        public int Age { get; set; }
        public Department Program { get; set; }

        public Student()
        {
            RegNo = null;
            Age = 0;
            Program = Department.ComputerScience;
        }

        public Student(string name, string regNo, int age, Department program)
            : base(name)
        {
            RegNo = regNo;
            Age = age;
            Program = program;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("John Doe", "12345", 20, Department.Physics);

            Console.WriteLine("Student Information:");
            Console.WriteLine("Name: " + student1.Name);
            Console.WriteLine("RegNo: " + student1.RegNo);
            Console.WriteLine("Age: " + student1.Age);
            Console.WriteLine("Program: " + student1.Program);

            Student student2 = new Student();

            Console.WriteLine("\nStudent 2 Information (Default Values):");
            Console.WriteLine("Name: " + student2.Name);
            Console.WriteLine("RegNo: " + student2.RegNo);
            Console.WriteLine("Age: " + student2.Age);
            Console.WriteLine("Program: " + student2.Program);
        }
    }


}