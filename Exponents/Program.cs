
bool loop = true;

//Greeting
Console.WriteLine("Welcome to the powers generator");

while (loop == true)
{
    //initial user entry
    Console.WriteLine("Please enter an integer: ");
    int userInput = int.Parse(Console.ReadLine());

    //loops to ensure user enters positive integer, limits to int max numbersize
    while (userInput <= 0)
    {
        Console.WriteLine("Please enter a positive integer: ");
        userInput = int.Parse(Console.ReadLine());
    }
    while (userInput > 1290)
    {
        Console.WriteLine("I'm sorry but our humble powers generator can't count that high");
        Console.WriteLine("Please enter a smaller number: ");
        userInput = int.Parse(Console.ReadLine());
    }
    {
        Console.WriteLine("Number" + "\t" + "Squared" + "\t" + "Cubed");
        Console.WriteLine("=======" + "\t" + "=======" + "\t" + "=======");

        for (int i = 1; i <= userInput; i++)
        {
            Console.WriteLine(i + "\t" + squared(i) + "\t" + cubed(i));
        }
    }
    
        Console.WriteLine("Continue? y/n: ");
        string response = Console.ReadLine();

        if (response == "y")
        {
            loop = true;
        }
        else
        {
            Console.WriteLine("Goodbye!");
            loop = false;
        }
    

}

//Square and cube methods
static int squared(int userInput)
{
    int squared = userInput * userInput;
    return squared;
}


static int cubed(int userInput)
{
    int cubed = userInput * userInput * userInput;
    return cubed;
}



