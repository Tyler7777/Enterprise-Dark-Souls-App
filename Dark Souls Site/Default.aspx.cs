﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    { }
       

          
        

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlConnection dbConnection = new SqlConnection("Data Source=stusql;Initial Catalog=Dark_Souls ;Integrated Security=true");
        try
        {
            dbConnection.Open();

            if (Chest.SelectedValue != "")
            {
                SqlCommand sqlCommand = new SqlCommand("Select Physical from Chest where Name = '" + Chest.SelectedValue + "';");
                PhysicalDef.Text = Chest.SelectedValue;//sqlCommand.ExecuteScalar().ToString();
            }

        }
        catch (SqlException exception)
        {

        }
        dbConnection.Close();
    }

    protected void DropDownListGENDER_SelectedIndexChanged(object sender, EventArgs e)
    {
        int I;
        I = 1;
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection dbConnection = new SqlConnection("Data Source=stusql;Initial Catalog=Dark_Souls ;Integrated Security=true");
        try
        {
            dbConnection.Open();

            if (Chest.SelectedValue != "")
            {
                SqlCommand sqlCommand = new SqlCommand("Select Physical from Chest where Name = '" + Chest.SelectedValue + "';");
                PhysicalDef.Text = Chest.SelectedValue;//sqlCommand.ExecuteScalar().ToString();
            }

        }
        catch (SqlException exception)
        {

        }
        dbConnection.Close();
    }
}
