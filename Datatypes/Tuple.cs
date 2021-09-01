using System;

public class Program
{
    public static (double, int) GetTupleValues()
    {
        return (90.012, 3);
    }
	
	static void DisplayTuple(Tuple<string,string> Names)
	{
		Console.WriteLine($"First Name = { Names.Item1}");
		Console.WriteLine($"Last Name = { Names.Item2}");
}

    public static void Main()
    {
        (double, int) t = (1.4, 3);
        Console.WriteLine($"Tuple with elements {t.Item1} and {t.Item2}.");
        Console.WriteLine("Print the whole tuple" + t.ToString());
        Console.WriteLine();

        (double Average, int TotalMarks) Aggregate = (100.0, 500);
        Console.WriteLine($"Marks Info{Aggregate.Average} and {Aggregate.TotalMarks}.");		
        Console.WriteLine();

        // Tuple field names
        var studentInfo = (RollNumber: 12, Name: "Lal Bosco");
        Console.WriteLine($"Student Info Name: {studentInfo.Name}, Roll Number: {studentInfo.RollNumber}.");
        Console.WriteLine();

        // Tuple using method
        var (A, B) = GetTupleValues();
        Console.WriteLine("Get the tuple value from method: " + A + B);
		Console.WriteLine();

        // Tuple Type
		
		Tuple<string, int> Employee = new Tuple<string, int>("Lal Bosco", 1);
		Console.WriteLine("Tuple type: " + Employee.Item1 + " " + Employee.Item2);
		Console.WriteLine();
		
		// Tuple<T1, T2, T3, T4, T5, T6, T7, TRest>
		var numbers = Tuple.Create(1, 2, 3, 4, 5, 6, 7, 8);
		Console.WriteLine("Tuple type: " + numbers.Item1 + " " + numbers.Rest);
		Console.WriteLine();		
		
		var n = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(4 ,5, 6, 7));
		Console.WriteLine("Tuple type: " + n.Item1 + " " +  n.Rest + " " +  n.Rest.Item1 + " " +  n.Rest.Item1.Item1);
		Console.WriteLine();
		
		// Tuple as a Method Parameter
		var names = Tuple.Create("Lal Bosco", "Lawrence");
		DisplayTuple(names);
    }
}

/*
Output:

Tuple with elements 1.4 and 3.
Print the whole tuple(1.4, 3)

Marks Info100 and 500.

Student Info Name: Lal Bosco, Roll Number: 12.

Get the tuple value from method: 90.0123

Tuple type: Lal Bosco 1

Tuple type: 1 (8)

Tuple type: 1 ((4, 5, 6, 7)) (4, 5, 6, 7) 4

First Name = Lal Bosco
Last Name = Lawrence
*/