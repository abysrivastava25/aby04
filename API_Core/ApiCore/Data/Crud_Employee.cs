using ApiCore.Models;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCore.Data
{
    class Crud_Employee : Iemployee
    {
        private readonly IOptions<ConnectionString> _connection;
       

        public Crud_Employee(IOptions<ConnectionString> connection)
        {
            _connection = connection;
        }

        //Displaying all the data from the table
        public DataSet ShowData()
        {
            try
            {
                string con = _connection.Value.ConnectionStr;
                SqlConnection sqlConnection = new SqlConnection(con);
                SqlCommand command = new SqlCommand("select * from Employee", sqlConnection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                return dataSet;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        //Inserting new row or data in the table
        public bool Insert(Employee empCRUD)
        {
            try
            {
                string con = _connection.Value.ConnectionStr;
                SqlConnection sqlConnection = new SqlConnection(con);
                //using stored procedure to insert a record
                SqlCommand cmd = new SqlCommand("proc_Insert @ID,@Name,@Salary", sqlConnection);
                cmd.Parameters.AddWithValue("@ID", empCRUD.ID);
                cmd.Parameters.AddWithValue("@Name", empCRUD.Name.ToString());
                cmd.Parameters.AddWithValue("@Salary", empCRUD.Salary);
                sqlConnection.Open();
                int res = cmd.ExecuteNonQuery();
                sqlConnection.Close();
                if (res >= 0)
                    return true;
                else
                    return false;

            }
            catch (SqlException)
            {
                return false;
            }
        }

        //Retreiving single row from the table 
        public DataSet ShowSingle(int ID)
        {
            try
            {
                string con = _connection.Value.ConnectionStr;
                SqlConnection sqlConnection = new SqlConnection(con);
                //retrieving data by passing an ID
                SqlCommand cmd = new SqlCommand("select * from Employee where ID=@Emp_id", sqlConnection);
                cmd.Parameters.AddWithValue("@Emp_id", ID);
                sqlConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        //updating salary of an employee by specifying employee name
        public bool Update(Employee empData)
        {
            try
            {
                string con = _connection.Value.ConnectionStr;
                SqlConnection sqlConnection = new SqlConnection(con);
                SqlCommand cmd = new SqlCommand("update Employee set Salary=@Emp_salary where Name=@Emp_name ", sqlConnection);
                cmd.Parameters.AddWithValue("@emp_name", empData.Name);
                cmd.Parameters.AddWithValue("@emp_salary", empData.Salary);
                sqlConnection.Open();
                int updatedDat = cmd.ExecuteNonQuery();
                sqlConnection.Close();
                if (updatedDat >= 0)
                    return true;
                else
                    return false;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        //deleting a row by passing employee name
        public bool Delete(Employee empDel)
        {
            try
            {
                string con = _connection.Value.ConnectionStr;
                SqlConnection sqlConnection = new SqlConnection(con);
                //using stored procedure to delete a record
                SqlCommand cmd = new SqlCommand("proc_Delete @emp_name", sqlConnection);
                cmd.Parameters.AddWithValue("@emp_name", empDel.Name);
                sqlConnection.Open();
                int delDat = cmd.ExecuteNonQuery();
                sqlConnection.Close();
                if (delDat >= 0)
                    return true;
                else
                    return false;
            }
            catch (SqlException)
            {
                return false;
            }
        }
    }
}
