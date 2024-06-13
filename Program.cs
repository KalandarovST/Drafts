using System;
string userInput;
do
{
    Console.WriteLine("Karra jadval");
    int number = 1 ;
    while (number <= 9)
    {
        int multiplayer = 1;
        while(multiplayer <= 9)
        {
            Console.WriteLine($"{number} x {multiplayer} = {multiplayer * number}");
            multiplayer++;
        }

       Console.WriteLine($"{number} ning jadvali");
        number++;

    }
    Console.WriteLine("Do you want continue? (y -> n)");
    userInput = Console.ReadLine();
}
while(userInput == "y");

