using System.Net.NetworkInformation;

namespace PickRandomCards
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the numbers of cards to pick: ");
            string userNumber = Console.ReadLine();
            if (int.TryParse(userNumber, out int numberOfCards))
            {
                string[] deck = CardPicker.PickSomeCards(numberOfCards);
                
                foreach (string card in deck)
                {
                    Console.WriteLine("Type of card: " + card);
                }
            }
            else 
            { 
                Console.WriteLine("This input cannot be converted to a number");
            }
            
        }
    }
}

