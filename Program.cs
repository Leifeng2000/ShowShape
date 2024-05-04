internal class Program
{
    static void Main()
    {
        int choice = 0;

        do
        {
            Console.WriteLine("Menu:\n");
            Console.WriteLine("1. Print the rectangle");
            Console.WriteLine("2. Print the square triangle");
            Console.WriteLine("3. Print the isosceles triangle");
            Console.WriteLine("4. Exit");
            Console.WriteLine("\nEnter your choice (1-4):");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    PrintRectangle();
                    break;
                case 2:
                    PrintSquareTriangle();
                    break;
                case 3:
                    PrintIsoscelesTriangle();
                    break;
                case 4:
                    Console.WriteLine("Exiting the program...");
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please enter a choice from 1 to 4.");
                    break;
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

        } while (choice != 4);
    }

    static void PrintRectangle()
    {
        Console.WriteLine("Printing the rectangle:\n");
        Console.WriteLine("********");
        Console.WriteLine("********");
        Console.WriteLine("********");
        Console.WriteLine("********");
    }

    static void PrintSquareTriangle()
    {
        Console.WriteLine("Printing the square triangle:\n");
        Console.WriteLine("*");
        Console.WriteLine("**");
        Console.WriteLine("***");
        Console.WriteLine("****");
    }

    static void PrintIsoscelesTriangle()
    {
        Console.WriteLine("Printing the isosceles triangle:\n");
        Console.WriteLine("   *");
        Console.WriteLine("  ***");
        Console.WriteLine(" *****");
        Console.WriteLine("*******");
    }
}