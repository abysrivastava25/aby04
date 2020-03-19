using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using WebApi_session.Models;
namespace WebApi_session.Data
{
    public class Employee
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        ///get data
        public DataSet ShowData()
        {
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand("select * from Employee", sqlCon);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                return dataSet;
            }
        }
        public bool Insert_Data(mEmployee employee)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                SqlCommand cmd = new SqlCommand("proc_Insert @ID,@Name,@Salary", sqlConnection);
                cmd.Parameters.AddWithValue("@ID", employee.ID);
                cmd.Parameters.AddWithValue("@Name", employee.Name.ToString());
                cmd.Parameters.AddWithValue("@Salary", employee.Salary);
                sqlConnection.Open();
                int result = cmd.ExecuteNonQuery();
                sqlConnection.Close();
                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public DataSet Update_Data(mEmployee employee) 
        {
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                sqlCon.Open();
                SqlCommand command = new SqlCommand("update Employee set Name=@Name where ID=@id", sqlCon);
                command.Parameters.AddWithValue("@id", employee.ID);
                command.Parameters.AddWithValue("@Name", employee.Name);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                return dataSet;
            }
        }
        public bool Delete_Data(mEmployee employee)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                SqlCommand cmd = new SqlCommand("delete from Employee where ID=@id", sqlConnection);
                cmd.Parameters.AddWithValue("@id", employee.ID);                           
                sqlConnection.Open();
                int result = cmd.ExecuteNonQuery();
                sqlConnection.Close();
                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }

        }

    }
 }

   