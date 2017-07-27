using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstChallengeVS
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ageTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void goButton_Click(object sender, EventArgs e)
        {
            string age = ageTextBox.Text;
            string money = moneyTextBox.Text;

            string result = $"At {age} years old, I'm impressed you even carry cash, let alone {money} dollars!";

            goLabel.Text = result;
        }
    }
}