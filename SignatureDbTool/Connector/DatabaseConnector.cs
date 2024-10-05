using SignatureDbTool.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureDbTool.Connector
{
	public class DatabaseConnector : IDatabaseConnector
	{
		/// <summary>
		/// Represents a DatabaseConnector that provides the connection to the SQL database using the connection string
		/// </summary>
		private readonly string _connectionString;

		/// <summary>
		/// Initializes a new instance of the DatabaseConnector with the connection string
		/// </summary>
		/// <param name="connectionString">The connection string used for establishing the database connection</param>
		public DatabaseConnector(string connectionString)
		{
			_connectionString = connectionString;
		}

		/// <summary>
		/// Method for establishing a connection to the SQL database using the connection string
		/// and
		/// Displays an error message if the connection attempt fails
		/// </summary>
		public void Connect()
		{
			using (SqlConnection connection = new SqlConnection(_connectionString))
			{
				try
				{
					connection.Open();
				}
				catch (Exception ex)
				{
					Console.WriteLine($"Error: {ex.Message}");
				}
			}
		}
	}
}
