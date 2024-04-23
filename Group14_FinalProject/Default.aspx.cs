using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group14_FinalProject
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LeetCodeEasy_Click(object sender, EventArgs e)
        {
            Response.Redirect("EasyProblem.aspx");
        }

        protected void LeetCodeMedium_Click(object sender, EventArgs e)
        {
            Response.Redirect("MediumProblem.aspx");
        }

        protected void LeetCodeHard_Click(object sender, EventArgs e)
        {
            Response.Redirect("HardProblem.aspx");
        }
    }
}