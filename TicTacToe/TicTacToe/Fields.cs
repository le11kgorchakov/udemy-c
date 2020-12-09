namespace TicTacToe
{
    internal class Fields
    {
        protected static char[,] playField =
{
            {'1','2','3' },
            {'4','5','6' },
            {'7','8','9' }
        };

        public static char one = playField[0, 0];
        public static char two = playField[0, 1];
        public static char three = playField[0, 2];
        public static char four = playField[1, 0];
        public static char five = playField[1, 1];
        public static char six = playField[1, 2];
        public static char seven = playField[2, 0];
        public static char eight = playField[2, 1];
        public static char nine = playField[2, 2];
    }
}