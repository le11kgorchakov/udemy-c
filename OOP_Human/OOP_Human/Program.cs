namespace OOP_Human
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Human alex = new Human("Alexey", "Gorchakov", "green");
            //alex.firstName = "Alexey";
            //alex.lastName = "Gorchakov";

            alex.Inrtoduce();
        }
    }
}