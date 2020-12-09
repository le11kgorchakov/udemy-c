namespace SetterGetter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Box blue = new Box(3, 4);
            //blue.width = 6;
            blue.Width = 8;
            blue.DisplayBoxInfo();
        }
    }
}