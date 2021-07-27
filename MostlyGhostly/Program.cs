using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace MostlyGhostly
{
    class Program
    {

        public static void Main(string[] args)
        {
            Title();
            questFest();

        }


        //Title
        //All ASCII text was generated from an app at: http://www.network-science.de/ascii/
        public static void Title()
        {
            Console.Title = "Mostly Ghostly";
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            string title = @"                                
                                                                     
         @@@@@@@@@@    @@@@@@    @@@@@@   @@@@@@@  @@@       @@@ @@@  
         @@@@@@@@@@@  @@@@@@@@  @@@@@@@   @@@@@@@  @@@       @@@ @@@  
         @@! @@! @@!  @@!  @@@  !@@         @@!    @@!       @@! !@@  
         !@! !@! !@!  !@!  @!@  !@!         !@!    !@!       !@! @!!  
         @!! !!@ @!@  @!@  !@!  !!@@!!      @!!    @!!        !@!@!   
         !@!   ! !@!  !@!  !!!   !!@!!!     !!!    !!!         @!!!   
         !!:     !!:  !!:  !!!       !:!    !!:    !!:         !!:    
         :!:     :!:  :!:  !:!      !:!     :!:     :!:        :!:    
         :::     ::   ::::: ::  :::: ::      ::     :: ::::     ::    
          :      :     : :  :   :: : :       :     : :: : :     :     
                                                                      
                                                                          
      @@@@@@@@  @@@  @@@   @@@@@@    @@@@@@   @@@@@@@  @@@       @@@ @@@  
     @@@@@@@@@  @@@  @@@  @@@@@@@@  @@@@@@@   @@@@@@@  @@@       @@@ @@@  
     !@@        @@!  @@@  @@!  @@@  !@@         @@!    @@!       @@! !@@  
     !@!        !@!  @!@  !@!  @!@  !@!         !@!    !@!       !@! @!!  
     !@! @!@!@  @!@!@!@!  @!@  !@!  !!@@!!      @!!    @!!        !@!@!   
     !!! !!@!!  !!!@!!!!  !@!  !!!   !!@!!!     !!!    !!!         @!!!   
     :!!   !!:  !!:  !!!  !!:  !!!       !:!    !!:    !!:         !!:    
     :!:   !::  :!:  !:!  :!:  !:!      !:!     :!:     :!:        :!:    
      ::: ::::  ::   :::  ::::: ::  :::: ::      ::     :: ::::     ::    
      :: :: :    :   : :   : :  :   :: : :       :     : :: : :     :     
                                                                          ";

            Console.WriteLine(title);
            Console.ResetColor();
            Thread.Sleep(3000);
            Console.Clear();

        }

        //Introduction: WriteLine with switches

        public static void questFest()
        {
            Console.WriteLine("It is a dark and stormy night and you are driving along a lonely road.");
            Console.WriteLine("Your car, unreliable in the best of times, begins to rattle and shake horrifically.");
            Console.WriteLine("Your front axle breaks as steam erupts from your radiator and you hear your engine block crack.");
            Console.WriteLine("\"Drat,\" you exclaim, somewhat vexed.");
            Console.WriteLine("\"I guess I'd best hoof it from here on,\" you tell yourself rather optimistically.");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Press 'Enter' to continue...");
            Console.ReadLine();
            Console.Clear();
        }

        //Chapter 1: switch & WriteLine

        public static void firstChapter()
        {
            string choice;

            Console.WriteLine("Bats chitter and wolves howl in the distance as the road you'd been driving on soon ends at a forked dirt path.");
            Console.WriteLine("At the end of one path, you can see a dilapidated old mansion.");
            Console.WriteLine("The other path continues for some distance before coming to a dark and eginimatic wood.");
            Console.WriteLine("Looking behind you, you notice that there is now a mysterious woman wearing all white hitchhiking by the road. You had not noticed her as you walked past.");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("What do you choose to do?");
            Console.WriteLine("1. Investigate the dark wood.");
            Console.WriteLine("2. Walk towards the ruinous house.");
            Console.WriteLine("3. Talk to the mysterious hitchhiker.");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Choice: ");
            choice = Console.ReadLine().ToLower();
            Console.ResetColor();
            Console.Clear();

            // cases take a variety of phrases as input and display a default message if input is different than the cases.
            switch (choice)
            {
                case "1":
                case "investigate":
                case "investigate the dark wood":
                    {

                        Console.WriteLine("It's a g-g-g-ghost!.");
                        Console.WriteLine("It says,'Whoo-ooooooo! I am the ghost of a Cannibal Prospector!");
                        Console.WriteLine("It eats you.");
                        Console.WriteLine(" ");
                        Console.WriteLine("Press 'Enter' to continue...");
                        Console.ReadLine();
                        gameOver();
                        break;

                    }

                case "2":
                case "walk":
                case "walk towards house":
                case "house":
                case "ruinous house":
                    {
                        Console.WriteLine("The door creaks heavily on its hinges.");
                        Console.WriteLine("Far too heavily for a merely mortal door.");
                        Console.WriteLine("It is a gate to the abyss!");
                        Console.WriteLine("You fall endlessly for all eternity.");
                        Console.WriteLine(" ");
                        Console.WriteLine("Press 'Enter' to continue...");
                        Console.ReadLine();
                        gameOver();
                        break;

                    }

                case "3":
                case "talk":
                case "talk to hitchhiker":
                case "mysterious hitchhiker":
                case "hitchhiker":
                    {
                        Console.WriteLine("You hear that the Woman in White is weeping as you come closer.");
                        Console.WriteLine("Cautiously, you ask if there is something you can do to help her.");

                        Console.WriteLine(" ");
                        Thread.Sleep(3000);
                        secondChapter();
                        break;

                    }


                default:
                    {
                        Console.WriteLine("I didn't understand that command. Try using the selection number or keywords from the prompt.");
                        Console.WriteLine(" ");
                        Console.WriteLine("Press 'Enter' to try again.");
                        Console.ReadLine();
                        firstChapter();
                        break;
                    }

            }
        }

        //CHAPTER 2 Dictionary with LINQ query
        //    Using LINQ ElementAt to retrieve a key-value pair from a dictionary.


        public static void secondChapter()
        {
            Random random = new Random();
            Dictionary<string, string> scndCptrDict = new Dictionary<string, string>();

            scndCptrDict.Add("asks", "for a ride");
            scndCptrDict.Add("is sobbing", "grievously");
            scndCptrDict.Add("demands", "you guess her age at death");
            scndCptrDict.Add("needs", "a puzzle solved");

            //for (int i = 0; i < 1; ++i) can't be the best way to retrieve just one key/value, but it works.
            for (int i = 0; i < 1; ++i)
            {
                int index = random.Next(scndCptrDict.Count);
                KeyValuePair<string, string> item = scndCptrDict.ElementAt(index);

                Console.WriteLine("The ghost " + item.Key + " " + item.Value + ".");
            }
      

            string secChoice;
            //Changing Console.WriteLine(secText); from version 1.2
            //Console.WriteLine(item);
            Console.WriteLine("Will you help her?");
            Console.Write("Choice: ");
            secChoice = Console.ReadLine().ToLower();

            if (secChoice == "yes" || secChoice == "y")
            {
                thirdChapter();
            }

            else if (secChoice == "no" || secChoice == "n")
            {
                Console.WriteLine("Your actions are cowardly and despicable, or at least careless.");
                Console.WriteLine("The cosmic implications of this one minor mistake weigh upon you as a massive stellar collapse weighs upon spacetime.");
                Console.WriteLine("Press 'Enter' to continue");
                Console.ReadLine();
                gameOver();
            }

            else
            {
                Console.WriteLine("I didn't understand that command. Try using the selection number or keywords from the prompt");
                Console.WriteLine("Press 'Enter' to try again.");
                Console.ReadLine();
                secondChapter();
            }

        }

      
        
        public static void purgatory()
        {
            int YRS, GY;
            float Task, Check;
                Console.Write("You suddenly find yourself somewhat transparent and with a hunger for ectoplasm.");
                Console.Write("\"Great Scott! You've ghosted me,\" you decry to the Phantom Hitchhiker.");
                Console.Write("\"Yes,\" she replies with phantom menace, \"You must complete a task in one-seventh of your age in ghost-years while \n " +
                    "a ghost supervisor checks on you once a ghost year.");

                Console.Write("Enter age in years :");
            YRS = Convert.ToInt32(Console.ReadLine());
            GY = YRS * 100;
            Task = GY / 7;
            Check = Task / 12;
            Console.WriteLine("Your time as a ghost feels like " + GY + " years.");
            Console.WriteLine("Your time to complete your unfinished business is :" + Task + " ghost years.");
            Console.WriteLine("A ghost supervisor will check on you every :" + Check + " ghost years.");
            Thread.Sleep(3000);
            youWin();
        }
     
     
        
        //Chapter 3: while

        static void thirdChapter()
         {
             {
                 Console.WriteLine("you're at ch3");
                 int guessAge = new Random().Next(18, 27);
                 Console.WriteLine("\"How old,\" the ghost beseeches you, \"do you think I was when I tragically died?\"");
                 Thread.Sleep(1500);
                 Console.WriteLine("\"I was somewhere from 18 to 27,\" she adds in an ethereal aside.");
                 int allowedGuesses = 3;
                 int numberOfGuesses = 0;

                 while (true)
                 {
                     int guess = GetGuess();
                     numberOfGuesses++;
                     if (guess == guessAge)
                     {
                         Console.WriteLine("I was {guessAge} when I died along this abandoned stretch of road.");
                         break;
                         youWin();
                     }
                     if (guess > guessAge)
                     {
                         Console.WriteLine("Too high");
                     }
                     if (guess < guessAge)
                     {
                         Console.WriteLine("Too low");
                     }
                     if (numberOfGuesses == allowedGuesses)
                     {
                         Console.WriteLine($"\"My age was {guessAge} when I died!\" she wails.");
                         Console.WriteLine("Her visiage suddenly becomes morbidly bizarre .");
                         Console.WriteLine("\"Didn't you read my obituary in the March 23rd, 1894 issue of the Gazetteville Picayune-Journal?!?!!\" she screams eldrichly.");
                        //gameOver();
                        purgatory();
                         break;

                     }
                     Console.Write($"You have {allowedGuesses - numberOfGuesses} guesses left. Guess again: ");
                 }
             }
        }
        private static int GetGuess()
        {
            int guess = 0;
            try
            {
                guess = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("You did not enter a valid guess.");
                guess = GetGuess();
            }
            return guess;
        }
    }
}


