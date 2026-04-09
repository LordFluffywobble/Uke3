using System;
class Program
{
    static void Main()
    {
        greetGame();
    if( startGame() == false) { return; }
        hallWay();
        livingRoom();
    }

    static void loseGame()
    {
        Console.WriteLine("\nAhhh sweet death\n");
    }

    static void greetGame()
    {
        Console.WriteLine("*There is a number keypad by the door in the otherwise barren room*\n*There is something scribbled on the side of the pad*\n1...2...\n");
        Console.WriteLine("*You wake up in a a small room and remember how you were caught while trying to gather some secret information*\n");
        Console.WriteLine("Welcome to my secret lair agent");
        Console.WriteLine("Enjoy failing to get out of my ingenious traps");
        Console.WriteLine("MUAHAHAHAHHA!!!\n");
    }

    static bool startGame()
    {
        while (true)
        {
            Console.Write("*There is a number keypad by the door in the otherwise barren room*\n*There is something scribbled on the side of the pad*\n1...2...");
            string keyP = Console.ReadLine()?.ToLower();
            switch (keyP)
            {
                case "3":
                    winCell();
                    return true;

                case "666":
                    Console.WriteLine("\nWhat do you think you're doing?\n");
                    break;

                default:
                    loseGame();
                    return false;
            }
        }
    }
    static void winCell()
    {
        Console.WriteLine("Curses! You guessed it!!!\n");
        Console.WriteLine("*You exit the cell and step out in a small hallway that looks surprisingly homely*");
    }



    static void hallWay()
    {
        //Console.WriteLine("");
        Console.WriteLine("\nAt the end of the hallway you see a stone statue with something written on a plaque underneath:");
        Console.WriteLine("Speak the mighty words of Poe:");
        Console.WriteLine("Nevermore....?");

        string keyP = Console.ReadLine()?.ToLower();
        switch (keyP)
        {
            case "nevermore":
                Console.WriteLine("\nYou guessed correctly, please enter the livingroom\n\nThe statue moves aside and you enter the livingroom\n");
                break;

            default:
                loseGame();
                break;
        }
    }

    static void livingRoom()
    {
        Console.WriteLine("Livingroom");
        return;
    }
}





