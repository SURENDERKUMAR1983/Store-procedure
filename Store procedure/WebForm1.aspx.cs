using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Store_procedure
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }
            if (Page.IsPostBack == false)
            {
                disp_Rec();
            }
        }    


        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insemp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@eno", TextBox1.Text);
            cmd.Parameters.AddWithValue("@en", TextBox2.Text);
            cmd.Parameters.AddWithValue("@ed", TextBox3.Text);
            cmd.Parameters.AddWithValue("@es", TextBox4.Text);
            cmd.ExecuteNonQuery();
            cmd.Dispose();

            clear_Rec();
        }

        private void clear_Rec()
        {
            TextBox1.Text = string.Empty;
            TextBox2.Text = string.Empty;
            TextBox3.Text = string.Empty;
            TextBox4.Text = string.Empty;
            TextBox1.Focus();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            disp_Rec();

        }

        private void disp_Rec()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "disemp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            SqlDataReader dr = cmd.ExecuteReader();
            ListBox1.DataTextField = "ename";
            ListBox1.DataValueField = "empno";
            ListBox1.DataSource = dr;
            ListBox1.DataBind();
            dr.Close();
            cmd.Dispose();
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "findemp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@eno", ListBox1.SelectedValue);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.HasRows)
            {
                dr.Read();
            }
            TextBox1.Text = dr[0].ToString();
            TextBox2.Text = dr[1].ToString();
            TextBox3.Text = dr[2].ToString();
            TextBox4.Text = dr[3].ToString();
            dr.Close();
            cmd.Dispose();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "updemp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@eno", TextBox1.Text);
            cmd.Parameters.AddWithValue("@en", TextBox2.Text);
            cmd.Parameters.AddWithValue("@ed", TextBox3.Text);
            cmd.Parameters.AddWithValue("@es", TextBox4.Text);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            clear_Rec();
            disp_Rec();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "delemp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@eno", TextBox1.Text);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            disp_Rec();
            clear_Rec();

        }
    }
}