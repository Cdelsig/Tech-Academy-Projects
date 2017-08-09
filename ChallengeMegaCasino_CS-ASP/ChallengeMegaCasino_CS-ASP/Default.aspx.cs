﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeMegaCasino_CS_ASP
{
    public partial class Default : System.Web.UI.Page
    {
        Random random = new Random();

        protected void Page_Load(object sender, EventArgs e)
        {     
           
            if (!Page.IsPostBack)
            {
                string img1, img2, img3;
                displayRandomImages(out img1, out img2, out img3);            

                ViewState.Add("balance", 100);

                moneyLabel.Text = String.Format("{0:C}", ViewState["balance"]);
            }
            
        }
            
        protected void leverButton_Click(object sender, EventArgs e)
        {
            double balance = double.Parse(ViewState["balance"].ToString());
            double placeBet = 0;
            double winVal = 0;

            if (!double.TryParse(betTextBox.Text, out placeBet)) //makes sure there is a numeric value in the text box
            {
                resultLabel.Text = "";
                return;
            }

            string img1, img2, img3;

            displayRandomImages(out img1, out img2, out img3);

            if (img1 == "Bar.png" || img2 == "Bar.png" || img3 == "Bar.png")
            {
                balance -= placeBet;

                resultLabel.Text = String.Format("Sorry, you lost {0:C}. Better luck next time.", placeBet);
            }

            else if (img1 == "Cherry.png" && img2 == "Cherry.png" && img3 == "Cherry.png")
            {
                winVal = placeBet * 4;
                balance += winVal;

                resultLabel.Text = String.Format("You bet {0:C} and won {1:C}!", placeBet, winVal);
            }

            else if (
                (img1 == "Cherry.png" && (img2 == "Cherry.png" || img3 == "Cherry.png"))
                || ((img1 == "Cherry.png" || img2 == "Cherry.png") && img3 == "Cherry.png")
                )
            {
                winVal = placeBet * 3;
                balance += winVal;

                resultLabel.Text = String.Format("You bet {0:C} and won {1:C}!", placeBet, winVal);
            }

            else if (img1 == "Cherry.png" || img2 == "Cherry.png" || img3 == "Cherry.png")
            {
                winVal = placeBet * 2;
                balance += winVal;

                resultLabel.Text = String.Format("You bet {0:C} and won {1:C}!", placeBet, winVal);
            }

            else if (img1 == "Seven.png" && img2 == "Seven.png" && img3 == "Seven.png")
            {
                winVal = placeBet * 100;
                balance += winVal;

                resultLabel.Text = String.Format("You bet {0:C} and won {1:C}!", placeBet, winVal);
            }

            else
            {
                balance -= placeBet;
                resultLabel.Text = String.Format("Sorry, you lost {0:C}. Better luck next time.", placeBet);
            }

            ViewState["balance"] = balance;

            moneyLabel.Text = String.Format("{0:C}", ViewState["balance"]);
        }

        private string getRandomImg()
        {
            string[] imageArray = {"Bar.png", "Bell.png", "Cherry.png", "Clover.png", "Diamond.png", "HorseShoe.png", "Lemon.png",
                                   "Orange.png", "Plum.png", "Seven.png", "Strawberry.png", "Watermelon.png"};
            return imageArray[random.Next(11)];
        }

        private void displayRandomImages(out string imgURL1, out string imgURL2, out string imgURL3)
        {
            imgURL1 = getRandomImg();
            imgURL2 = getRandomImg();
            imgURL3 = getRandomImg();

            Image1.ImageUrl = "~/Images/" + imgURL1;
            Image2.ImageUrl = "~/Images/" + imgURL2;
            Image3.ImageUrl = "~/Images/" + imgURL3;
        }
    }
}

/* This is how the instructor solved the problem:
 * 
namespace MegaChallengeCasino
{
    public partial class Default : System.Web.UI.Page
    {
        Random random = new Random();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // Display the Reel values
                string[] reels = new string[] { spinReel(), spinReel(), spinReel() };
                displayImages(reels);
                ViewState.Add("PlayersMoney", 100);
                displayPlayersMoney();
            }
        }

        protected void pullButton_Click(object sender, EventArgs e)
        {
            int bet = 0;
            if (!int.TryParse(betTextBox.Text, out bet)) return;

            int winnings = pullLever(bet);
            displayResult(bet, winnings);
            adjustPlayersMoney(bet, winnings);
            displayPlayersMoney();
        }

        private void adjustPlayersMoney(int bet, int winnings)
        {
            int playersMoney = int.Parse(ViewState["PlayersMoney"].ToString());
            playersMoney -= bet;
            playersMoney += winnings;
            ViewState["PlayersMoney"] = playersMoney;
        }

        private int pullLever(int bet)
        {
            string[] reels = new string[] { spinReel(), spinReel(), spinReel() };
            displayImages(reels);
            int multiplier = evaluateSpin(reels);
            return bet * multiplier;
        }

        private int evaluateSpin(string[] reels)
        {
            if (isBar(reels)) return 0;
            if (isJackpot(reels)) return 100;
            int multiplier = 0;
            if (isWinner(reels, out multiplier)) return multiplier;
            return 0;
        }

        private bool isWinner(string[] reels, out int multiplier)
        {
            multiplier = determineMultiplier(reels);
            if (multiplier > 0) return true;
            return false;
        }

        private int determineMultiplier(string[] reels)
        {
            int cherryCount = determineCherryCount(reels);
            if (cherryCount == 1) return 2;
            if (cherryCount == 2) return 3;
            if (cherryCount == 3) return 4;
            return 0;
        }

        private int determineCherryCount(string[] reels)
        {
            int cherryCount = 0;
            if (reels[0] == "Cherry") cherryCount++;
            if (reels[1] == "Cherry") cherryCount++;
            if (reels[2] == "Cherry") cherryCount++;
            return cherryCount;
        }

        private bool isJackpot(string[] reels)
        {
            if (reels[0] == "Seven" && reels[1] == "Seven" && reels[2] == "Seven")
                return true;
            else
                return false;
        }

        private bool isBar(string[] reels)
        {
            if (reels[0] == "Bar" || reels[1] == "Bar" || reels[2] == "Bar")
                return true;
            else
                return false;
        }

        private string spinReel()
        {
            string[] images = new string[] { "Bar", "Bell", "Cherry", "Clover", "Diamond", "HorseShoe", "Lemon", "Orange", "Plum", "Seven", "Strawberry", "Watermelon" };
            return images[random.Next(11)];
        }

        private void displayImages(string[] reels)
        {
            Image1.ImageUrl = "/Images/" + reels[0] + ".png";
            Image2.ImageUrl = "/Images/" + reels[1] + ".png";
            Image3.ImageUrl = "/Images/" + reels[2] + ".png";
        }

        private void displayResult(int bet, int winnings)
        {
            if (winnings > 0)
                resultLabel.Text = String.Format("You bet {0:C} and won {1:C}!", bet, winnings);
            else
                resultLabel.Text = String.Format("Sorry, you lost {0:C}.  Better luck next time.", bet);
        }

        private void displayPlayersMoney()
        {
            moneyLabel.Text = String.Format("Player's Money: {0:C}", ViewState["PlayersMoney"]);
        }

    }
}
*/
