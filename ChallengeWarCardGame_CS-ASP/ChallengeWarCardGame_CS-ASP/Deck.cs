using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace ChallengeWarCardGame_CS_ASP
{
    public class Deck
    {
        private List<Card> deck;
        private Random random;
        private StringBuilder sb;

        public Deck()
        {
            deck = new List<Card>();
            random = new Random();
            sb = new StringBuilder();

            string[] suitSelect = new string[] { "Hearts", "Clubs", "Spades", "Diamonds" };
            string[] cardSelect = new string[] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

            foreach (var suit in suitSelect)
            {
                foreach (var card in cardSelect)
                {
                    deck.Add(new Card() { Suit = suit, CardValue = card });
                }
            }
        }

        

        public string Deal(Player player1, Player player2)
        { 
            while (deck.Count > 0)
            {
                dealCard(player1);
                dealCard(player2);
            }
            return sb.ToString();
        }

        private void dealCard(Player player)
        {
            //randomly selects a card from the deck, then removes it so it can't be dealt again.

            Card card = deck.ElementAt(random.Next(deck.Count));
            player.Cards.Add(card);
            deck.Remove(card);

            sb.Append("<br />");
            sb.Append(player.Name);
            sb.Append(" has been dealt the ");
            sb.Append(card.CardValue);
            sb.Append(" of ");
            sb.Append(card.Suit);
        }
    }
}