using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualInterface.Connection;
using VisualInterface.Entities;

internal class UserLogin
{


    Connection conn = new Connection();
    SqlCommand command = new SqlCommand();
    public string message;

    public UserLogin(User user)
    {
        command.CommandText = "SELECT COUNT(ID) AS FIND FROM PERSONAL_DATA_USER WHERE EMAIL = @EMAIL AND PASSWORD = @PASSWORD";


        command.Parameters.AddWithValue("@EMAIL", user.Email);
        command.Parameters.AddWithValue("@PASSWORD", user.Password);

        try
        {
            command.Connection = conn.RealizeConnection();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            conn.Desconnection();

            if (Convert.ToInt16(reader["FIND"].ToString()) > 0)
            {
                this.message = "Sucefully logged in! ";
            }

            else
            {
                this.message = "Cannot find the especified user or wrong password, please try again.";
            }


            reader.Close();

        }
        catch (SqlException e)
        {
            this.message = "SQL Server ERROR: Please check your connection with your database.";
        }
    }
}



