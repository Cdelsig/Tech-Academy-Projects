using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeFunWithStrings_CS_ASP
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void goButton_Click(object sender, EventArgs e)
        {
            // 1.  Reverse your name
            string name = "Carrie Del Signore";
            string reverseName = "";

            for (int i = name.Length - 1; i >= 0; i--)
                {
                    reverseName += name[i].ToString();
                }
            reverseNameLabel.Text = reverseName;


            // 2.  Reverse this sequence:
            string swNames = "Luke,Leia,Han,Chewbacca";
            // When you're finished it should look like this:
            // Chewbacca,Han,Leia,Luke
            string[] tempString = swNames.Split(',');
            string reverseSWnames = "";

            for (int i = tempString.Length - 1; i >= 0; i--)
            {
                reverseSWnames += tempString[i] + ", ".ToString();
            }
            reverseStarWarsLabel.Text = reverseSWnames;


            // 3. Use the sequence to create ascii art (14):
            // *****luke*****
            // *****leia*****
            // *****han******
            // **Chewbacca***

            string[] myArray = { "Luke", "Leia", "Han", "Chewbacca!" };
            string asciiArt = "";

            for (int i = 0; i < myArray.Length; i++)
            {
                int padLeft = (14 - myArray[i].Length) / 2;
                string tempStr = myArray[i].PadLeft(myArray[i].Length + padLeft, '*');

                asciiArt += tempStr.PadRight(14, '*') + "<br />";
            }
            padLabel.Text = asciiArt;



            // 4. Solve this puzzle:

            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";
            string newPuzzle = "";
            string capPuzzle = "";
            // Once you fix it with string helper methods, it should read:
            // Now is the time for all good men to come to the aid of their country.

            //how instructor solved is better so don't have to hard code char val:

            //string removeMe = "remove-me";
            //int index = puzzle.IndexOf(removeMe);
            //puzzle = puzzle.Remove(index, removeMe.Length);
            int index = puzzle.IndexOf("remove-me");
            newPuzzle = puzzle.Remove(index, 9).Replace("Z", "T").ToLower();
            capPuzzle = newPuzzle.Remove(0, 1).Insert(0, "N");

            removeLabel.Text = capPuzzle;
        }
    }
}