using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SessionDemo.com.cdyne.ws;

namespace SessionDemo
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblUsername.Text = Session["Username"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            com.cdyne.ws.DelayedStockQuote ds = new com.cdyne.ws.DelayedStockQuote();
           
                ds.GetQuote(TextBox1.Text, "0");
            QuoteData dsr = new QuoteData();
            string b=dsr.StockSymbol.ToString();
            string a=ds.GetQuote(TextBox1.Text, "0").StockSymbol;
            string LastTradedAmount=ds.GetQuote(TextBox1.Text, "0").LastTradeAmount.ToString();
            string DayLow=ds.GetQuote(TextBox1.Text, "0").DayHigh.ToString();
            string DayHigh=ds.GetQuote(TextBox1.Text, "0").DayLow.ToString();
            string CompanyName=ds.GetQuote(TextBox1.Text, "0").CompanyName.ToString();
            TextBox2.Text = b;
            TextBox3.Text=LastTradedAmount;
            TextBox4.Text=DayLow;
            TextBox5.Text = DayHigh;
            TextBox6.Text = CompanyName;
        }
    }
}