using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeXMenBattleCount_CS_ASP
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] names = new string[] { "Professor X", "Iceman", "Angel", "Beast", "Phoenix", "Cyclops", "Wolverine", "Nightcrawler", "Storm", "Colossus" };
            int[] numbers = new int[] { 7, 9, 12, 15, 17, 13, 2, 6, 8, 13 };

            int indexMax = 0;
            int indexMin = 0;

            for (int i = 0; i < names.Length; i++)
            {
                if (numbers[i] > numbers[indexMax])
                {
                    indexMax = i;
                }
                if (numbers[i] < numbers[indexMin])
                {
                    indexMin = i;
                }
            }
            mostLabel.Text = String.Format("{0} (Value: {1})", names[indexMax], numbers[indexMax]);
            fewestLabel.Text = String.Format("{0} (Value: {1})", names[indexMin], numbers[indexMin]);
            
        }
    }
}