using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("*You wake up in a a small room and remember how you were caught while trying to gather some secret information*");
        Console.WriteLine("");
        Console.WriteLine("Welcome to my secret lair agent");
        Console.WriteLine("Enjoy failing to get out of my ingenious trapps");
        Console.WriteLine("MUAHAHAHAHHA!!!");
        Console.WriteLine("");

        while (true)
        {
            Console.WriteLine("@*There is a number keypad by the door in the otherwise barren room*\n*There is something scribbled on the side of the pad\n1...2...");
            string keyP = Console.ReadLine()?.ToLower();
            if (keyP == "3")
            {
                winCell();
                return; 
            }
            else
            {
                loseGame();
                return; 
            }
        }
        
    }
    
    static void winCell()
    {
        Console.WriteLine("Curses! You guessed it!!!");
        Console.WriteLine("");
        Console.WriteLine("*You exit the cell and step out in a small hallway that looks surprisingly homely*");
        return;
        
    }
    
    
    static void loseGame()
    {
        Console.WriteLine("Ahhh sweet death");
        Console.WriteLine("");
        return;
    }
}






