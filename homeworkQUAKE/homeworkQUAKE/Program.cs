using System;

namespace homeworkQUAKE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello this is my homework and coding practice for week one of GAD154 please enjoy\n" +
                "Kind regards \n" +
                "Emmet Padman 33180169\n\n\n" +
                "Week: 1\n" +
                "Game: Quake\n");

            Console.WriteLine("Question 1: How do these games enable the kind of experience that make you feel like a one man army shredding through a legion of enemies?\n" +
                "Question 2: How does map design, weapon balance, controls and powerups contribute or detract from the experience?\n" +
                "Question 3: What are the design focuses of these games?\n" +
                "4?: \n" +
                "5: End Program\n" +
                "33180169 Emmet Padman\n");


            Console.WriteLine("Please enter the number of the question you want to know the answer of: ");
            int question = Convert.ToInt32(Console.ReadLine());
            while (question != 5)
            {


                switch (question)
                {
                    case 1:
                        Console.WriteLine("Question 1: How do these games enable the kind of experience that make you feel like a one man army shredding through a legion of enemies ?\n");
                        Console.WriteLine("Quake enables players to feel like unstoppable machines by giving the player a large array of weapons and high,\neasy to replenish health and armour pool, comapared to the enemies you are fighting\nIt leads to the player feeling like they are that much stronger than the enemies while still making the player \nvulnerable to enemies by spreading out armour and health resupplies.\nIf the player masters moving around the labyrinthine maps and learns how to dodge enemy attacks through a mastery of the game, the fast paced, responsive and tight movement controls let the player feel like a one man army. \n");
                        break;
                    case 2:
                        Console.WriteLine("Question 2: How does map design, weapon balance, controls and powerups contribute or detract from the experience?\n");
                        Console.WriteLine("Quakes levels are large and sprawling with plenty of places to explore. \nRewarding players who do venture into paths unkown with armour, weapons and health.\nIt does get confusing if you are playing for the first time but after enough playthroughs, \nspeeding through the levels opens up a whole new way to play the game, speedrunning.\nThe sprawling level design detracts from the first experience of the game but adds to later playthroughs by rewarding map knowledge.\n");
                        break;
                    case 3:
                        Console.WriteLine("Question 3: What are the design focuses of these games?\n");
                        Console.WriteLine("The design focuses for these games are, momentum and catharsis. \nClearing out rooms of enemies at break neck speed while managing ammo and health looking for a way out of each level.");
                        break;
                    case 4:
                        Console.WriteLine("You found a secret area!");
                        Console.WriteLine("In my opinion Quake was a fun game to play and it definitely did pioneer the way for 3D shooters. \nI feel that the level design itself aesthetic wise was quite bland, brown castles, thats it.\n");
                        break;
                    default:
                        Console.WriteLine("Enter an integer from 1-5 please: ");
                        break;
                }
                Console.WriteLine("\nPlease enter the number of the question you want to know the answer of: ");
                question = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Reading completed closing program");


        }
    }
}
