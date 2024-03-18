using System.Linq;
using System.Reflection.Metadata.Ecma335;

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
                //create new random index based of the deck of cards length
                int k = rng.Next(deckOfCards.Length);
                // get current item in the deck
                string temp = deckOfCards[i];
                //deck random deck of cards index becomes the randomized one
                deckOfCards[i] = deckOfCards[k];
                deckOfCards[k] = temp;
            }
            //Random the randomized list of cards
            return deckOfCards;


         }

        public string[] giveOutCards(string[] deckOfCards,PlayerBasic player)
        {
            // Get first Card
            string firstCard = deckOfCards.First();


           // foreach(string deck in deckOfCards) {
            //Console.WriteLine(deck);
            //}


            if (player.Cards == null)
            {
                player.Cards = new string[] { firstCard }; // Initialize array if it's null
            }
            else
            {
                List<string> playerCardList = new List<string>(player.Cards);

                playerCardList.Add(firstCard);
                player.Cards = playerCardList.ToArray();
               // foreach (string card in playerCardList)
              //  {
            //        Console.WriteLine(card);
          //      }
                // Resize array to accommodate the new card
              //  foreach (string deckOfCard in player.Cards)
             //   {
                    
                //   Console.WriteLine("With this player i!!!!!");
                 //   Console.WriteLine(player.Name);
                 //   Console.WriteLine(deckOfCard);

                //}
                // Add the new card to the end of the array
                player.Cards[player.Cards.Length - 1] = firstCard;
            }

            // Get array without the first index
            string[] sortedDeckOfCards =  removeFirstIndexOfArray(deckOfCards);
            return sortedDeckOfCards;
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