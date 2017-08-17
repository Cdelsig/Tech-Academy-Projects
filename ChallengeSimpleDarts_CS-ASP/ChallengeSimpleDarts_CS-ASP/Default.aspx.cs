using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Darts;


namespace ChallengeSimpleDarts_CS_ASP
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            //Player player1 = new Player();
            //Player player2 = new Player();

        }

        protected void goButton_Click(object sender, EventArgs e)
        {
            Game game = new Game();

            Player player1 = new Player();
            player1.Name = "Player 1";

            Player player2 = new Player();
            player2.Name = "Player 2";

            game.Play(player1, player2);
            //game.showResult();
            resultLabel.Text = game.showResult(player1, player2);
        }
    }

    
}