//Endgame
public class Endgame
{ //may have nesting issues here--a whole bunch of errors disappeared when i removed the closing brace...
public static void gameOver()
{ 
        {
            //Console.Clear();

            Console.WriteLine("Choke, Gasp!! You die of shock from sheer terror!");
            Console.WriteLine();
            Thread.Sleep(1500);
            Console.WriteLine("Bummer.");
            Thread.Sleep(3000);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("But a wandering necromancer has offered to raise you from the dead.");
            Console.WriteLine("press 'Enter' to try again.");
            Console.ReadLine();
            Console.Clear();
            questFest();

        }
}

public static void youWin()

            //public class RandoFortune
        

         {
            Random rand = new Random();

             string[] nounOne = { "rabbit", "soldier", "curlew", "robin", "widow" };
             string[] nounTwo = { "hill", "mound", "land", "sea", "bridge", "clock" };
             string[] verbOne = { "reigns", "lies", "eats", "runs", "catches", "trades" };
             string[] rhymeOne = { "at the end", "the dead end", "with kin", "to spend", "to defend", "the weekend", "its friend" };
             string[] adjOne = { "red", "blue", "green", "orange" };
             string[] nounThree = { "cat", "dog" };
             string[] rhymeTwo = { "portend", "impend", "amend", "ascend", "miswend" };

             int n1Index = rand.Next(nounOne.Length);
             int n2Index = rand.Next(nounTwo.Length);
             int v1Index = rand.Next(verbOne.Length);
             int rh1Index = rand.Next(rhymeOne.Length);
             int adj1Index = rand.Next(adjOne.Length);
             int n3Index = rand.Next(nounThree.Length);
             int rh2Index = rand.Next(rhymeTwo.Length);

            Console.WriteLine("The {0} on the {1} {2} {3}", nounOne[n1Index], nounTwo[n2Index], verbOne[v1Index], rhymeOne[rh1Index] + ",");
            Console.WriteLine("While the {0} {1} shall {2}", adjOne[adj1Index], nounThree[n3Index], rhymeTwo[rh2Index] + ".");

        }

     }
     }
 

             Console.Clear();
             Console.WriteLine(" ");
             Console.WriteLine("Congratulations! You escape!");
             Console.WriteLine(" ");
             Console.WriteLine("You walk away, certain that life will return to the way it was before this horror began.");
             Thread.Sleep(2000);
             Console.WriteLine(" ");
             Console.WriteLine(" ");
             Console.ForegroundColor = ConsoleColor.DarkYellow;
             string theEnd = @"
 _________  ___  ___  _______           _______   ________   ________     
 |\___   ___\\  \|\  \|\  ___ \         |\  ___ \ |\   ___  \|\   ___ \    
 \|___ \  \_\ \  \\\  \ \   __/|        \ \   __/|\ \  \\ \  \ \  \_|\ \   
      \ \  \ \ \   __  \ \  \_|/__       \ \  \_|/_\ \  \\ \  \ \  \ \\ \  
       \ \  \ \ \  \ \  \ \  \_|\ \       \ \  \_|\ \ \  \\ \  \ \  \_\\ \ 
        \ \__\ \ \__\ \__\ \_______\       \ \_______\ \__\\ \__\ \_______\
         \|__|  \|__|\|__|\|_______|        \|_______|\|__| \|__|\|_______|";
             Console.WriteLine(theEnd);


             Thread.Sleep(3000);
             Console.WriteLine(" ");
             Console.WriteLine(" ");
             Console.ForegroundColor = ConsoleColor.DarkCyan;
             string coda = @"
   @@@@@@  @@@@@@@       @@@  @@@@@@      @@@ @@@@@@@           @@@@@@ 
  @@!  @@@ @@!  @@@      @@! !@@          @@!   @@!            @@!  @@@
  @!@  !@! @!@!!@!       !!@  !@@!!       !!@   @!!               .!@! 
  !!:  !!! !!: :!!       !!:     !:!      !!:   !!:               ""   
   : :. :   :   : :      :   ::.: :       :      :    :: :: ::    ::   
                                                                       ";
             Console.WriteLine(coda);
             Console.ResetColor();
             Console.ReadLine();
             Console.Clear();
             questFest();
         }
     }
}
            Console.ResetColor();
            firstChapter();

