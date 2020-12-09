using System;

namespace TicTacToe
{
    internal class Game : Fields
    {
        protected static int player = 1;
        protected static char[] playerChars = { 'X', 'O' };
        protected static bool inputCorrect = true;
        protected static int input = 0;
        protected static int turns = 0;

        protected static void SetField()
        {
            Console.Clear();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("  {0}  |  {1}  |  {2}  ", playField[i, 0], playField[i, 1], playField[i, 2]);
                for (int j = 0; j < 1; j++)
                {
                    if (i < 2)
                    {
                        Console.WriteLine("_____|_____|_____");
                        Console.WriteLine("     |     |     ");
                    }
                }
            }
            turns++;
        }

        protected static void ResetField()
        {
            char[,] playFieldInit =
        {
            {'1','2','3' },
            {'4','5','6' },
            {'7','8','9' }
        };
            playField = playFieldInit;
            SetField();
            turns = 0;
        }

        internal void EnterXofO(object playerChar, int getInput)
        {
            throw new NotImplementedException();
        }

        protected static void EnterXofO(char playerSign, int input)
        {
            switch (input)
            {
                case 1: one = playerSign; break;
                case 2: two = playerSign; break;
                case 3: three = playerSign; break;
                case 4: four = playerSign; break;
                case 5: five = playerSign; break;
                case 6: six = playerSign; break;
                case 7: seven = playerSign; break;
                case 8: eight = playerSign; break;
                case 9: nine = playerSign; break;
            }
        }
    }
}