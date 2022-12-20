using System;

namespace TicTacToe
{
    internal class Program
    {
        static char[,] playfield =
        {
            {'1','2','3'},
            {'4','5','6'},
            {'7','8','9'},
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Tic-Tac-Toe");
            int draw = 0;
            int player = 1;
            char playerSign = 'X';

            int fieldNumber = 0;
            PlayArea();
            do
            {
                if (!winChecker())
                {
                    if (draw == 9)
                    {
                        Console.WriteLine("It is draw!");

                        Console.Write("Write 'restart' to reset, 'author' to see author's information, 'exit' to stop playing: ");
                        string output = Console.ReadLine();

                        if (output == "restart")
                        {
                            Console.Clear();
                            ResetArea();
                            draw = 0;
                        }

                        else if (output == "exit")
                            break;
                        else if (output == "author")
                        {
                            Console.Clear();
                            Console.WriteLine("Author:");
                            Console.WriteLine("Emre KANAT");
                            Console.WriteLine("E-mail: ekanatx@gmail.com");
                            break;
                        }

                        else
                            continue;
                    }
                    if (player == 1)
                    { player = 2; playerSign = 'X'; Console.Write("Player 1, enter a number to put 'X' : "); }

                    else if (player == 2)
                    { player = 1; playerSign = 'O'; Console.Write("Player 2, enter a number to put 'O' : "); }
                    while (true)
                    {
                        if (int.TryParse(Console.ReadLine(), out fieldNumber) && fieldNumber < 10 && fieldNumber > 0)
                        {
                            if (fieldNumber == 1 && playfield[0, 0] == 'X' || fieldNumber == 1 && playfield[0, 0] == 'O') { Console.Write("Invalid try again : "); continue; }
                            if (fieldNumber == 2 && playfield[0, 1] == 'X' || fieldNumber == 2 && playfield[0, 1] == 'O') { Console.Write("Invalid try again : "); continue; }
                            if (fieldNumber == 3 && playfield[0, 2] == 'X' || fieldNumber == 3 && playfield[0, 2] == 'O') { Console.Write("Invalid try again : "); continue; }
                            if (fieldNumber == 4 && playfield[1, 0] == 'X' || fieldNumber == 4 && playfield[1, 0] == 'O') { Console.Write("Invalid try again : "); continue; }
                            if (fieldNumber == 5 && playfield[1, 1] == 'X' || fieldNumber == 5 && playfield[1, 1] == 'O') { Console.Write("Invalid try again : "); continue; }
                            if (fieldNumber == 6 && playfield[1, 2] == 'X' || fieldNumber == 6 && playfield[1, 2] == 'O') { Console.Write("Invalid try again : "); continue; }
                            if (fieldNumber == 7 && playfield[2, 0] == 'X' || fieldNumber == 7 && playfield[2, 0] == 'O') { Console.Write("Invalid try again : "); continue; }
                            if (fieldNumber == 8 && playfield[2, 1] == 'X' || fieldNumber == 8 && playfield[2, 1] == 'O') { Console.Write("Invalid try again : "); continue; }
                            if (fieldNumber == 9 && playfield[2, 2] == 'X' || fieldNumber == 9 && playfield[2, 2] == 'O') { Console.Write("Invalid try again : "); continue; }

                            switch (fieldNumber)
                            {
                                case 1: playfield[0, 0] = playerSign; break;
                                case 2: playfield[0, 1] = playerSign; break;
                                case 3: playfield[0, 2] = playerSign; break;
                                case 4: playfield[1, 0] = playerSign; break;
                                case 5: playfield[1, 1] = playerSign; break;
                                case 6: playfield[1, 2] = playerSign; break;
                                case 7: playfield[2, 0] = playerSign; break;
                                case 8: playfield[2, 1] = playerSign; break;
                                case 9: playfield[2, 2] = playerSign; break;
                            }
                            Console.Clear();
                            PlayArea();
                            draw++;

                            break;
                        }
                        else
                            Console.Write("Invalid try again : ");
                    }

                }

                else
                {
                    if (player == 1)
                        Console.WriteLine("Player 2 won.");
                        
                    if (player == 2)
                        Console.WriteLine("Player 1 won.");

                    Console.Write("Write 'restart' to reset, 'author' to see author's information, 'exit' to stop playing: ");
                    string output = Console.ReadLine();

                    if (output == "restart")
                    {
                        Console.Clear();
                        ResetArea();
                        draw = 0;
                    }
                    else if (output == "exit")
                        break;
                    else if (output == "author")
                    {
                        Console.Clear();
                        Console.WriteLine("Author:");
                        Console.WriteLine("Emre KANAT");
                        Console.WriteLine("E-mail: ekanatx@gmail.com");
                        break;
                    }
                }


            } while (true);

        }
        static bool winChecker()
        {
            for (int i = 0; i < 3; i++)
            {
                if (playfield[i, 0] == playfield[i, 1] && playfield[i, 1] == playfield[i, 2])
                    return true;

                else if (playfield[0, i] == playfield[1, i] && playfield[1, i] == playfield[2, i])
                    return true;
            }

            if (playfield[0, 0] == playfield[1, 1] && playfield[1, 1] == playfield[2, 2])
                return true;

            else if (playfield[0, 2] == playfield[1, 1] && playfield[1, 1] == playfield[2, 0])
                return true;

            return false;
        }

        static void PlayArea()
        {
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", playfield[0, 0], playfield[0, 1], playfield[0, 2]);
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", playfield[1, 0], playfield[1, 1], playfield[1, 2]);
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", playfield[2, 0], playfield[2, 1], playfield[2, 2]);
            Console.WriteLine("   |   |   ");
            Console.WriteLine("____________");
        }

        static void ResetArea()
        {
            playfield[0, 0] = '1';
            playfield[0, 1] = '2';
            playfield[0, 2] = '3';
            playfield[1, 0] = '4';
            playfield[1, 1] = '5';
            playfield[1, 2] = '6';
            playfield[2, 0] = '7';
            playfield[2, 1] = '8';
            playfield[2, 2] = '9';
            PlayArea();
        }

    }
};