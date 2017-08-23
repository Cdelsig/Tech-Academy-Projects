using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeWarCardGame_CS_ASP
{
    public class Card
    {
        public string Suit { get; set; }
        public string CardValue { get; set; }

        public int CardPoints()
        {
            int points = 0;

            switch (this.CardValue)
            {
                case "Jack":
                    points = 11;
                    break;
                case "Queen":
                    points = 12;
                    break;
                case "King":
                    points = 13;
                    break;
                case "Ace":
                    points = 14;
                    break;
                default:
                    points = int.Parse(this.CardValue);
                    break;
            }
            return points;
        }
    }
}