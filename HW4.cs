namespace Homework4;

class Program
{
    static void Main(string[] args)
    {   //Q1
        int a = 3;
        int b = 5;
        int largestQ1 = 0;
        largestQ1 = Findlargest(a, b);
        Console.WriteLine("The largest number is: " + largestQ1);

        //Q2
        int a1 = 3;
        int b1 = 5;
        int c1 = 7;
        int d1 = 9;
        int largest1 = 0;
        int largest2 = 0;
        largest1 = Findlargest(a1, b1);
        largest2 = Findlargest(c1, d1);
        int largest3 = Findlargest(largest1, largest2);
        Console.WriteLine("The largest number is: " + largest3);

        //Q3
        Console.WriteLine("Enter Your Username: ");
        string username = Console.ReadLine();
        Console.WriteLine("Enter Your Password: ");
        string password = Console.ReadLine();
        Console.WriteLine("Enter Your Password Again: ");
        string password2 = Console.ReadLine();
        Console.WriteLine("Enter Your Birthyear: ");
        int birthyear = Convert.ToInt16(Console.ReadLine());
        bool age = true;
        age = Checkage(birthyear);
        if(age == true){
            if(password == password2){
                Console.WriteLine("Account is created successfully");
            }
            else{
                Console.WriteLine("Wrong password");
            }
        }
        else{
            Console.WriteLine("Could not create an account");
        }
    }
    static int Findlargest(int a, int b){
        if(a < b){
            return b;
        }
        else{
            return a;
        }
    }

    static bool Checkage(int birthyear){
        int cy = 2024;
        int age = cy - birthyear;
        if(age >= 18){
            return true;
        }
        else{
            return false;
        }
    }
    }

