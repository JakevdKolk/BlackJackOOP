using System.Security.Cryptography.X509Certificates;

namespace BlackJackOOP
{
    internal class Chips
    {
        public Chips()
        {

            
        }
        public void initializeChipCount(PlayerBasic player)
        {
            Console.WriteLine("Set chip count");
            int chipCount;
            string chipInput = Console.ReadLine();

            if (int.TryParse(chipInput, out chipCount))
            {
                player.chips = chipCount;
            }
            else
            {
                Console.WriteLine("Invalid chip count try again");

            }
        }

  

    }
}