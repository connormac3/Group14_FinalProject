using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group14_FinalProject
{
    public partial class MediumProblem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ConvertButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(InputTextBox.Text))
            {
                int num = Convert.ToInt32(InputTextBox.Text);
                string romanNumeral = IntToRoman(num);
                ResultLabel.Text = "Roman numeral for " + num + " is: " + romanNumeral;
            }
            else
            {
                ResultLabel.Text = "Please enter an integer.";
            }
        }

        public string IntToRoman(int num)
        {
            return get(num % 10000 / 1000, "", "", "M") +
                   get(num % 1000 / 100, "M", "D", "C") +
                   get(num % 100 / 10, "C", "L", "X") +
                   get(num % 10, "X", "V", "I");
        }

        string get(int n, string i, string j, string k)
        {
            if (n == 9)
            {
                return k + i;
            }
            if (n >= 5)
            {
                return j + new string(k[0], n - 5);
            }
            if (n == 4)
            {
                return k + j;
            }
            return new string(k[0], n);
        }
    }
}