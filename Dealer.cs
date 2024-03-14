using System.Linq;

namespace BlackJackOOP
{
    internal class Dealer : PlayerBasic
    {
        public Dealer() {

            
           
        }

       
        public string[] shuffleCards(string [] deckOfCards)
        {

            //Get the random class from C#
             Random rng = new Random();
            //Loop trough each item in deckOfCards
            for (int i = 0; i < deckOfCards.Length; i++)
            {
                //Randomize the list of cards
                int k = rng.Next(deckOfCards.Length);
                string temp = deckOfCards[i];
                deckOfCards[i] = deckOfCards[k];
                deckOfCards[k] = temp;
            }
            //Random the randomized list of cards
            return deckOfCards;


         }

        public (string ,string[]) giveOutCards(string[] deckOfCards,PlayerBasic player
            )
        {
            // Get first Card
            string firstCard = deckOfCards.First();

            //Display first card to the console
            Console.Write("Card = ");
            Console.WriteLine(firstCard);

               if (player.cards == null)
    {
        player.cards = new string[] { firstCard }; // Initialize array if it's null
    }
    else
    {
        // Resize array to accommodate the new card
        Array.Resize(ref player.cards, player.cards.Length + 1);
        // Add the new card to the end of the array
        player.cards[player.cards.Length - 1] = firstCard;
    }

            // Get array without the first index
            string[] sortedDeckOfCards =  removeFirstIndexOfArray(deckOfCards);
            return (firstCard, sortedDeckOfCards);
        }

        public string[] removeFirstIndexOfArray(string[] arrayOfValues)
        {
            // Create a smaller array
            string[] arrayOfValuesWithoutFirstIndex = new string[arrayOfValues.Length - 1];
            // Copy the original at the second index
            Array.Copy(arrayOfValues, 1, arrayOfValuesWithoutFirstIndex, 0, arrayOfValuesWithoutFirstIndex.Length);


            return arrayOfValuesWithoutFirstIndex;
        }
}}