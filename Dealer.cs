using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace BlackJackOOP
{
    internal class Dealer : PlayerBasic
    {
        public Dealer() {

            
           
        }


        public IDictionary<string, int> shuffleCards(IDictionary<string, int> deckOfCards)
        {
            // Convert the dictionary to a list of KeyValuePair
            var list = deckOfCards.ToList();
            
            // Create a new random number generator
            var rng = new Random();

            // Shuffle the list
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                var value = list[k];
                list[k] = list[n];
                list[n] = value;
            }

        
            return list.ToDictionary(x => x.Key, x => x.Value);
    
            
        }

    
        public void giveOutCards(IDictionary<string, int> deckOfCards, PlayerBasic player)
        {

            // Get first Card
            KeyValuePair<string, int> firstCardPair = deckOfCards.First();

            if (player.Cards == null)
            {
                player.Cards = new Dictionary<string, int>(); // Initialize dictionary if it's null
            }

            // Add the first card to player's cards
            player.Cards.Add(firstCardPair.Key, firstCardPair.Value);
            Console.Write("First card pair ");
            Console.WriteLine(firstCardPair.Key);
            // Remove the first card from the deck
            deckOfCards.Remove(firstCardPair.Key);
            if (!player.checkIfBust(player))
            {
                player.pointCount = player.pointCount + firstCardPair.Value;
                return;
            }

            return;


        }

        private string[] removeFirstIndexOfArray(string[] arrayOfValues)
        {
            // Create a smaller array
            string[] arrayOfValuesWithoutFirstIndex = new string[arrayOfValues.Length - 1];
            // Copy the original at the second index
            Array.Copy(arrayOfValues, 1, arrayOfValuesWithoutFirstIndex, 0, arrayOfValuesWithoutFirstIndex.Length);


            return arrayOfValuesWithoutFirstIndex;
        }


}}