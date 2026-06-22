using System;

class Student
{
    public string Name;
}

class Exercise2_ValueVsReference
{
    static void ChangeNumber(int value)
    {
        value = 50;
        Console.WriteLine("Inside ChangeNumber(): " + value);
    }

    static void ChangeStudent(Student student)
    {
        student.Name = "Rahul";
        Console.WriteLine("Inside ChangeStudent(): " + student.Name);
    }

    static void Main()
    {
        // Value Type Example
        int number = 25;

        Console.WriteLine("VALUE TYPE DEMONSTRATION");
        Console.WriteLine("Before Method Call: " + number);

        ChangeNumber(number);

        Console.WriteLine("After Method Call: " + number);

        Console.WriteLine();

        // Reference Type Example
        Student s = new Student();
        s.Name = "Vyshnavi";

        Console.WriteLine("REFERENCE TYPE DEMONSTRATION");
        Console.WriteLine("Before Method Call: " + s.Name);

        ChangeStudent(s);

        Console.WriteLine("After Method Call: " + s.Name);
    }
}
