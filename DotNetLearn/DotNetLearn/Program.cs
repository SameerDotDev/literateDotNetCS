namespace DotNetLearn;
class Program
{


    static void Main(string[] args)


    {
        Console.WriteLine("Hello, World!");
        



        int AgeofUser = Convert.ToInt32(Console.ReadLine());




        Console.WriteLine($"Your Age is {AgeofUser}");

        int indexofage = AgeofUser;

        for (int i = 0; i <= indexofage; i++)
        {
            Console.WriteLine($"Your Age is {AgeofUser} and iteration is {i}");
        }
        Console.ReadKey();
    }
}

