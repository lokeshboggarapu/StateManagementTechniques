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
    public partial class Department : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblUsername.Text = Session["Username"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try{
            try
            {
                ConnectionStrings c = new ConnectionStrings();
                 
                using (c.con)
                {

                    SqlCommand cmd = new SqlCommand("p_getdeptdetails", c.con);
                   // SqlCommand cmd = new SqlCommand("p_getcustomers", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                   cmd.Parameters.Add("@DepartmentID", SqlDbType.VarChar).Value = txtsearch.Text.ToString();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    ds.WriteXml("E:\\employee.xml");
                    if (txtsearch.Text.ToString() == ds.Tables[0].Rows[0]["DepartmentID"].ToString() )
                    {
                        GridView1.DataSource = ds;
                        GridView1.DataBind();
                    }
                    else
                    {
                        Label2.Visible = true;
                        Label2.Text = "Please Enter Correct DepartmentID";
                        
                    }

                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
                
        }
            catch( Exception ex)
            {
            
            }
    }
    }
}