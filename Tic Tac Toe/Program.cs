namespace TIC_TAC_TOE
{
    class Program
    {
        // האפס נוצר לנוחות כדי להתאים את מספר המשבצת למספר המיקום המערך
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1; 
        static int choice;
        static int flag = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a name of player 1");
            string player1 = Console.ReadLine();
            Console.WriteLine("Enter a name of player 2");
            string player2 = Console.ReadLine();
            do
            {
                Console.Clear();
                Console.WriteLine($"{player1}:X and {player2}:O");
                Console.WriteLine("\n");
                if (player % 2 == 0)
                {
                    Console.WriteLine($"{player2} Chance");
                }
                else
                {
                    Console.WriteLine($"{player1} Chance");
                }
                Console.WriteLine("\n");
                Board();
                choice = int.Parse(Console.ReadLine());
                while (choice > 9 || choice < 1)
                {
                    Console.WriteLine("Please cohice a number between 1 to 9");
                    choice = int.Parse(Console.ReadLine());
                }
                if (arr[choice] != 'X' && arr[choice] != 'O')
                {
                    if (player % 2 == 0)
                    {
                        arr[choice] = 'O';
                        player++;
                    }
                    else
                    {
                        arr[choice] = 'X';
                        player++;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry the row {0} is already marked with {1}", choice, arr[choice]);
                    Console.WriteLine("\n");
                    Console.WriteLine("Please wait 2 second board is loading again.....");
                    Thread.Sleep(2000);
                }
                flag = CheckWin();
            }
            while (flag != 1 && flag != -1);
           
            Console.Clear();
            Board();
            if (flag == 1)
            {
                if (player % 2 == 0)
                {
                    Console.WriteLine($"{player1} has won");
                }
                else
                {
                    Console.WriteLine($"{player2} has won");
                }
            }
            else
            {
                Console.WriteLine("Draw");
            }
            Console.ReadLine();
        }
        static void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("     |     |      ");
        }
        static int CheckWin()
        {
            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                return 1;
            }
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                return 1;
            }
            else if (arr[6] == arr[7] && arr[7] == arr[8])
            {
                return 1;
            }
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return 1;
            }
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }
            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                return 1;
            }
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return 1;
            }
            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                return 1;
            }
            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}