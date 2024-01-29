using DGD203_2;
using System.Numerics;


public class _NPC
{
    public Player Player { get; set; }
    public Game Game { get; set; }
    public Map Map { get; set; }
    public Location Location { get; set; }
    public Inventory Inventory { get; set; }

    public string Answer;
    public string OK;
    public Vector2 npcLocation;
    public string name;
    public bool CanTake = true;
    public int heatlh;


    public _NPC(string answer, string oK, Vector2 npclocation, bool cantake)
    {
        Answer = answer;
        OK = oK;
        npcLocation = npclocation;
        CanTake = cantake;
    }

    public void talk()
    {
        Player = new Player(name, null);
        Inventory = new Inventory();
        Game = new Game();
        Map = new Map(Game, 0, 0);
        heatlh = Player.Health;
        Console.WriteLine("Welcome " + name + " i am The spirit of questino" +
            "i hear that you a charm to help you in your quest" +
            "but the price not cheep ansewr me this riddle and i will gave you the charm, how about that?\n");
        question();
        while (CanTake)
        {
            getInput();
            handleInput();
        }
    }
    public void exit()
    {
        Environment.Exit(0);
    }
    public void question()
    {
        Console.WriteLine("\n\nWhat goes on four feet in the morning, two feet in midday, and three feet in the evening?\n1.clouds \n2.man.\n3.cats.\n4.souls.\n5.Yokaies");
    }
    public void getInput()
    {
        Answer = Console.ReadLine();
    }
    public void handleInput()
    {
        if (Answer != null)
        {
            if (heatlh > 0)
            {
                if (CanTake)
                {
                    switch (Answer)
                    {
                        case "1":
                            Console.WriteLine("correct,you aquire the charm of protection");
                            Player.TakeItem(Item.CharmOfProtection);
                            CanTake = false;
                            break;
                        case "2":
                            if (heatlh == 2)
                            {
                                Console.WriteLine("false you have one chance left");
                                Console.WriteLine("Hint:Its Befor the foundation of christianity");
                            }
                            else if (heatlh == 1)
                            {
                                Console.WriteLine("false you have a last chance left");
                            }
                            break;
                        case "3":
                            if (heatlh == 2)
                            {
                                Console.WriteLine("false you have one chance left");
                                Console.WriteLine("Hint:Its Befor the foundation of christianity");
                            }
                            else if (heatlh == 1)
                            {
                                Console.WriteLine("false you have a last chance left");
                            }
                            break;
                        case "4":
                            if (heatlh == 2)
                            {
                                Console.WriteLine("false you have one chance left");
                                Console.WriteLine("Hint:Its Befor the foundation of christianity");
                            }
                            else if(heatlh == 1)
                            {
                                Console.WriteLine("false you have a last chance left");
                            }
                            break;
                        case "5":
                            if (heatlh == 2)
                            {
                                Console.WriteLine("false you have one chance left");
                                Console.WriteLine("Hint:Its Befor the foundation of christianity");
                            }
                            else if (heatlh == 1)
                            {
                                Console.WriteLine("false you have a last chance left");
                            }
                            break;
                        default:
                            Console.WriteLine("wrong input!!");
                            break;
                    }
                    heatlh--;
                }
            }
            
        }
    }
}
