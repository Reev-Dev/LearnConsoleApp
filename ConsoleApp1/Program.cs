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
    static List<Student> students = new List<Student>();
    static void Main()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("\n=== MENU ===");
            Console.WriteLine("1. Show All Student");
            Console.WriteLine("2. Add Student");
            Console.WriteLine("3. Edit Student");
            Console.WriteLine("4. Delete Student");
            Console.WriteLine("5. Exit");
            Console.Write("Choose menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                     ShowAll();
                    break;
                case "2":
                    AddStudent();
                    break;
                case "3":
                    EditStudent();
                    break;
                case "4":
                    DeleteStudent();
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }
        }
    }
    static void ShowAll()
    {
        if (students.Count > 0)
        {
            Console.WriteLine("\n=== List Student ===");
            foreach (var s in students)
            {
                s.ShowData();
                Console.WriteLine("--------------------");
            }
        } else
        {
            Console.WriteLine("Student's Data is Empty");
        }
    }
    static void AddStudent()
    {
        Console.Write("Enter the name: ");
        string name = Console.ReadLine();
        Console.Write("Enter the ID: ");
        int id = int.Parse(Console.ReadLine());
        students.Add(new Student(name, id));
        Console.WriteLine("Student added successfully!");
    }
    static void EditStudent()
    {
        Console.Write("Input student's ID that you want to edit: ");
        int id = int.Parse(Console.ReadLine());

        Student student = students.Find(s => s.Id == id);

        if(student != null)
        {
            Console.Write($"New Name for ({student.Name}): ");
            string newName = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(newName))
            {
                student.Name = newName;
            }

            Console.Write($"New ID for ({student.Id}): ");
            string newIdInput = Console.ReadLine();
            if (int.TryParse(newIdInput, out int newId) && newId > 0)
            {
                student.Id = newId;
            }

            Console.WriteLine("Student updated successfully!");
        } else
        {
            Console.WriteLine("Student not found!");
        }
    }
    static void DeleteStudent()
    {
        Console.Write("Input student's ID that you want to delete: ");
        int id = int.Parse(Console.ReadLine());
        var student = students.Find(s => s.Id == id);

        if (student != null)
        {
            students.Remove(student);
            Console.WriteLine("Student deleted successfully!");
        } else
        {
            Console.WriteLine("Student not found!");
        }
    }
}
