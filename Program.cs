using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TestGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Text_Based_RPG();
            ACT_I("Gabriel", 0, 0, 0);
        }
        private static void Text_Based_RPG()
        {
            int playerNumber = 0;   //if player number = 0 he is in the bedroom, if it's 1 he is in the bathroom, 2 is downstairs, etc.

            bool playAgain = true;

            string charName = "";
            int charLevel = 0;
            int charEXP = 0;
            int money = 0;

            NameCreation();

            Console.Clear();
            Statistics(charLevel, charEXP, money);
            Console.WriteLine(string.Format("{0,25}", "---  ACT I  ---"));
            Console.WriteLine("\n---  PRESS ANY KEY TO CONTINUE  ---");
            Console.ReadKey();

            ACT_I(charName,charLevel,money,charEXP);
            
        }
        public static void ACT_I(string charName, int charLevel, int money, int charEXP)
        {
            Console.Clear();
            int numOfBedroomChoices = Bedroom.NumberOfBedroomChoices();
            int numbOfBathroomChoices = Bathroom.NumberOfBathroomChoices();
            string strangerWife = "Stranger";
            int numberFromUser = 0;
    
            Statistics(charLevel,charEXP,money);
            Console.WriteLine("Asia - Heat of the moment, playing on the radio, it's a nice spring morning, the sun is shining down" +
                              " to a sleeping man, through yellow courtains, it makes the room bath in warm golden colors.\n\n" +
                             $"{strangerWife}: \"Hey... you are finally awake, you should get dressed or you'll be late from work!\"\n"+
                              "\n(1) Get ready silently      (2) \"Who are you?\"      (3) \"Okay\"");

            //NumberCheck(3, numberFromUser);

            //It's a test to see if the method works in the actual game without calling it, just the plain code, and it does
            int numberOfOptions = 3;

            switch (numberOfOptions)
            {
                case 1:
                    while (numberFromUser != 1)
                    {
                        while (!int.TryParse(Console.ReadLine(), out numberFromUser))
                        {
                            Console.WriteLine("\nThat's not a number");
                        }
                        Console.WriteLine("Choose between your options");
                    }
                    break;
                case 2:
                    while (numberFromUser != 1 && numberFromUser != 2)
                    {
                        while (!int.TryParse(Console.ReadLine(), out numberFromUser))
                        {
                            Console.WriteLine("\nThat's not a number");
                        }
                        Console.WriteLine("Choose between your options");

                    }
                    break;
                case 3:
                    while (numberFromUser != 1 && numberFromUser != 2 && numberFromUser != 3)
                    {
                        while (!int.TryParse(Console.ReadLine(), out numberFromUser))
                        {
                            Console.WriteLine("\nThat's not a number");
                        }
                        Console.WriteLine("Choose between your options");

                    }
                    break;
                case 4:
                    while (numberFromUser != 1 && numberFromUser != 2 && numberFromUser != 3 && numberFromUser != 4)
                    {
                        while (!int.TryParse(Console.ReadLine(), out numberFromUser))
                        {
                            Console.WriteLine("\nThat's not a number");
                        }
                        Console.WriteLine("Choose between your options");

                    }
                    break;
                case 5:
                    while (numberFromUser != 1 && numberFromUser != 2 && numberFromUser != 3 && numberFromUser != 4 && numberFromUser != 5)
                    {
                        while (!int.TryParse(Console.ReadLine(), out numberFromUser))
                        {
                            Console.WriteLine("\nThat's not a number");
                        }
                        Console.WriteLine("\nChoose between your options please");

                    }
                    break;
                default:
                    break;
            }
            switch (numberFromUser)
            {
                case 1: //          prologue - bedroom
                    Console.Clear();
                    Statistics(charLevel, charEXP, money);
                    Console.WriteLine($"{strangerWife}: \"Still sleepy a bit? Understandable, after yesterday, it was some parade huh?");
                    Console.WriteLine($"{strangerWife}: But seriously, go get ready and come down, I'm not joking, you'll be late\"");
                    Console.WriteLine("You get ready for work, take a warm shower, brush your teeth, get dressed" +
                        " and get ready to head down for breakfast.");
                    break;
                case 2: //      prologue - bedroom
                    Console.Clear();
                    Statistics(charLevel, charEXP, money);
                    strangerWife = "Wife";
                    Console.WriteLine($"{strangerWife}: \"Funny... What do you mean who I am, the only idiot who'd marry you...\n" +
                        "now seriously, get ready or you'll be late.\"");
                    Console.WriteLine("\nYou get ready for work, take a warm shower, brush your teeth, get dressed" +
                        " and get ready to head down for breakfast.");
                    break;
                case 3:     // prologue - bedroom
                    Console.Clear();
                    Statistics(charLevel, charEXP, money);
                    Console.WriteLine($"{strangerWife}: \"Good boy, I'll be in the kitchen.\"");
                    Console.WriteLine("You get ready for work, take a warm shower, brush your teeth, get dressed" +
                        " and get ready to head down for breakfast.");
                    break;
                default:
                    break;
            }
            Console.ReadKey();
            Bedroom.Choices();

            NumberCheck(numOfBedroomChoices, numberFromUser);
            switch (numberFromUser)
            {
                case 1: //                  bedroom
                    Console.Clear();
                    Statistics(charLevel, charEXP, money);
                    Bedroom.Descripion(charName,strangerWife);

                    strangerWife = "Sarah";

                    break;
                case 2:
                    
                    break;

                case 3:

                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
       public static void Prologue()
        {

        }
        public static void Statistics(int charLevel, int charEXP, int money)
        {
            Console.WriteLine($"Level - {charLevel}\n" +
                              $"EXP   - {charEXP}\n" +
                              $"Money - {money}" +
                               "\n\n\n\n\n\n\n\n\n\n");
        }

        //Although, this one doesn't work, I tried to use void, so it'll just have a number or int to return the selected number by the user
        
        public static int NumberCheck(int numberOfOptions, int numberFromUser)
        {
            switch (numberOfOptions)
            {
                case 1:
                    while (numberFromUser != 1)
                    {
                        while (!int.TryParse(Console.ReadLine(), out numberFromUser))
                        {
                            Console.WriteLine("\nThat's not a number");
                        }
                        Console.WriteLine("Choose between your options");
                    }
                    return numberFromUser;
                    break;
                case 2:
                    while (numberFromUser != 1 && numberFromUser != 2)
                    {
                        while (!int.TryParse(Console.ReadLine(), out numberFromUser))
                        {
                            Console.WriteLine("\nThat's not a number");
                        }
                        Console.WriteLine("Choose between your options");
                    }
                    return numberFromUser;
                    break;
                case 3:
                    while (numberFromUser != 1 && numberFromUser != 2 && numberFromUser != 3)
                    {
                        while (!int.TryParse(Console.ReadLine(), out numberFromUser))
                        {
                            Console.WriteLine("\nThat's not a number");
                        }
                        Console.WriteLine("Choose between your options");
                    }
                    return numberFromUser;
                    break;
                case 4:
                    while (numberFromUser != 1 && numberFromUser != 2 && numberFromUser != 3 && numberFromUser != 4)
                    {
                        while (!int.TryParse(Console.ReadLine(), out numberFromUser))
                        {
                            Console.WriteLine("\nThat's not a number");
                        }
                        Console.WriteLine("Choose between your options");
                    }
                    return numberFromUser;
                    break;
                case 5:
                    while (numberFromUser != 1 && numberFromUser != 2 && numberFromUser != 3 && numberFromUser != 4 && numberFromUser != 5)
                    {
                        while (!int.TryParse(Console.ReadLine(), out numberFromUser))
                        {
                            Console.WriteLine("\nThat's not a number");
                        }
                        Console.WriteLine("\nChoose between your options please");
                    }
                    return numberFromUser;
                    break;
                default:
                    break;
            }
            return numberFromUser;
           
        }
        public static void NameCreation()
        {
            string charName = "";
            bool noItIsNotMyCharacterName = true;

            while (noItIsNotMyCharacterName)
            {
                Console.Write("Enter your character's name : ");
                charName = Console.ReadLine();

                bool letterCheck = Regex.IsMatch(charName, @"^[\p{L}]+$");

                while (charName.Length == 0)
                {
                    Console.WriteLine("\nYou have to type in a username to create a character");
                    Console.WriteLine("\n\n---  PRESS ANY KEY TO CONTINUE  ---");
                    Console.ReadKey();
                    Console.Clear();
                    Console.Write("Enter your character's name : ");
                    charName = Console.ReadLine();

                    letterCheck = Regex.IsMatch(charName, @"^[\p{L}]+$");

                    while (letterCheck == false)
                    {
                        Console.WriteLine("No numbers allowed or special characters allowed");
                        charName = Console.ReadLine().ToUpper();
                        letterCheck = Regex.IsMatch(charName, @"^[\p{L}]+$");
                    }
                }

                while (letterCheck == false)
                {
                    Console.WriteLine("No numbers allowed or special characters allowed");
                    charName = Console.ReadLine().ToUpper();
                    letterCheck = Regex.IsMatch(charName, @"^[\p{L}]+$");
                }

                while (charName.Length > 12)
                {
                    Console.WriteLine("\nCharacter name too long, it can be 12 letters at most.");
                    Console.WriteLine("\n\n---  PRESS ANY KEY TO CONTINUE  ---");
                    Console.ReadKey();
                    Console.Clear();
                    Console.Write("Enter your character's name : ");
                    charName = Console.ReadLine();

                    letterCheck = Regex.IsMatch(charName, @"^[\p{L}]+$");

                    while (letterCheck == false)
                    {
                        Console.WriteLine("No numbers allowed or special characters allowed");
                        charName = Console.ReadLine().ToUpper();
                        letterCheck = Regex.IsMatch(charName, @"^[\p{L}]+$");
                    }
                }

                while (charName.Length == 0)
                {
                    Console.WriteLine("\nYou have to type in a username to create a character");
                    Console.WriteLine("\n\n---  PRESS ANY KEY TO CONTINUE  ---");
                    Console.ReadKey();
                    Console.Clear();
                    Console.Write("Enter your character's name : ");
                    charName = Console.ReadLine();

                    letterCheck = Regex.IsMatch(charName, @"^[\p{L}]+$");

                    while (letterCheck == false)
                    {
                        Console.WriteLine("No numbers allowed or special characters allowed");
                        charName = Console.ReadLine().ToUpper();
                        letterCheck = Regex.IsMatch(charName, @"^[\p{L}]+$");
                    }
                }



                Console.WriteLine("\nAre you sure? You can't change it later.\n" +
                                  "Y - Yes, I do!\tN - No, I've changed my mind");
                string answer = Console.ReadLine().ToUpper();

                while (!answer.Equals("Y") && !answer.Equals("N"))
                {
                    Console.WriteLine("Please use Y or N");
                    answer = Console.ReadLine().ToUpper();
                }
                if (answer.Equals("Y"))
                {
                    Console.Clear();
                    switch (charName.Length)
                    {
                        case 1:
                            Console.Write(string.Format("{0,21}", "Welcome "));
                            break;
                        case 2:
                            Console.Write(string.Format("{0,20}", "Welcome "));
                            break;
                        case 3:
                            Console.Write(string.Format("{0,20}", "Welcome "));
                            break;
                        case 4:
                            Console.Write(string.Format("{0,19}", "Welcome "));
                            break;
                        case 5:
                            Console.Write(string.Format("{0,19}", "Welcome "));
                            break;
                        case 6:
                            Console.Write(string.Format("{0,18}", "Welcome "));
                            break;
                        case 7:
                            Console.Write(string.Format("{0,18}", "Welcome "));
                            break;
                        case 8:
                            Console.Write(string.Format("{0,17}", "Welcome "));
                            break;
                        case 9:
                            Console.Write(string.Format("{0,17}", "Welcome "));
                            break;
                        case 10:
                            Console.Write(string.Format("{0,16}", "Welcome "));
                            break;
                        case 11:
                            Console.Write(string.Format("{0,16}", "Welcome "));
                            break;
                        case 12:
                            Console.Write(string.Format("{0,15}", "Welcome "));
                            break;

                        default:

                            break;
                    }

                    Console.WriteLine(string.Format("{0,0}", charName));
                    Console.WriteLine("\n\n---  PRESS ANY KEY TO CONTINUE  ---");
                    noItIsNotMyCharacterName = false;

                    Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    noItIsNotMyCharacterName = true;
                }
            }

        }
    }
}

