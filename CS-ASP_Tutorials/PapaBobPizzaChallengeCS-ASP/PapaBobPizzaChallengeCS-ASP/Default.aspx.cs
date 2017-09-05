using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PapaBobPizzaChallengeCS_ASP
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void purchaseButton_Click(object sender, EventArgs e)
        {
            double total;

            if (smallRadioButton.Checked)
                total = 10.0;
            else if (mediumRadioButton.Checked)
                total = 13.0;
            else
                total = 16.0;

            if (deepDishRadioButton.Checked)
                total += 2.0;

            total = (pepperoniCheckBox.Checked) ? total + 1.5 : total;
            total = (onionCheckBox.Checked) ? total + .75 : total;
            total = (greenPepperCheckBox.Checked) ? total + .5 : total;
            total = (redPepperCheckBox.Checked) ? total + .75 : total;
            total = (anchovyCheckBox.Checked) ? total + 2.0 : total;

            if (
                (pepperoniCheckBox.Checked 
                && greenPepperCheckBox.Checked 
                && anchovyCheckBox.Checked)
                || (pepperoniCheckBox.Checked 
                && redPepperCheckBox.Checked 
                && onionCheckBox.Checked)
                )
            {
                total -= 2.0;
            }

            totalLabel.Text = " $" + total.ToString();

        }
    }
}