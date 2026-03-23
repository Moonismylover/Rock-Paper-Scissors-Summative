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
                Console.WriteLine("\tLetter: ");
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

        static void Main(string[] args)
        {
            Introduction();
        }
    }
}
