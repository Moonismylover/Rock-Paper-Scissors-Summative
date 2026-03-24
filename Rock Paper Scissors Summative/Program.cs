using System.Reflection.Metadata;

namespace Rock_Paper_Scissors_Summative
{
    internal class Program
    {
        public static void Introduction()
        {
            Console.Title = "Rock Paper Sicssors Gamble";

            string ans;

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
                Console.WriteLine("\t████████████████████████████████\t _________________________________________________________________________");
                Console.WriteLine("\t░▀▀███████████████████████████▀▀\t|       CONGRATS! YOU HAVE BEEN ACCEPTED TO PARTICIPATE IN A GAMBLE!      |");
                Console.WriteLine("\t░░░░░▀█████████████████████▀▀░░░\t|                                                                         |");
                Console.WriteLine("\t██▄▄░░░░▀▀██████████████▀░░░░▄▄█\t|  THIS IS A GAME OF 'ROCK PAPERS SCISSORS'! YOU WILL PLAY AGAINST THE    |");
                Console.WriteLine("\t█████▄▄░░░░░▀▀██████▀▀░░░░▄▄████\t|  BOSS AKA THE COMPUTER. AFTER PICKING YOUR MOTION, YOU WILL BET ON WHO  |");
                Console.WriteLine("\t█████████░░░░░░▀▀▀░░░░░░░▀██████\t|  YOU THINK WILL WIN THE ROUND. YOU WILL BE GIVEN A BANK BALANCE OF $100 |");
                Console.WriteLine("\t██████▀▀░░░▄▄▄░░░░░░▄▄▄░░░░▀████\t|  AND IF YOU LOSE ALL THE CASH BEFORE THE END OR NOT, THE ONE WITH THE   |");
                Console.WriteLine("\t████▀░░░░▄██████▄▄██████▄░░░░███\t|  MOST POINTS WINS! YOU GET TO CHOOSE YOUR BETTING AMOUNT, IF YOU GUESS  |");
                Console.WriteLine("\t██▀░░░░▄██████████████████▄░░░▀█\t|  RIGHT, YOU GET DOUBLE! THE FINAL WINNER WILL BE DECLARED AFTER 10      |");
                Console.WriteLine("\t░░▄▄██████████████████████████▄░\t|  ROUNDS OF PLAY! GUESS RIGHT = 1+ POINT VS. GUESS WRONG = -1 POINT.     |");
                Console.WriteLine("\t▄███████████████████████████████\t|  GOOD LUCK DEAR FRIEND! OH! YOU CAN QUIT AT ANYTIME IF YOU PLEASE!      |");
                Console.WriteLine("\t████████████████████████████████\t|_________________________________________________________________________|");
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

            string user;
            int userChoice, userBalance = 100, userPoints = 0, computerChoice, computerBalance = 100, computerPoints = 0, userBet, winner;

            Random generator = new Random();

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("\n\tYour username: ");
            Console.ForegroundColor = ConsoleColor.Black;
            user = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            for (int round = 1; round <= 10; round = round + 1)
            {
                Console.WriteLine($"\tHere is data regarding the current positions of the players in the game. \n\n\t{user}: \n\tBank Balance = {userBalance} \n\tPoints = {userPoints} \n\n\tComputer: \n\tBank Balance: {computerBalance} \n\tPoints = {computerPoints} \n\n\tRound: {round}");
                Console.WriteLine();
                Console.Write($"\t{user}! You will input the number assigned to the choice you want! The options include: \n\n\tRock (1) \n\tPaper (2) \n\tScissor (3) \n\tQUIT (4) \n\n\tYour choice: ");
                Console.ForegroundColor = ConsoleColor.Black;
                userChoice = Convert.ToInt32(Console.ReadLine());

                
            }
        }

        static void Main(string[] args)
        {
            Introduction();
        }
    }
}

//Rock Paper Scissors Summative

//For this mini summative, you will program a fully functional version of Rock Paper
//Scissors (or some
//variant of the game). For full marks, the user needs to be able to bet on their
//choice and be
//informed of their winnings/losings.
//There are three components that will determine your overall mark:
//1.Does it work?
// Can the user make a choice?
// Does the computer make a choice?
// Is the correct winner determined?
// Can the user quit?
//2. How well does it play?
// Is it easy/intuitive to make a choice?
// Is it easy/intuitive to quit?
// Do the prompts tell the user exactly what to do/what has happened?
// Visually organized, appropriate spacing, clear prompts?
// How is bad input handled?
// Are there any bugs? Can the user mess it up?
//3. What additional features have you added?
// Is there a betting system? How are bets validated?
//o When the player runs out of money, the game needs to end?
// Stat tracking.
// Timers.
// Beeps.
// Visuals:
//o Clutter
//o Color
//o ASCII art

//Where to Begin?
//You will need to variables to store the following things at a minimum:
//o Users choice (paper, scissors, rock, quit).
//o Computers choice (paper, scissors, rock).
//o Users bank account.
//o Users bet amount.
//Before the game rounds begin, there should be an introduction explaining how the game is played
//(maybe an option to view the rules)

//Game Flow
//In order to determine what order to do things, it is important to think about what needs to happen
//before the user starts playing the rounds of the game.
// Declare and initialize variables.
//o Does the user need to input any starting values?
// Introduction prompt.
//Once the initial setup is done, what needs to happen inside the game loop?
// The user places a bet.
// The user makes a choice.
// The computer makes a choice.
// The winner is determined.
// The winnings/losings is resolved.
// Is there another round to be played?
//After the game is over, is there some sort of farewell message?
//When the user is expected to input, what mistakes can they make? How will your program recover?
//Don’t forget to make your game look pretty:
//https://sites.google.com/gotvdsb.ca/aldworth/home/ics3u-c/fun-with-the-console

//Marking Rubric
//Level 4 Level 3 Level 2 Level 1
//Game always runs
//correctly: all user
//input is validated,
//winner/winnings
//correctly calculated
//and tracked
//Gameplay flows
//naturally, is highly
//intuitive to use and
//highly visually
//appealing (formatted
//text, spacing)
//Additional features
//used to enhance the
//game (visuals, flow
//control, stats)
//-No/minimal teacher
//assistance required

//Game mostly runs
//correctly: user input is
//mostly validated,
//winner/winnings
//correctly calculated

//Gameplay flows well
//is intuitive to use and
//visually appealing
//(formatted text,
//spacing)

//At least one additional
//feature used to
//enhance the game
//(visuals, flow control,
//stats)
//-Some teacher
//assistance required

//Game somewhat runs
//correctly: input is
//somewhat validated,
//winner correctly
//calculated, some
//bugs may be present
//Gameplay somewhat
//flows well, is
//somewhat intuitive to
//use and somewhat
//visually appealing

//No additional features
//used to enhance
//game.

//-Teacher assistance
//required frequently

//Game runs but:
//contains multiple
//bugs

//Gameplay feels
//awkward, is not
//intuitive to use and is
//not visually appealing

//Not all features
//present.