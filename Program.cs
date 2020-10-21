using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates a basic command line UI
            Console.WriteLine("|---------------------------------|");
            Console.WriteLine("| Lets Play Rock Paper Scissors.  |");
            Console.WriteLine("| Enter an Option:                |");
            Console.WriteLine("| 1 - Rock                        |");
            Console.WriteLine("| 2 - Paper                       |");
            Console.WriteLine("| 3 - Scissors                    |");
            Console.WriteLine("|---------------------------------|");

            int userSelection = Convert.ToInt32(Console.ReadLine()); //Console.Readline() only takes in strings so it has to be converted into an integer. 


            Random randObj = new Random(); //Creates a new random object to use          
            int compSelection = randObj.Next(1,4); //Uses the random object to generate a random number between 1 and 4 -so 1, 2, 3

            //This selects which option the computer picks so it can be outputed
            string compSelectionChoice = "";
            if (compSelection == 1){
                compSelectionChoice = "Rock";
            }
            else if (compSelection == 2){
                compSelectionChoice = "Paper";
            }
            else if (compSelection == 3){
                compSelectionChoice = "Scissors";
            }

            Console.WriteLine("The computer chose {0} \nTherefore:", compSelectionChoice); //Replaces {0} with the 0th variable at the end which is compSelectionChoice

            switch (userSelection) //Switch Case Statement
	        {
                //Player Picks Rock
                case 1:
                    if (compSelection == 2)
                    {
                        Console.WriteLine("Computer Wins! \nTry Again");
                    }
                    else if (compSelection == 3)
                    {
                        Console.WriteLine("You Win! \nWell Done!");
                    }
                    else
                    {
                        Console.WriteLine("You Draw! \nTry Again");
                    }
                break;
                //Player Picks Paper
                case 2:
                    if (compSelection == 3)
                    {
                        Console.WriteLine("Computer Wins! \nTry Again");
                    }
                    else if (compSelection == 1)
                    {
                        Console.WriteLine("You Win! \nWell Done!");
                    }
                    else
                    {
                        Console.WriteLine("You Draw! \nTry Again");
                    }  
                break;
                //Player Picks Scissors
                case 3:
                    if (compSelection == 1)
                    {
                        Console.WriteLine("Computer Wins! \nTry Again");
                    }
                    else if (compSelection == 2)
                    {
                        Console.WriteLine("You Win! \nWell Done!");
                    }
                    else
                    {
                        Console.WriteLine("You Draw! \nTry Again");
                    }
                break;
                //What runs if none of the cases match
                default:
                    Console.WriteLine("You Entered an Incorrect value!");
                break;

            }




        }
    }
}
