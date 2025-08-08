using System;
using System.Collections.Generic;

class Student
{
    //static void Main()
    //{
    //Console.Write("Enter the Student Name: ");
    //string inputName = Console.ReadLine();

    //    Console.Write("Enter the Student ID: "); 
    //    int inputId = int.Parse(Console.ReadLine());

    //    static void ShowData(string name, int id)
    //    {
    //        Console.WriteLine($"Student Name: {name}");
    //        Console.WriteLine($"Student ID: {id}");
    //    }
    //    ShowData(inputName, inputId);
    //}

    // Properties
    public string Name { get; set; }
    public int Id { get; set; }

    // Constructor
    public Student (string name, int id)
    {
        Name = name;
        Id = id;
    }

    //Method
    public void ShowData()
    {
        Console.WriteLine($"Student Name: {Name}");
        Console.WriteLine($"Student ID: {Id}");
    }
}

class Program
{
    //    static void Main()
    //    {
    //        Console.Write("Enter the radius: ");
    //        int heightValue = int.Parse(Console.ReadLine());

    //        if (heightValue % 7 == 0)
    //        {
    //            double radius = Math.Pow(heightValue, 2);
    //            double result = (22 * radius / 7);
    //            Console.WriteLine($"Luas: {result}");
    //        }
    //        else
    //        {
    //            double radius = (int)Math.Pow(heightValue, 2);
    //            double result = 3.14 * radius;
    //            Console.WriteLine($"Luas: {result}");
    //        }

    //        Console.Write("Enter the First Number: ");
    //        int first = int.Parse(Console.ReadLine());
    //        Console.Write("Enter the Second Number: ");
    //        int second = int.Parse(Console.ReadLine());
    //        Console.Write("Enter the Third Number: ");
    //        int third = int.Parse(Console.ReadLine());

    //        int average = (first + second + third) / 3;
    //        Console.WriteLine($"The Average is: {average}");
    //    }

    static void Main()
    {
        List<Student> students = new List<Student>();
        List<Student> oddIdStudents = new List<Student>();
        int evenCount = 0, oddCount = 0;

        Console.Write("How many students do you want to add? ");
        int totalStudents;

        while (!int.TryParse(Console.ReadLine(), out totalStudents) || totalStudents <= 0)
        {
            Console.WriteLine("Please enter a valid number greater than 0!");
            Console.Write("Add: ");
        }

        for (int i = 0; i < totalStudents; i++)
        {
            Console.WriteLine($"\n Enter data for Student {i + 1}");

            string name = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(name))
            {
                Console.Write("Name cannot be empty, please enter again: ");
                name = Console.ReadLine();
            }

            int id;
            Console.Write("ID (Number only): ");
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.Write("Please enter a valid ID (Number only): ");
            }

            Student s = new Student(name, id);
            students.Add(s);

            // Check if ID is even or odd
            if (id % 2 == 0)
            {
                evenCount++;
            }
            else
            {
                oddCount++;
                oddIdStudents.Add(s);
            }
        }

        Console.WriteLine("\n=== Student List ===");
        foreach (Student s in students)
        {
            s.ShowData();
            Console.WriteLine("---------------------");
        }

        Console.WriteLine($"\nTotal students with even ID: {evenCount}");
        Console.WriteLine($"Total students with odd ID: {oddCount}");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n=== Students with Odd IDs ===");
        Console.ResetColor();
        foreach (Student s in oddIdStudents)
        {
            s.ShowData();
            Console.WriteLine("---------------------");
        }
    }
}