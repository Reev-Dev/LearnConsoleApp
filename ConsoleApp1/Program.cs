using System;

//class Program
//{
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
//}

class Student
{
    static void Main()
    {
        Console.Write("Enter the Student Name: ");
        string inputName = Console.ReadLine();

        Console.Write("Enter the Student ID: "); 
        int inputId = int.Parse(Console.ReadLine());

        static void ShowData(string name, int id)
        {
            Console.WriteLine($"Student Name: {name}");
            Console.WriteLine($"Student ID: {id}");
        }
        ShowData(inputName, inputId);
    }
}