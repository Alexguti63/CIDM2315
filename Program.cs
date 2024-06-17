namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input a letter grade: ");
        string grade = Console.ReadLine();
        if (grade == "A")
        {
            Console.WriteLine("GPA point: 4");
        }
        else if (grade == "B")
        {
            Console.WriteLine("GPA point: 3");
        }
        else if (grade == "C")
        {
            Console.WriteLine("GPA point: 2");
        }
        else if (grade == "D")
        {
            Console.WriteLine("GPA point: 1");
        }
        else if (grade == "F")
        {
            Console.WriteLine("GPA point: 0");
        }
        else
        {
            Console.WriteLine("Wrong letter grade!");
        }
        Console.WriteLine("Please input the first number: ");
        int num1 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please input the second number: ");
        int num2 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please input the third number: ");
        int num3 = Convert.ToInt16(Console.ReadLine());
        if (num1 < num2)
        {
            if (num1 < num3)
            {
                Console.WriteLine("The smallest number is: " + num1);
            }
            else
            {
                Console.WriteLine("The smallest number is: " + num3);
            }
        }
        else
        {
            if (num2 < num3)
            {
                Console.WriteLine("The smallest number is: " + num2);
            }
            else
            {
                Console.WriteLine("The smallest number is: " + num3);
            }
        }
        Console.WriteLine("Please input a year: ");
        int year = Convert.ToInt16(Console.ReadLine());
        if (year % 4 != 0)
        {
            return;
        }
        if (year % 100 == 0)
        {
            if (year % 400 == 0)
            {
                Console.WriteLine(year + " is a leap year.");
            }
            else
            {
                Console.WriteLine(year + " is not a leap year.");
            }
        }
        else
        {
            Console.WriteLine(year + " is a leap year.");
        }

    }
}
