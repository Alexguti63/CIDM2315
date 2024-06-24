namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
        //I had help from CS50.ai to help me with Q1.
        Console.WriteLine("Input a Integar: ");
        int n = Convert.ToInt16(Console.ReadLine());
        int p = 0;

        for(int i = 1; i <= n; i++){
            if(n % i == 0){
                p++;
            }
            if(p > 2){
                break;
            }
        }
        if(p==2){
            Console.WriteLine("N is a prime number");
        }
        else{
            Console.WriteLine("N is not a prime number");
        }

        Console.WriteLine("Assign an int value to N: ");
        int N = Convert.ToInt16(Console.ReadLine());
        for(int row = 0; row < N; row++){
            for(int col = 0; col < N; col++){
                Console.Write('#');
            }
        Console.WriteLine("");
        }

        Console.WriteLine("Assign an int value to N: ");
        int R = Convert.ToInt16(Console.ReadLine());
        for(int row = 0; row < R; row++){
            for(int col = 0; col<R; col++){
                if(row>=col)
                Console.Write('*');
            }
        Console.WriteLine("");
        }

        Console.WriteLine("Assign an int value to N: ");
        int B = Convert.ToInt16(Console.ReadLine());
        for(int row = 0; row<=B; row++){
            for(int col = 1; col <= B; col++){
                if(row>=col)
                Console.Write(row);
            }
        Console.WriteLine("");
        }

    }
}
