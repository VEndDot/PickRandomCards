using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PickRandomCards
{
    
    
    class CardPicker
    {
        private static Random rand = new Random();

        private static string[] suit = new string[] { 
            "Crosses", 
            "diamonds",
            "hearts",
            "peaks"
        };


        public static string[] PickSomeCards(int numberOfCards) {

            string[] pickedCards = new string[numberOfCards];

            for (int i = 0; i < numberOfCards; i++) 
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }
            return pickedCards;
        }

        public static string RandomSuit() {
            int randSuit = rand.Next(0,4);

            return suit[randSuit];
        }

        public static string RandomValue() {

            int randValue = rand.Next(2,15);

            switch (randValue)
            {
                case 11:
                    return "jack";
                case 12:
                    return "queen";
                case 13:
                    return "king";
                case 14:
                    return "ace";
            }

            return randValue.ToString();
            
        }
    }
}
