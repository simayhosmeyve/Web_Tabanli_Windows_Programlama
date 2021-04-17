using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HesapMakinesi
{
    public partial class Calculator : System.Web.UI.Page
    {
        static double num1, num2, outcome;
        static String calc;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TextBox.Text = "0";
            }
        }

       
        protected void Button_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            switch (B.ClientID)
            {    
                case "Button1":
                    if (TextBox.Text == "0")
                        TextBox.Text = "7";
                    else TextBox.Text += "7";
                    break;

                case "Button2":
                    if (TextBox.Text == "0")
                        TextBox.Text = "8";
                    else TextBox.Text += "8";
                    break;

                case "Button3":
                    if (TextBox.Text == "0")
                        TextBox.Text = "9";
                    else TextBox.Text += "9";
                    break;

                case "Button4":
                    calc = "/";
                    num1 = Convert.ToDouble(TextBox.Text);
                    TextBox.Text = "0";
                    break;

                case "Button5":
                    if (TextBox.Text == "0")
                        TextBox.Text = "4";
                    else TextBox.Text += "4";
                    break;

                case "Button6":
                    if (TextBox.Text == "0")
                        TextBox.Text = "5";
                    else TextBox.Text += "5";
                    break;

                case "Button7":
                    if (TextBox.Text == "0")
                        TextBox.Text = "6";
                    else TextBox.Text += "6";
                    break;

                case "Button8":
                    calc = "*";
                    num1 = Convert.ToDouble(TextBox.Text);
                    TextBox.Text = "0";
                    break;

                case "Button9":
                    if (TextBox.Text == "0")
                        TextBox.Text = "1";
                    else TextBox.Text += "1";
                    break;

                case "Button10":
                    if (TextBox.Text == "0")
                        TextBox.Text = "2";
                    else TextBox.Text += "2";
                    break;

                case "Button11":
                    if (TextBox.Text == "0")
                        TextBox.Text = "3";
                    else TextBox.Text += "3";
                    break;

                case "Button12":
                    calc = "-";
                    num1 = Convert.ToDouble(TextBox.Text);
                    TextBox.Text = "0";
                    break;

                case "Button13":
                    if (TextBox.Text != "0")
                        TextBox.Text += "0";
                    break;

                case "Button14":
                    calc = "+";
                    num1 = Convert.ToDouble(TextBox.Text);
                    TextBox.Text = "0";
                    break;

                case "Button15":
                    //CLC
                    TextBox.Text = "0";
                    break;

                case "Button16":
                    //=
                    num2 = Convert.ToDouble(TextBox.Text);
                    if (calc == "+")
                    {
                        double outcome = num1 + num2;
                        TextBox.Text = Convert.ToString(outcome);
                    }

                    if (calc == "/")
                    {
                        double outcome = num1 / num2;
                        TextBox.Text = Convert.ToString(outcome);
                    }

                    if (calc == "*")
                    {
                        double outcome = num1 * num2;
                        TextBox.Text = Convert.ToString(outcome);
                    }

                    if (calc == "-")
                    {
                        double outcome = num1 - num2;
                        TextBox.Text = Convert.ToString(outcome);
                    }
                    break;
            }
            }
        }
        
}