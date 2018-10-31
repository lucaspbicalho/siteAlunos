using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Conector
/// </summary>
public class Conector
{
    MySqlConnection m_connection;
    MySqlCommand m_command;
    public Conector()
    {
        m_connection = new MySqlConnection("Server=localhost;Database=escola;Uid=root;Pwd=faloft;");
        m_command = m_connection.CreateCommand();
      
        //command.CommandText = "SELECT * FROM Customers";
        //command.ExecuteNonQuery();
    }
    public void open()
    {
        m_connection.Open();
    }
	public MySqlDataReader doquery(string query)
	{
		m_command.CommandText = query;
		return m_command.ExecuteReader();
	}
}