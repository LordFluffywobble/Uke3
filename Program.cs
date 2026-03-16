using System;
class Program
{
    static void Main()
    {
        greetGame();

        while (true)
        {
            Console.WriteLine("*There is a number keypad by the door in the otherwise barren room*\n*There is something scribbled on the side of the pad*\n1...2...");
            string keyP = Console.ReadLine()?.ToLower();
            switch (keyP)
            {
                case "3":
                    winCell();            
                    return;
                
                case "666":
                    Console.WriteLine("");
                    Console.WriteLine("What do you think you're doing?");
                    Console.WriteLine("");
                    return;

                default:
                    loseGame();
                    return;
            }

        }

            hallway();
    }
    
    static void winCell()
    {
        Console.WriteLine("Curses! You guessed it!!!");
        Console.WriteLine("");
        Console.WriteLine("*You exit the cell and step out in a small hallway that looks surprisingly homely*");
        hallway();        
    }
    
    
    static void loseGame()
    {
        Console.WriteLine("");
        Console.WriteLine("Ahhh sweet death");
        Console.WriteLine("");
        return;
    }
    static void greetGame()
    {
        Console.WriteLine("");
        Console.WriteLine("*You wake up in a a small room and remember how you were caught while trying to gather some secret information*");
        Console.WriteLine("");
        Console.WriteLine("Welcome to my secret lair agent");
        Console.WriteLine("Enjoy failing to get out of my ingenious traps");
        Console.WriteLine("MUAHAHAHAHHA!!!");
        Console.WriteLine("");
        return;
    }
    
    static void hallway()
    {
        Console.WriteLine("");
        Console.WriteLine("At the end of the hallway you see a stone statue with something written on a plaque underneath");
        Console.WriteLine("Speak the mighty words of Poe:");
        Console.WriteLine("Never....?");
        Console.WriteLine("");
        string keyP = Console.ReadLine()?.ToLower();
        switch (keyP)
        {   
            case "nevermore":
            Console.WriteLine("");
            Console.WriteLine("You guessed correctly, please enter the livingroom\nThe statue moves aside and you enter the livingroom");
            Console.WriteLine("");
            livingRoom();
            break;

            default:
            loseGame();
            return;
        }
    }

    static void livingRoom()
    {
        Console.WriteLine("Livingroom");
        return;
    }
}





