using System;

namespace DP_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            string caract;
            President currentPresident = null;
            do
            {
                Console.WriteLine("Enter a carac");
                caract = Console.ReadLine();
                currentPresident = PresidentFactory.GetPresident(caract);

            } while (currentPresident == null);
            Console.WriteLine(currentPresident.Slogan);
        }
    }
}
