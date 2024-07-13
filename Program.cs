internal class Program
{
    private static void Main(string[] args)
    {
        // while (true)
        // {
        String ans;
        Console.WriteLine("===================FURNITURE INVENTORY SYSTEM=====================");
        Console.WriteLine("||                                                              ||");
        Console.WriteLine("||                                                              ||");
        Console.WriteLine("||                                                              ||");
        Console.WriteLine("||\t\t Welcome! Please choose an action\t\t||");
        Console.WriteLine("||                                                              ||");
        Console.WriteLine("||                                                              ||");
        Console.WriteLine("||\t1.) View Inventory\t\t\t\t\t||");
        Console.WriteLine("||\t2.) Login\t\t\t\t\t\t||");
        Console.WriteLine("||\t3.) Exit\t\t\t\t\t\t||");
        Console.WriteLine("||                                                              ||");
        Console.WriteLine("||                                                              ||");
        Console.WriteLine("||==============================================================||");
        ans = Convert.ToString(Console.ReadLine());

        switch (ans)
        {
            case "3":
                Console.Clear();
                Console.WriteLine("Thank you for using our system!");
                Console.WriteLine("\n\nPress any key to exit...");
                Console.ReadKey();
                break;
            case "2":
                Console.Clear();
                // function papunta sa view inventory
                break;
            case "1":
                Console.Clear();
                // function papunta sa login
                break;
            default:
                Console.WriteLine("Invalid Input!");
                break;
        }
        // }
    }
}