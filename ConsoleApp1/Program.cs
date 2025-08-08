using System;
using System.Collections.Generic;

class Student
{
    public string Name { get; set; }
    public int Id { get; set; }

    public Student(string name, int id)
    {
        Name = name;
        Id = id;
    }

    public void ShowData()
    {
        Console.WriteLine($"Student Name: {Name}");
        Console.WriteLine($"Student ID: {Id}");
    }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();
        List<Student> oddIdStudents = new List<Student>();

        int evenCount = 0, oddCount = 0;

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("=== Student Data Entry ===\n");
        Console.ResetColor();

        int totalStudents;
        Console.Write("How many students do you want to add? ");
        while (!int.TryParse(Console.ReadLine(), out totalStudents) || totalStudents <= 0)
        {
            Console.WriteLine("❌ Please enter a valid number greater than 0!");
            Console.Write("Add: ");
        }

        for (int i = 0; i < totalStudents; i++)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n--- Enter data for Student {i + 1} ---");
            Console.ResetColor();

            // Input name with validation
            string name;
            do
            {
                Console.Write("Name: ");
                name = Console.ReadLine()?.Trim();
                if (string.IsNullOrWhiteSpace(name))
                    Console.WriteLine("❌ Name cannot be empty!");
            } while (string.IsNullOrWhiteSpace(name));

            // Input ID with validation
            int id;
            Console.Write("ID (Number only): ");
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.Write("❌ Please enter a valid ID (Number only): ");
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
                oddIdStudents.Add(s); // langsung referensi objek yang sama
            }
        }

        // Show all students
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n=== Student List ===");
        Console.ResetColor();
        foreach (Student s in students)
        {
            s.ShowData();
            Console.WriteLine("---------------------");
        }

        // Show counts
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nTotal students with even ID: {evenCount}");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"Total students with odd ID: {oddCount}");
        Console.ResetColor();

        // Show odd ID students
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("\n=== Students with Odd IDs ===");
        Console.ResetColor();
        foreach (Student s in oddIdStudents)
        {
            s.ShowData();
            Console.WriteLine("---------------------");
        }
    }
}
