using System.Collections.Generic;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BlackJackOOP
{
    internal class BlackjackSetup
    {

       public BlackjackSetup() {
            Console.WriteLine("Welcome to the blackjack trainer 1000.");
            
            Console.WriteLine("Do you want to acces the options?");
            setupOptionsChoice();
            
        }

        public void setupOptionsChoice()
        {
            Console.WriteLine("y/n");
            string option = Console.ReadLine();
            var setupOptions = new string[] { "y", "Y", "1" };
            if (setupOptions.Contains(option)) {
                blackjackOptions();
            }
            else
            {
                return;
            }

        }
        public void blackjackOptions()
        {  
            Console.WriteLine("You can edit your options here!??!?!?!");
            return;
        }

        public List <PlayerBasic> blackjackUserOptions()
        {

            Console.WriteLine("How many users do you want to play against?");
            Console.WriteLine("1/2/3/4");
            string playerCount = Console.ReadLine();
            // Parse string playercount into a int
            if(int.TryParse(playerCount, out int newPlayerCount))
            {
                Console.WriteLine(newPlayerCount);

                // If playercount is over 4 or under one retry the class
                if (newPlayerCount > 4 || newPlayerCount < 1)
                {
                    Console.WriteLine("The max player count is 4 try again");
                    return blackjackUserOptions();
                }
                else
                {
                    // Initiallize player names
                    List<PlayerBasic> players = initializePlayers(newPlayerCount);

                    return players;
                }
            }
            else
            {   //If parse fails try again
                Console.WriteLine("Something Went Wrong try again");
                return blackjackUserOptions();
            }
          
           
           
        }

        public List <PlayerBasic> initializePlayers( int playerCount)
        {
            // Create a list of players
            List<PlayerBasic> players = new List<PlayerBasic>();

          
            for (int i = 0; i < playerCount; i++)
            {
                // Create a new player
                PlayerBasic player = new PlayerBasic();
                // Set the player name with the value of i

                player.Name = $"Player{i + 1}";
                Console.WriteLine(player.Name); 
                // Add player to the list
                players.Add(player);


            }

            return players;

        }
    }
}