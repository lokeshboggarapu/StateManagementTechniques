using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
namespace SessionDemo
{
    public partial class Loginpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["Username"] = txtusername.Text.ToString();

            }

            else
            {
                Label1.Visible = true;
                Label1.Text = ViewState["Username"].ToString();

            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            try
            {
                using(SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constring"].ToString()))
{

    SqlCommand cmd = new SqlCommand("P_GetUsername", con);
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = txtusername.Text.ToString();
    SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();               
                da.Fill(ds);

                if (txtusername.Text.ToString() == ds.Tables[0].Rows[0]["EmployeeName"].ToString() && txtpassword.Text.ToString() == ds.Tables[0].Rows[0]["Password"].ToString())
                    {
                        Session["Username"] = txtusername.Text.ToString();

                        Response.Redirect("Department.aspx");

                    }
                    else
                    {
                        Label2.Text = "Please Enter Correct UserName/Password";
                        ViewState["Username"] = "Previous user logged in with user" + txtusername.Text.ToString() + "at" + System.DateTime.Now;
                    }

                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
             
        }
    }
    
}