using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeWarCardGame_CS_ASP
{
    public class Player
    {
        public string Name { get; set; }
        public List<Card> Cards { get; set; }

        public Player()
        {
            Cards = new List<Card>();
        }
    }
}