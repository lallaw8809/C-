using System;

namespace out_modifier
{
    class program
    {
        public class Student_info
        {
            public string Name { get; set; }
            public int Roll_number { get; set; }
        }

        static void Modify_Student_Info(out Student_info student)
        {
            // We can/must create an object here
            student = new Student_info();
            student.Name = "Madhan kumar";
            student.Roll_number = 56;
        }

        static void Main()
        {
            Student_info student;

            // In the "out" student object should not be created
            // So out is a one way
            //student = new Student_info();

            Modify_Student_Info(out student);

            Console.WriteLine(student.Name);
            Console.WriteLine(student.Roll_number);
        }
    }
}


// Output:

// Madhan kumar
// 56
