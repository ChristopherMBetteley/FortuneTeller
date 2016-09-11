//Creates a console application that produces a fortune based
//on the user's answer to questions.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create variables
            string userFirstName;
            string userLastName;
            string userFavColor;
            string colorTest;
            string userVacLoc = "";
            string modeOfTransportation = "";
            string space = " ";
            string quitCommand;
            string userNameFirstLetter;
            string userNameRemainLetters;
            int amountOfMoney;
            int evenRetYear = 26;
            int oddRetYear = 31;
            int menuCommand;
            int userAge;
            int userBirthMonth;
            int userSiblings;
            int numberOfYears = 0;

            while (true)
            {
                Console.WriteLine("Let's see into your future.");
                //Recieve user inputs
                Console.WriteLine("\nWhat is your first name?");
                userFirstName = Console.ReadLine();

                quitCommand = userFirstName.ToUpper();
                if (quitCommand == "QUIT")
                {
                    Console.WriteLine("Nobody likes a quitter.");
                    Console.ReadKey();
                    Environment.Exit(0); ;
                }

                Console.WriteLine("\nWhat is your last name?");
                userLastName = Console.ReadLine();
                quitCommand = userLastName.ToUpper();
                if (quitCommand == "QUIT")
                {
                    Console.WriteLine("Nobody likes a quitter.");
                    Console.ReadKey();
                    Environment.Exit(0); ;
                }

                Console.WriteLine("\nWhat is your age?");
                quitCommand = Console.ReadLine();
                quitCommand = quitCommand.ToUpper();

                if (quitCommand == "QUIT")
                {
                    Console.WriteLine("Nobody likes a quitter.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }


                userAge = int.Parse(quitCommand);


                if ((userAge < 10) && (userAge >= 0))
                {
                    Console.WriteLine("You are awfully young to be using this program.");
                }
                else if ((userAge < 0) || (userAge > 110))
                {
                    Console.WriteLine("I'm begining to think you are not being 100% truthfull.");
                }
                else
                {

                }




                Console.WriteLine("\nWhat is your birth month (as a number)?");
                quitCommand = Console.ReadLine();
                quitCommand = quitCommand.ToUpper();

                if (quitCommand == "QUIT")
                {

                    Console.WriteLine("Nobody likes a quitter.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }

                userBirthMonth = int.Parse(quitCommand);
                if ((userBirthMonth < 1) || (userBirthMonth > 12))
                {
                    Console.WriteLine("\"" + userBirthMonth + "\"" + space + "really?");
                }


                //color data manipulation
                Console.WriteLine("\nWhat is your favorite ROYGBIV color (enter \"Help\" for the list of colors)?");
                userFavColor = Console.ReadLine();
                colorTest = userFavColor.ToUpper();
                quitCommand = colorTest;
                if (quitCommand == "QUIT")
                {

                    return;
                }

                if ((colorTest != "RED") && (colorTest != "ORANGE") && (colorTest != "YELLOW") && (colorTest != "GREEN") &&
                    (colorTest != "BLUE") && (colorTest != "INDIGO") && (colorTest != "VIOLET") && (colorTest != "HELP"))
                {
                    Console.WriteLine("That is not a ROYGBIV color. You Rebel.");
                }

                //loop for color options
                while (true)
                {
                    //lists color options when "Help" is selected
                    if (colorTest != "HELP")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nYour Color Options are:");
                        Console.WriteLine("\tRed \n\tOrange \n\tYellow \n\tGreen \n\tBlue \n\tIndigo \n\tViolet");
                        Console.WriteLine("\nWhat is your favorite ROYGBIV color (enter \"Help\" for the list of colors)?");
                        userFavColor = Console.ReadLine();
                        colorTest = userFavColor.ToUpper();
                        quitCommand = colorTest;
                        if (quitCommand == "QUIT")
                        {
                            Console.WriteLine("Nobody likes a quitter.");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                    }
                }


                Console.WriteLine("\nHow many siblings do you have?");
                quitCommand = Console.ReadLine();
                quitCommand = quitCommand.ToUpper();

                if (quitCommand == "QUIT")
                {
                    Console.WriteLine("Nobody likes a quitter.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }

                userSiblings = int.Parse(quitCommand);
                if (userSiblings < 0)
                {
                    Console.WriteLine("Now that's just not true");
                }


                //Manipulating user inputed data

                //formatting the name output

                userNameFirstLetter = userFirstName.Substring(0, 1);
                userNameFirstLetter = userNameFirstLetter.ToUpper();
                userNameRemainLetters = userFirstName.Remove(0, 1);
                userNameRemainLetters = userNameRemainLetters.ToLower();
                userFirstName = userNameFirstLetter + userNameRemainLetters;

                userNameFirstLetter = userLastName.Substring(0, 1);
                userNameFirstLetter = userNameFirstLetter.ToUpper();
                userNameRemainLetters = userLastName.Remove(0, 1);
                userNameRemainLetters = userNameRemainLetters.ToLower();
                userLastName = userNameFirstLetter + userNameRemainLetters;

                //User age even/odd calculation and years till retirement assignment
                if ((userAge < 125) && (userAge >= 0))
                {
                    if (userAge % 2 == 0)
                    {
                        numberOfYears = evenRetYear;
                    }
                    else
                    {
                        numberOfYears = oddRetYear;
                    }
                }
                else
                {
                    if (userAge % 2 == 0)
                    {
                        numberOfYears = evenRetYear + 100;
                    }
                    else
                    {
                        numberOfYears = oddRetYear + 100;
                    }
                }




                //Number of siblings relation to location of vacation home
                if (userSiblings == 0)
                {
                    userVacLoc = "Hawaii";
                }
                else if (userSiblings == 1)
                {
                    userVacLoc = "New York";
                }
                else if (userSiblings == 2)
                {
                    userVacLoc = "Florida";
                }
                else if (userSiblings >= 3)
                {
                    userVacLoc = "Washington";
                }
                else if (userSiblings < 0)
                {
                    userVacLoc = "\"Beautiful\" Detroit";
                }


                //Favorite ROYGBIV relation to the type of transportation
                switch (userFavColor.ToUpper())
                {
                    case "RED":
                        modeOfTransportation = (space + "car");
                        break;
                    case "ORANGE":
                        modeOfTransportation = (space + "truck");
                        break;
                    case "YELLOW":
                        modeOfTransportation = (space + "submarine");
                        break;
                    case "GREEN":
                        modeOfTransportation = (space + "bicycle");
                        break;
                    case "BLUE":
                        modeOfTransportation = (space + "motorcycle");
                        break;
                    case "INDIGO":
                        modeOfTransportation = (space + "boat");
                        break;
                    case "Violet":
                        modeOfTransportation = (space + "plane");
                        break;
                    default:
                        modeOfTransportation = "n okay pair of shoes";
                        break;
                }

                //birth month relation to the ammount of money in the bank
                if ((userBirthMonth >= 1) && (userBirthMonth <= 4))
                {
                    amountOfMoney = 140000;
                }
                else if ((userBirthMonth >= 5) && (userBirthMonth <= 8))
                {
                    amountOfMoney = 58000;
                }
                else if ((userBirthMonth >= 9) && (userBirthMonth <= 12))
                {
                    amountOfMoney = 912000;
                }
                else
                {
                    amountOfMoney = 0;
                }
                //Console.WriteLine(amountOfMoney.ToString("#,###,###.00"));
                //Fortune print out
                Console.WriteLine("\n************************************");
                Console.WriteLine(userFirstName + space + userLastName + space + "will retire in" + space + (numberOfYears.ToString("#,###")) +
                    space + "years" + space + "with" + space + "$" + (amountOfMoney.ToString("#,###,###.00")) + space + "in the bank, \na vacation home in"
                    + space + userVacLoc + space + "and a" + modeOfTransportation + ".");
                Console.WriteLine("************************************\n\n");


                //exit menu loop
                while (true)
                {
                    Console.WriteLine("\n" + "What should we do next?");
                    Console.WriteLine("\t" + "1. Run program again");
                    Console.WriteLine("\t" + "2. Exit Program");

                    quitCommand = Console.ReadLine();
                    quitCommand = quitCommand.ToUpper();

                    if (quitCommand == "QUIT")
                    {

                        Console.WriteLine("Nobody likes a quitter.");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }

                    menuCommand = int.Parse(quitCommand);


                    if (menuCommand == 1)
                    {
                        Console.WriteLine("\n\n\n");
                        break;
                    }
                    else if (menuCommand == 2)
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid Option" + "\nPlease choose a valid option");
                    }
                }
            }

        }
    }
}
