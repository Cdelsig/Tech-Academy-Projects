using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Darts;


namespace ChallengeSimpleDarts_CS_ASP
{
    public class Game
    {
        Random random = new Random();
        Dart dart = new Dart();

        public void Play(Player player1, Player player2)
        {
            //Player player1 = new Player();


            while (player1.Score < 300 && player2.Score < 300)
            {
                playRound(player1);
                playRound(player2);

            }
        }

        public int playRound(Player player)
        {
            int score = 0;
            for (int i = 0; i < 3; i++)
            {
                //Dart dart = new Dart();
                dart.Throw();
                score = dart.Score;
            
                if (dart.DoubleRing == true) score = score * 2;
                if (dart.TripleRing == true) score = score * 3;
                if (dart.OuterBullseye == true) score = 25;
                if (dart.InnerBullseye == true) score = 50;

                player.Score += score;

            }
            return score;

        }

        public string showResult(Player player1, Player player2)
        {
            //string winner = player1.Score 
            string result = String.Format("Player 1 Score: {0}<br />Player 2 Score: {1}<br />Winner: {2}",
                player1.Score,
                player2.Score,
                (player1.Score > player2.Score ? player1.Name : player2.Name)
                );
            return result;
        }

        
    }


}