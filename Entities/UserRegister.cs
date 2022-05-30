using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualInterface.Connection;
using VisualInterface.Entities;

class UserRegister
{
    Connection conn = new Connection();
    SqlCommand command = new SqlCommand();
    public string message;

    public UserRegister(User user)
    {
        command.CommandText = "INSERT INTO PERSONAL_DATA_USER(NAME, EMAIL, CPF, PASSWORD) VALUES(@NAME, @EMAIL, @CPF, @PASSWORD)";

        command.Parameters.AddWithValue("@NAME", user.Name);
        command.Parameters.AddWithValue("@EMAIL", user.Email);
        command.Parameters.AddWithValue("@CPF", user.Cpf);
        command.Parameters.AddWithValue("@PASSWORD", user.Password);

        try
        {
            command.Connection = conn.RealizeConnection();
            command.ExecuteNonQuery();
            conn.Desconnection();
            this.message = "User registered with sucess. ";
        }
        catch (SqlException e)
        {
            this.message = "SQL Server ERROR: Please check your connection with your database.";
        }
    }
}