using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesCS_ASP
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                endPrevCalendar.SelectedDate = DateTime.Now.Date;
                startNewCalendar.SelectedDate = DateTime.Now.Date.AddDays(14);
                endNewCalendar.SelectedDate = DateTime.Now.Date.AddDays(21);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string spyName = spyNameTextBox.Text;
            string assignment = assignmentTextBox.Text;

            //instructor used TimeSpan in video instead of using double in the block below like this:
            /* TimeSpan totalAssignedDays = endPrevCalendar.SelectedDate.Subtract(startNewCalendar.SelectedDate).TotalDays;
             * then used:
             * if (totalAssignedDays.TotalDays > 21)
             * this yielded same result, with a slightly different technique.
             */
            double daysBetweenAssn = startNewCalendar.SelectedDate.Subtract(endPrevCalendar.SelectedDate).TotalDays;
            double totalAssignedDays = endNewCalendar.SelectedDate.Subtract(startNewCalendar.SelectedDate).TotalDays;
            DateTime okStartDate = endPrevCalendar.SelectedDate.AddDays(14);

            //Spies cost $500/day, and an additional $1,000 if more than 21 days:
            double budget = totalAssignedDays * 500;
            if (totalAssignedDays > 21)
            {
                budget += 1000;
            }
            
            string result = String.Format("Assignment of {0} to project {1} is authorized. Budget total: {2:C}", spyName, assignment, budget);

            if (daysBetweenAssn < 14)
            {
                resultLabel.Text = "Error: Must allow at least two weeks between previous assignment and new assignment.";
                startNewCalendar.SelectedDate = okStartDate;
                
            }
            else
            {
                resultLabel.Text = result;
            }

            

            

        }
    }
}