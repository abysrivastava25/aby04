using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
namespace Ado_assign
{
    public partial class q3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    //viewing the data from the table 
                    SqlCommand cmd = new SqlCommand("select * from TTN", connection);
                    GridView1.DataSource = cmd.ExecuteReader();
                    GridView1.DataBind();
                }

            }
            catch (SqlException ex)
            {
                Response.Write("Connection failed due to  " + ex.Message);
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    //inserting the data into the table 
                    SqlCommand cmd = new SqlCommand("insert into TTN values(@Name,@ID)", connection);
                    cmd.Parameters.AddWithValue("@Name", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@ID", TextBox2.Text);
                    cmd.ExecuteNonQuery();
                }

            }
            catch (SqlException ex)
            {
                Response.Write("Connection failed due to  " + ex.Message);
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    //viewing the data from the table 
                    SqlCommand cmd = new SqlCommand("delete from TTN where ID=@ID", connection);
                    cmd.Parameters.AddWithValue("@ID", TextBox2.Text.ToLower());
                    GridView1.DataSource = cmd.ExecuteScalar();
                    GridView1.DataBind();
                }

            }
            catch (SqlException ex)
            {
                Response.Write("Connection failed due to  " + ex.Message);
            }
        }
    }
}