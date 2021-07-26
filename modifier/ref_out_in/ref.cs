using System;

namespace reference
{
    class program
    {
        public class Student_info
        {
            public string Name { get; set; }
            public int Roll_number { get; set; }
        }

        static void Modify_Student_Info(ref Student_info student)
        {
            // We can modify the student object here and it will modify in the reference
            student.Name = "Madhan kumar";
            student.Roll_number = 56;

            // Can create a new object here as well
            student = new Student_info();
            student.Name = "Ram kumar";
            student.Roll_number = 57;
        }

        static void Main()
        {
            Student_info student;

            // In the "ref" student object should be created
            // So ref is a two way
            student = new Student_info();

            student.Name = "Lal Bosco";
            student.Roll_number = 55;

            Modify_Student_Info(ref student);

            Console.WriteLine(student.Name);
            Console.WriteLine(student.Roll_number);
        }
    }
}


// Output:

// Ram kumar
// 57
