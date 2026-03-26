using System.ComponentModel.Design;
using System.Reflection.Metadata;
using WMPLib;

namespace Rock_Paper_Scissors_Summative
{
    internal class Program
    {
        public static void Introduction()
        {
            Console.Title = "Rock Paper Sicssors Gamble";

            string ans;

            WindowsMediaPlayer player = new WindowsMediaPlayer();
            player.URL = "";
            player.controls.play();

            Console.ReadKey();

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Thread.Sleep(500);
            Console.WriteLine("\t █╗    ██╗███████╗██╗      ██████╗ ██████╗ ███╗   ███╗███████╗");
            Console.WriteLine("\t██║    ██║██╔════╝██║     ██╔════╝██╔═══██╗████╗ ████║██╔════╝");
            Console.WriteLine("\t██║ █╗ ██║█████╗  ██║     ██║     ██║   ██║██╔████╔██║█████╗  ");
            Console.WriteLine("\t██║███╗██║██╔══╝  ██║     ██║     ██║   ██║██║╚██╔╝██║██╔══╝  ");
            Console.WriteLine("\t╚███╔███╔╝███████╗███████╗╚██████╗╚██████╔╝██║ ╚═╝ ██║███████╗");
            Console.WriteLine("\t╚══╝╚══╝╚══════╝╚══════╝ ╚═════╝ ╚═════╝ ╚═╝       ╚═╝╚══════╝");
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.Write("\tA letter has been delivered. Would you like to accept it...yes or no? \n\tAnswer: ");
            Console.ForegroundColor = ConsoleColor.Black;
            ans = Console.ReadLine().ToLower();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            if (ans == "yes")
            {
                Console.WriteLine("\t████████████████████████████████\t __________________________________________________________________________________");
                Console.WriteLine("\t░▀▀███████████████████████████▀▀\t|       CONGRATS! YOU HAVE BEEN ACCEPTED TO PARTICIPATE IN A GAMBLE!               |");
                Console.WriteLine("\t░░░░░▀█████████████████████▀▀░░░\t|                                                                                  |");
                Console.WriteLine("\t██▄▄░░░░▀▀██████████████▀░░░░▄▄█\t|  THIS IS A GAME OF 'ROCK PAPER SCISSOR'! YOU WILL PLAY AGAINST THE BOSS AKA THE  |");
                Console.WriteLine("\t█████▄▄░░░░░▀▀██████▀▀░░░░▄▄████\t|  COMPUTER. AFTER PICKING YOUR MOTION, YOU WILL BET ON WHO YOU THINK WILL WIN THE |");
                Console.WriteLine("\t█████████░░░░░░▀▀▀░░░░░░░▀██████\t|  ROUND. YOU WILL BE GIVEN A BANK BALANCE OF $100. IF YOU LOSE ALL THE CASH       |");
                Console.WriteLine("\t██████▀▀░░░▄▄▄░░░░░░▄▄▄░░░░▀████\t|  BEFORE THE END OR NOT, THE ONE WITH THE MOST POINTS WINS! POINTS ARE GAINED BY  |");
                Console.WriteLine("\t████▀░░░░▄██████▄▄██████▄░░░░███\t|  WINNING THE ROUNDS. YOU GET TO CHOOSE YOUR BETTING AMOUNT! IF YOU GUESS RIGHT,  |");
                Console.WriteLine("\t██▀░░░░▄██████████████████▄░░░▀█\t|  YOU GET DOUBLE THE AMOUNT! THE FINAL WINNER WILL BE DECLARED AFTER 10 ROUNDS OF |");
                Console.WriteLine("\t░░▄▄██████████████████████████▄░\t|  PLAY! GUESS RIGHT = 1+ POINT VS. GUESS WRONG = -1 POINT. GOOD LUCK DEAR FRIEND  |");
                Console.WriteLine("\t▄███████████████████████████████\t|  CAUSE YOU NEED IT LIKE ALWAYS! YOU CAN QUIT AT ANYTIME IF YOU PLEASE!           |");
                Console.WriteLine("\t████████████████████████████████\t|__________________________________________________________________________________|");
                Console.WriteLine();
                Console.WriteLine("\tPress Enter to continue!");

                Console.ReadLine();
                Console.ResetColor();
                Console.Clear();

                game();
            }

            else
            {
                Console.WriteLine("\tYou just missed the chance to earn some money! Too bad! Until next time then!");
                Console.WriteLine();
                Thread.Sleep(1000);
                Console.WriteLine("\t███████▀▀▀░░░░░░░▀▀▀███████");
                Console.WriteLine("\t████▀░░░░░░░░░░░░░░░░░▀████");
                Console.WriteLine("\t███│░░░░░░░░░░░░░░░░░░░│███");
                Console.WriteLine("\t██▌│░░░░░░░░░░░░░░░░░░░│▐██");
                Console.WriteLine("\t██░└┐░░░░░░░░░░░░░░░░░┌┘░██");
                Console.WriteLine("\t██░░└┐░░░░░░░░░░░░░░░┌┘░░██");
                Console.WriteLine("\t██░░┌┘▄▄▄▄▄░░░░░▄▄▄▄▄└┐░░██");
                Console.WriteLine("\t██▌░│██████▌░░░▐██████│░▐██");
                Console.WriteLine("\t███░│▐███▀▀░░▄░░▀▀███▌│░███");
                Console.WriteLine("\t██▀─┘░░░░░░░▐█▌░░░░░░░└─▀██");
                Console.WriteLine("\t██▄░░░▄▄▄▓░░▀█▀░░▓▄▄▄░░░▄██");
                Console.WriteLine("\t████▄─┘██▌░░░░░░░▐██└─▄████");
                Console.WriteLine("\t█████░░▐█─┬┬┬┬┬┬┬─█▌░░█████");
                Console.WriteLine("\t████▌░░░▀┬┼┼┼┼┼┼┼┬▀░░░▐████");
                Console.WriteLine("\t█████▄░░░└┴┴┴┴┴┴┴┘░░░▄█████");
                Console.WriteLine("\t███████▄░░░░░░░░░░░▄███████");
                Console.WriteLine("\t██████████▄▄▄▄▄▄▄██████████");
                return;
            }
        }

