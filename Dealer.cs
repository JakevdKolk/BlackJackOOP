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

        public (string ,string[]) giveOutCards(string[] deckOfCards)
        {
            // Get first Card
            string firstCard = deckOfCards.First();

            //Display first card to the console
            Console.Write("Card = ");
            Console.WriteLine(firstCard);
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