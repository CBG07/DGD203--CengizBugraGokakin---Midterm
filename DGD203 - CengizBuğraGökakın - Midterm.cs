using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DGD203MidtermGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            {
                bool gameOn = true;

                while (gameOn)
                {
                    Console.Clear();
                    Console.WriteLine("As the last person left in the world, you start your struggle for survival!");

                    // Get the player's name
                    Console.Write("Enter your name: ");
                    string playerName = Console.ReadLine();
                    Console.WriteLine($"Hello, {playerName}! Let's start your survival journey.");

                    // Question 1
                    Console.WriteLine("\n1. What would you do if you encounter a creature in the forest?");
                    Console.WriteLine("A. Run away");
                    Console.WriteLine("B. Fight");
                    Console.WriteLine("C. Try to talk");
                    string answer1 = Console.ReadLine().ToUpper();
                    while (answer1 != "A" && answer1 != "B" && answer1 != "C")
                    {
                        Console.Write("Enter a valid answer (A, B or C): ");
                        answer1 = Console.ReadLine().ToUpper();
                    }

                    if (answer1 == "A")
                    {
                        string[] explanations1 =
                        {
            "You focus on self-preservation. You need to move quickly to survive.",
            "You choose to avoid danger, speed is the key to survival.",
            "You chose to run to survive, a brave decision."
        };
                        Random rnd = new Random();
                        int choice1 = rnd.Next(explanations1.Length);
                        Console.WriteLine(explanations1[choice1]);
                    }
                    else if (answer1 == "B")
                    {
                        string[] explanations2 =
                        {
            "You're a brave warrior! You love to fight.",
            "You protect yourself by fighting. You always need to be one step ahead.",
            "You have a fighting spirit, facing challenges strengthens you."
        };
                        Random rnd = new Random();
                        int choice2 = rnd.Next(explanations2.Length);
                        Console.WriteLine(explanations2[choice2]);
                    }
                    else if (answer1 == "C")
                    {
                        string[] explanations3 =
                        {
            "You're trying to communicate, maybe you can find a solution.",
            "You're taking a peaceful approach. Diplomacy might keep you alive.",
            "Another way to survive might be to communicate with other creatures."
        };
                        Random rnd = new Random();
                        int choice3 = rnd.Next(explanations3.Length);
                        Console.WriteLine(explanations3[choice3]);
                    }

                    // Question 2
                    Console.WriteLine("\n2. You found a treasure. What do you do?");
                    Console.WriteLine("A. Open it immediately");
                    Console.WriteLine("B. Check if it's a trap");
                    Console.WriteLine("C. Go back");
                    string answer2 = Console.ReadLine().ToUpper();
                    while (answer2 != "A" && answer2 != "B" && answer2 != "C")
                    {
                        Console.Write("Enter a valid answer (A, B or C): ");
                        answer2 = Console.ReadLine().ToUpper();
                    }

                    if (answer2 == "A")
                    {
                        string[] explanations1 =
                        {
            "You open it immediately looking for new opportunities, you're curious!",
            "You open it quickly, an exciting and bold approach.",
            "You want to discover new things, you move fast."
        };
                        Random rnd = new Random();
                        int choice1 = rnd.Next(explanations1.Length);
                        Console.WriteLine(explanations1[choice1]);
                    }
                    else if (answer2 == "B")
                    {
                        string[] explanations2 =
                        {
            "You're careful and cautious. You analyze risks.",
            "Checking if it's a trap is a smart approach.",
            "For safety, you proceed with caution considering all possibilities."
        };
                        Random rnd = new Random();
                        int choice2 = rnd.Next(explanations2.Length);
                        Console.WriteLine(explanations2[choice2]);
                    }


                    else if (answer2 == "C")
                    {
                        string[] explanations3 =
                        {
        "You don't take risks, a cautious approach.",
        "You choose a safer path by stepping back.",
        "You avoid risk, prioritizing your safety."
    };
                        Random rnd = new Random();
                        int choice3 = rnd.Next(explanations3.Length);
                        Console.WriteLine(explanations3[choice3]);
                    }

                    // Question 3
                    Console.WriteLine("\n3. You got lost on the road, what do you do?");
                    Console.WriteLine("A. Panic");
                    Console.WriteLine("B. Check the road map");
                    Console.WriteLine("C. Look for a guide");
                    string answer3 = Console.ReadLine().ToUpper();
                    while (answer3 != "A" && answer3 != "B" && answer3 != "C")
                    {
                        Console.Write("Enter a valid answer (A, B or C): ");
                        answer3 = Console.ReadLine().ToUpper();
                    }

                    if (answer3 == "A")
                    {
                        string[] explanations1 =
                        {
        "Panicking is natural but dangerous!",
        "You're getting worried, but panic isn't a solution.",
        "You're afraid of losing control, but you need to stay calm."
    };
                        Random rnd = new Random();
                        int choice1 = rnd.Next(explanations1.Length);
                        Console.WriteLine(explanations1[choice1]);
                    }
                    else if (answer3 == "B")
                    {
                        string[] explanations2 =
                        {
        "You know how to analyze the situation, a logical decision.",
        "You move systematically, you aren't lost because you think smartly.",
        "Checking the map is a good approach to find the right path."
    };
                        Random rnd = new Random();
                        int choice2 = rnd.Next(explanations2.Length);
                        Console.WriteLine(explanations2[choice2]);
                    }
                    else if (answer3 == "C")
                    {
                        string[] explanations3 =
                        {
        "Seeking help is a good option. You're solution-oriented.",
        "You trust other people, getting help might be wise.",
        "Your instincts are guiding you correctly, you're thinking about getting external help."
    };
                        Random rnd = new Random();
                        int choice3 = rnd.Next(explanations3.Length);
                        Console.WriteLine(explanations3[choice3]);
                    }

                    // Question 4
                    Console.WriteLine("\n4. A villager asks for your help. What do you do?");
                    Console.WriteLine("A. Help");
                    Console.WriteLine("B. Assess the situation");
                    Console.WriteLine("C. Decline");
                    string answer4 = Console.ReadLine().ToUpper();
                    while (answer4 != "A" && answer4 != "B" && answer4 != "C")
                    {
                        Console.Write("Enter a valid answer (A, B or C): ");
                        answer4 = Console.ReadLine().ToUpper();
                    }

                    if (answer4 == "A")
                    {
                        string[] explanations1 =
                        {
        "You're helpful and generous, you love to do something for the community.",
        "Helping others makes you happy, you do your best to assist people.",
        "You're generous and helpful, you're ready to make sacrifices for others."
    };
                        Random rnd = new Random();
                        int choice1 = rnd.Next(explanations1.Length);
                        Console.WriteLine(explanations1[choice1]);
                    }
                    else if (answer4 == "B")
                    {
                        string[] explanations2 =
                        {
        "You make a decision based on the situation, questioning if the help is really necessary.",
        "You consider helping, but you decide based on the seriousness of the situation.",
        "You display a wise approach to helping people."
    };
                        Random rnd = new Random();
                        int choice2 = rnd.Next(explanations2.Length);
                        Console.WriteLine(explanations2[choice2]);
                    }
                    else if (answer4 == "C")
                    {
                        string[] explanations3 =
                        {
        "You don't want to help, you choose your own path.",
        "You prioritize your safety, other people's issues don't concern you.",
        "You refuse to help, you have more important things to do."
    };
                        Random rnd = new Random();
                        int choice3 = rnd.Next(explanations3.Length);
                        Console.WriteLine(explanations3[choice3]);
                    }

                    // Question 5
                    Console.WriteLine("\n5. You're looking for a place to set up camp at night. What do you do?");
                    Console.WriteLine("A. Set up camp at the first place I find");
                    Console.WriteLine("B. Look for a safer place");
                    Console.WriteLine("C. Keep walking through the night");
                    string answer5 = Console.ReadLine().ToUpper();
                    while (answer5 != "A" && answer5 != "B" && answer5 != "C")
                    {
                        Console.Write("Enter a valid answer (A, B or C): ");
                        answer5 = Console.ReadLine().ToUpper();
                    }

                    if (answer5 == "A")
                    {
                        string[] explanations5 =
                        {
        "You're making a practical decision, it's important to rest without wasting time.",
        "You make quick decisions, saving energy is important to you.",
        "You choose to rest without wasting time, this keeps you refreshed."
    };
                        Random rnd = new Random();
                        int choice5 = rnd.Next(explanations5.Length);
                        Console.WriteLine(explanations5[choice5]);
                    }
                    else if (answer5 == "B")
                    {
                        string[] explanations5 =
                        {
        "You prioritize safety above all, you don't want to take risks.",
        "You're showing a cautious and careful approach.",
        "You don't think about resting until you feel safe."
    };
                        Random rnd = new Random();
                        int choice5 = rnd.Next(explanations5.Length);
                        Console.WriteLine(explanations5[choice5]);
                    }
                    else if (answer5 == "C")
                    {
                        string[] explanations5 =
                        {
        "You move forward without resting, it's a brave but risky decision.",
        "Continuing without stopping makes you strong, but you should be careful.",
        "You chose to keep going, you're pushing your limits."
    };
                        Random rnd = new Random();
                        int choice5 = rnd.Next(explanations5.Length);
                        Console.WriteLine(explanations5[choice5]);
                    }

                    // Question 6
                    Console.WriteLine("\n6. You're searching for food in a ruined city. Where do you look first?");
                    Console.WriteLine("A. Markets and shops");
                    Console.WriteLine("B. Abandoned houses");
                    Console.WriteLine("C. Randomly search the streets");
                    string answer6 = Console.ReadLine().ToUpper();
                    while (answer6 != "A" && answer6 != "B" && answer6 != "C")
                    {
                        Console.Write("Enter a valid answer (A, B or C): ");
                        answer6 = Console.ReadLine().ToUpper();
                    }

                    if (answer6 == "A")
                    {
                        string[] explanations6 =
                        {
        "You're making a logical choice, markets might be the most reliable source.",
        "You think systematically, prioritizing resources.",
        "You start with the most obvious places, it's a very smart move."
    };
                        Random rnd = new Random();
                        int choice6 = rnd.Next(explanations6.Length);
                        Console.WriteLine(explanations6[choice6]);
                    }
                    else if (answer6 == "B")
                    {
                        string[] explanations6 =
                        {
        "You prefer less known places, facing less competition.",
        "You're carefully searching for hidden resources.",
        "You have a high chance of finding hidden supplies in abandoned houses."
    };
                        Random rnd = new Random();
                        int choice6 = rnd.Next(explanations6.Length);
                        Console.WriteLine(explanations6[choice6]);
                    }
                    else if (answer6 == "C")
                    {
                        string[] explanations6 =
                        {
        "You rely on luck, following a spontaneous route.",
        "You're evaluating the possibility of finding something anywhere.",
        "You cover a wide area, trying to find different resources."
    };
                        Random rnd = new Random();
                        int choice6 = rnd.Next(explanations6.Length);
                        Console.WriteLine(explanations6[choice6]);
                    }

                    // General analysis (Based on player's choices)
                    Console.WriteLine("\n--- General Analysis ---");
                    if (answer1 == "A" && answer2 == "B" && answer3 == "B" && answer4 == "A")
                    {
                        Console.WriteLine("You display a smart and logical approach to survival. When faced with challenges, you analyze the situation and choose the safest path.");
                    }
                    else if (answer1 == "B" && answer2 == "A" && answer3 == "C" && answer4 == "B")
                    {
                        Console.WriteLine("You're a brave and enterprising person, but sometimes you question the risks. As someone who isn't afraid to ask for help, you also value human relationships.");
                    }
                    else
                    {
                        Console.WriteLine("You exhibit different approaches in different situations, making you a versatile and adaptive person.");
                    }

                    // Game ending
                    Console.WriteLine("\nIf you want to end the game, press E. Otherwise, press any key to restart.");
                    if (Console.ReadKey().Key == ConsoleKey.E)
                    {
                        gameOn = false;
                    }
                }
            }
        }
    }
}