        public static void game()
        {
            Console.Title = "Rock Paper Scissor...SHOOT!";

            string user, winner;
            int userChoice, userBalance = 100, userPoints = 0, computerChoice, computerBalance = 100, computerPoints = 0, userBet, betAmount;

            Random generator = new Random();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("\n\tYour username: ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            user = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            for (int round = 1; round <= 10; round = round + 1)
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                Console.WriteLine($"\tRound: {round} ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine();
                Console.WriteLine($"\tHere is data regarding the current positions of the players in the game. \n\n\t{user}: \n\tBank Balance = {userBalance} \n\tPoints = {userPoints} \n\n\tComputer: \n\tBank Balance: {computerBalance} \n\tPoints = {computerPoints}");
                Console.WriteLine();
                Console.Write($"\t{user}! You will input the number assigned to the choice you want! The options include: \n\n\tRock (1) \n\tPaper (2) \n\tScissor (3) \n\tQUIT (4) \n\n\tYour choice: ");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                userChoice = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;

                if (userChoice == 4)
                {
                    Thread.Sleep(500);
                    Console.WriteLine();
                    Console.WriteLine("\tSome people just never try...don't they? Anyways, until next time then!");
                    Console.WriteLine();
                    Thread.Sleep(1000);
                    Console.WriteLine("\t┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                    Console.WriteLine("\t███▀▀▀██┼███▀▀▀███┼███▀█▄█▀███┼██▀▀▀");
                    Console.WriteLine("\t██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼█┼┼┼██┼██┼┼┼");
                    Console.WriteLine("\t██┼┼┼▄▄▄┼██▄▄▄▄▄██┼██┼┼┼▀┼┼┼██┼██▀▀▀");
                    Console.WriteLine("\t██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██┼┼┼");
                    Console.WriteLine("\t███▄▄▄██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██▄▄▄");
                    Console.WriteLine("\t┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                    Console.WriteLine("\t███▀▀▀███┼▀███┼┼██▀┼██▀▀▀┼██▀▀▀▀██▄┼");
                    Console.WriteLine("\t██┼┼┼┼┼██┼┼┼██┼┼██┼┼██┼┼┼┼██┼┼┼┼┼██┼");
                    Console.WriteLine("\t██┼┼┼┼┼██┼┼┼██┼┼██┼┼██▀▀▀┼██▄▄▄▄▄▀▀┼");
                    Console.WriteLine("\t██┼┼┼┼┼██┼┼┼██┼┼█▀┼┼██┼┼┼┼██┼┼┼┼┼██┼");
                    Console.WriteLine("\t███▄▄▄███┼┼┼─▀█▀┼┼─┼██▄▄▄┼██┼┼┼┼┼██▄");
                    Console.WriteLine("\t┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                    Console.WriteLine("\t┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼");
                    Console.WriteLine("\t┼┼┼┼┼┼████▄┼┼┼▄▄▄▄▄▄▄┼┼┼▄████┼┼┼┼┼┼┼");
                    Console.WriteLine("\t┼┼┼┼┼┼┼┼┼▀▀█▄█████████▄█▀▀┼┼┼┼┼┼┼┼┼┼");
                    Console.WriteLine("\t┼┼┼┼┼┼┼┼┼┼┼█████████████┼┼┼┼┼┼┼┼┼┼┼┼");
                    Console.WriteLine("\t┼┼┼┼┼┼┼┼┼┼┼██▀▀▀███▀▀▀██┼┼┼┼┼┼┼┼┼┼┼┼");
                    Console.WriteLine("\t┼┼┼┼┼┼┼┼┼┼┼██┼┼┼███┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼");
                    Console.WriteLine("\t┼┼┼┼┼┼┼┼┼┼┼█████▀▄▀█████┼┼┼┼┼┼┼┼┼┼┼┼");
                    Console.WriteLine("\t┼┼┼┼┼┼┼┼┼┼┼┼███████████┼┼┼┼┼┼┼┼┼┼┼┼┼");
                    Console.WriteLine("\t┼┼┼┼┼┼┼┼▄▄▄██┼┼█▀█▀█┼┼██▄▄▄┼┼┼┼┼┼┼┼┼");
                    Console.WriteLine("\t┼┼┼┼┼┼┼┼▀▀██┼┼┼┼┼┼┼┼┼┼┼██▀▀┼┼┼┼┼┼┼┼┼");
                    Console.WriteLine("\t┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼");
                    Console.WriteLine("\t┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
                    return;
                }

                Console.WriteLine();
                Console.Write("\tWho do you think will win? Options: You (1) or The Computer (2) \n\n\tYour guess: ");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                userBet = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();

                if (userBet != 1 && userBet != 2)
                {
                    Console.WriteLine("\tINVALID INPUT! BYE-BYE~~~");
                    Console.WriteLine();
                    Thread.Sleep(1000);
                    Console.WriteLine("\t███████▀▀▀░░░░░░░▀▀▀███████");
                    Console.WriteLine("\t████▀░░░░░░░░░░░░░░░░░▀████");
                    Console.WriteLine("\t███│░░░░░░░░░░░░░░░░░░░│███");
                    Console.WriteLine("\t██▌│░░░░░░░░░░░░░░░░░░░│▐██");
                    Console.WriteLine("\t██░└┐░░░░░░░░░░░░░░░░░┌┘░██");
                    Console.WriteLine("\t██░░└┐░░░░░░░░░░░░░░░┌┘░░██");
                    Console.WriteLine("\t██░░┌┘▄▄▄▄▄░░░░░▄▄▄▄▄└┐░░██");
                    Console.WriteLine("\t██▌░│██████▌░░░▐██████│░▐██");
                    Console.WriteLine("\t███░│▐███▀▀░░▄░░▀▀███▌│░███");
                    Console.WriteLine("\t██▀─┘░░░░░░░▐█▌░░░░░░░└─▀██");
                    Console.WriteLine("\t██▄░░░▄▄▄▓░░▀█▀░░▓▄▄▄░░░▄██");
                    Console.WriteLine("\t████▄─┘██▌░░░░░░░▐██└─▄████");
                    Console.WriteLine("\t█████░░▐█─┬┬┬┬┬┬┬─█▌░░█████");
                    Console.WriteLine("\t████▌░░░▀┬┼┼┼┼┼┼┼┬▀░░░▐████");
                    Console.WriteLine("\t█████▄░░░└┴┴┴┴┴┴┴┘░░░▄█████");
                    Console.WriteLine("\t███████▄░░░░░░░░░░░▄███████");
                    Console.WriteLine("\t██████████▄▄▄▄▄▄▄██████████");
                    return;
                }

                Console.Write("\tHow much will you bet on it? \n\tInput here: ");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                betAmount = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();

                computerChoice = generator.Next(1, 4);

                if (computerChoice == 1 && userChoice == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\tThe Computer WINS! You LOSE! Rock conquers over Scissor! (¬‿¬)✧ ");
                    computerPoints++;
                    if (userBet == 2)
                    {
                        userBalance = userBalance + (betAmount * 2);
                        Console.WriteLine($"\tEven though you lost the game...You won {(betAmount * 2).ToString("C")} from your bet!");
                    }
                    else if (userBet == 1)
                    {
                        userBalance = userBalance - betAmount;
                        computerBalance = computerBalance + (betAmount * 2);
                        Console.WriteLine($"\tDamn, that's sad...You lost the game...You lost the bet too? Your opponenet won {(betAmount * 2).ToString("C")}!");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (computerChoice == 2 && userChoice == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\tThe Computer WINS! You LOSE! Paper conquers over Rock! (¬‿¬)✧ ");
                    computerPoints++;
                    if (userBet == 2)
                    {
                        userBalance = userBalance + (betAmount * 2);
                        Console.WriteLine($"\tEven though you lost the game...You won {(betAmount * 2).ToString("C")} from your bet!");
                    }
                    else if (userBet == 1)
                    {
                        userBalance = userBalance - betAmount;
                        computerBalance = computerBalance + (betAmount * 2);
                        Console.WriteLine($"\tDamn, that's sad...You lost the game...You lost the bet too? Your opponenet won {(betAmount * 2).ToString("C")}!");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (computerChoice == 3 && userChoice == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\tThe Computer WINS! You LOSE! Scissor conquers over Paper! (¬‿¬)✧ ");
                    computerPoints++;
                    if (userBet == 2)
                    {
                        userBalance = userBalance + (betAmount * 2);
                        Console.WriteLine($"\tEven though you lost the game...You won {(betAmount * 2).ToString("C")} from your bet!");
                    }
                    else if (userBet == 1)
                    {
                        userBalance = userBalance - betAmount;
                        computerBalance = computerBalance + (betAmount * 2);
                        Console.WriteLine($"\tDamn, that's sad...You lost the game...You lost the bet too? Your opponenet won {(betAmount * 2).ToString("C")}!");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (userChoice == 1 && computerChoice == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\t{user} WINS! The Computer LOST! Rock conquers over Scissor! (¬‿¬)✧ ");
                    userPoints++;
                    if (userBet == 1)
                    {
                        userBalance = userBalance + (betAmount * 2);
                        Console.WriteLine($"\tYou WON the game and the BET?! That's some good luck there! You won {(betAmount * 2).ToString("C")}");
                    }
                    if (userBet == 2)
                    {
                        userBalance = userBalance - betAmount;
                        computerBalance = computerBalance + (betAmount * 2);
                        Console.WriteLine($"\tOhhhh...you WON the game yet lost the bet! Your opponent has earned {(betAmount * 2).ToString("C")}");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (userChoice == 2 && computerChoice == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\t{user} WINS! The Computer LOST! Paper conquers over Rock! (¬‿¬)✧ ");
                    userPoints++;
                    if (userBet == 1)
                    {
                        userBalance = userBalance + (betAmount * 2);
                        Console.WriteLine($"\tYou WON the game and the BET?! That's some good luck there! You won {(betAmount * 2).ToString("C")}");
                    }
                    if (userBet == 2)
                    {
                        userBalance = userBalance - betAmount;
                        computerBalance = computerBalance + (betAmount * 2);
                        Console.WriteLine($"\tOhhhh...you WON the game yet lost the bet! Your opponent has earned {(betAmount * 2).ToString("C")}");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (userChoice == 3 && computerChoice == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\t{user} WINS! The Computer LOST! Scissor conquers over Paper! (¬‿¬)✧ ");
                    userPoints++;
                    if (userBet == 1)
                    {
                        userBalance = userBalance + (betAmount * 2);
                        Console.WriteLine($"\tYou WON the game and the BET?! That's some good luck there! You won {(betAmount * 2).ToString("C")}");
                    }
                    if (userBet == 2)
                    {
                        userBalance = userBalance - betAmount;
                        computerBalance = computerBalance + (betAmount * 2);
                        Console.WriteLine($"\tOhhhh...you WON the game yet lost the bet! Your opponent has earned {(betAmount * 2).ToString("C")}");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (userChoice == computerChoice)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\tIt's a TIE! No one lost the game...BUT I'm feeling generous so...EVERYONE GETS A POINT!");
                    userPoints++;
                    computerPoints++;
                    if (userBet == userChoice)
                    {
                        userBalance = userBalance + (betAmount * 2);
                        Console.WriteLine($"\tSince you guessed the result correctly... you gained {(betAmount * 2).ToString("C")}!");
                    }
                    else if (userBet != userChoice)
                    {
                        userBalance = userBalance - betAmount;
                        computerBalance = computerBalance + (betAmount * 2);
                        Console.WriteLine($"\tSince you guessed the result incorrectly... your opponent gained {(betAmount * 2).ToString("C")}!");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                    Console.Clear();
                }

                if (userBalance <= 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("\tHow unfortunate! You ran out of cash! You cannot continue anymore. The winner will be decided based on the points!");
                    Thread.Sleep(2000);
                    Console.WriteLine();
                    Console.WriteLine("\tDRUMROLL.....");
                    Console.WriteLine();
                    Thread.Sleep(3000);
                    if (userBalance > computerBalance)
                    {
                        Console.WriteLine($"\tThe winner of the game is {user}!");
                        Console.WriteLine();
                        Console.WriteLine($"\tEnding Scores: \n\n\t{user}: \n\tBank Balance: {userBalance} \n\tPoints: {userPoints} \n\n\tComputer: \n\tBank Balance: {computerBalance} \n\tPoints: {computerPoints}");
                    }
                    else if (userBalance < computerBalance)
                    {
                        Console.WriteLine($"\tThe winner of the game is the Computer!");
                        Console.WriteLine();
                        Console.WriteLine($"\tEnding Scores: \n\n\t{user}: \n\tBank Balance: {userBalance} \n\tPoints: {userPoints} \n\n\tComputer: \n\tBank Balance: {computerBalance} \n\tPoints: {computerPoints}");
                    }
                    return;
                }

                if (computerBalance <= 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("How nice! Your opponent ran out of cash! The game cannot continue anymore. The winner will be decided based on the points!");
                    Thread.Sleep(2000);
                    Console.WriteLine();
                    Console.WriteLine("DRUMROLL.....");
                    Console.WriteLine();
                    Thread.Sleep(3000);
                    if (userBalance > computerBalance)
                    {
                        Console.WriteLine($"\tThe winner of the game is {user}!");
                        Console.WriteLine();
                        Console.WriteLine($"\tEnding Scores: \n\n\t{user}: \n\tBank Balance: {userBalance} \n\tPoints: {userPoints} \n\n\tComputer: \n\tBank Balance: {computerBalance} \n\tPoints: {computerPoints}");
                    }
                    else if (userBalance < computerBalance)
                    {
                        Console.WriteLine($"\tThe winner of the game is the Computer!");
                        Console.WriteLine();
                        Console.WriteLine($"\tEnding Scores: \n\n\t{user}: \n\tBank Balance: {userBalance} \n\tPoints: {userPoints} \n\n\tComputer: \n\tBank Balance: {computerBalance} \n\tPoints: {computerPoints}");
                    }
                    return;
                }
            }

            Console.WriteLine();
            Thread.Sleep(1500);
            Console.WriteLine("Congrats on finishing the game!");
            Console.WriteLine();
            if (userBalance > computerBalance)
            {
                Console.WriteLine($"\tThe winner of the game is {user}!");
                Console.WriteLine();
                Console.WriteLine($"\tEnding Scores: \n\n\t{user}: \n\tBank Balance: {userBalance} \n\tPoints: {userPoints} \n\n\tComputer: \n\tBank Balance: {computerBalance} \n\tPoints: {computerPoints}");
                Console.WriteLine();
                Console.WriteLine("I guess you ain't as hopeless as I imagined...then until next time! Peace!");
                return;
            }
            else if (userBalance < computerBalance)
            {
                Console.WriteLine($"\tThe winner of the game is the Computer!");
                Console.WriteLine();
                Console.WriteLine($"\tEnding Scores: \n\n\t{user}: \n\tBank Balance: {userBalance} \n\tPoints: {userPoints} \n\n\tComputer: \n\tBank Balance: {computerBalance} \n\tPoints: {computerPoints}");
                Console.WriteLine("Ah...I had already predicted the result...hope to never see you again~~~ Peace!");
                return;
            }
        }

        static void Main(string[] args)
        {
            Introduction();
        } 
    }
}