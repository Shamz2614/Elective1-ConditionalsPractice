using System;

class Practice05
{
    static void Main()
    {
        Console.Write("Enter the radius of the circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Choose an option:");
        Console.WriteLine("A - Compute Area");
        Console.WriteLine("P - Compute Perimeter");
        Console.WriteLine("X - Exit");

        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();

        if (choice == "A")
        {
            double area = 3.1416 * radius * radius;
            Console.WriteLine("Area of the circle: " + area);
        }
        else if (choice == "P")
        {
            double perimeter = 2 * 3.1416 * radius;
            Console.WriteLine("Perimeter of the circle: " + perimeter);
        }
        else if (choice == "X")
        {
            Console.WriteLine("Exiting the program...");
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }
}
