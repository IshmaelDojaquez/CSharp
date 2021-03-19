using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace TicTacToe
{
    class Program

    {

        //This array is used to mark the different positions on the board
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        //By default the player is set to 1
        static int player = 1;
        //This variable stores the users placement of their X
        static int userschoice;
        //Random number generator for computer
        static Random random = new Random();
        //This variable stores the computers placement of the O
        static int computerschoice;
        //Variable to determine win
        static int win = 0;
        //List to track the positions used vs what is available
        static List<int> numbersused = new List<int>();

        static void Main(string[] args)
        {
            //Rules
            Rules();
            win = int.Parse(Console.ReadLine());
            do
            {
                //Whenever the game begins... clear the board  
                Console.Clear();

                //Creating the board
                Board();

                //Playing portion
                //Players turn
                userschoice = int.Parse(Console.ReadLine());
                //Checking to see if there is already a X or O in that position
                if (arr[userschoice] != 'X' && arr[userschoice] != 'O')
                {
                    arr[userschoice] = 'X';
                }
                //Add users choice to list
                numbersused.Add(userschoice);

                if(numbersused.Count == 9)
                {
                    //Check for win
                    win = CheckWin();
                    //Draw Message
                    DrawMessage();
                    break;

                }

                //Computers turn
                do
                {
                    computerschoice = random.Next(1, 9);
                } while (numbersused.Contains(computerschoice));
                numbersused.Add(computerschoice);
                arr[computerschoice] = 'O';

                //Checking for win
                win = CheckWin();
                //Continue if there is not a winner or the board is not filled
            } while (win != 1 && win != -1);


            //Clearing the console
            Console.Clear();
            //Filling board once again
            Board();
            //Winners message
            WinnerMessage();
            //Draw Message
            DrawMessage();



        }

        private static void DrawMessage()
        {
            if(win == -1)
            {
                Console.Clear();
                Board();
                Console.WriteLine("It was a draw.");
            }
        }

        private static void WinnerMessage()
        {
            if (win == 1)
            {
                Console.WriteLine(" has won!");
            }
        }

        //Rules Method
        private static void Rules()
        {
            Console.WriteLine("Player: X's");
            Console.WriteLine("Computer: O's\n");
            Console.WriteLine("The board positions are marked 1-9... ");
            Console.WriteLine("Type the number where you wish your X to be placed.");
            Console.WriteLine("Try to beat the computer!\n");
            Console.WriteLine("Press 0 to begin:");
        }

        //Creating Board Method
        private static void Board()
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

        //Checking for Win
        private static int CheckWin()
        {
            //Checking Win by Rows
            //First Row
            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                return 1;
            }
            //Second Row 
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                return 1;
            }
            //Third Row
            else if (arr[6] == arr[7] && arr[7] == arr[8])
            {
                return 1;
            }
            //Checking Win by Columns
            //First Column 
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return 1;
            }
            //Second Column
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }
            //Third Column 
            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                return 1;
            }
            //Checking Win by Diagnols                      
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return 1;
            }
            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                return 1;
            }
            //Used to continue the game until a draw or win
            else if(numbersused.Count() == 9)
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
