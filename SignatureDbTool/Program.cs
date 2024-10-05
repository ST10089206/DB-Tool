using SignatureDbTool.Connector;
using SignatureDbTool.Generator;
using SignatureDbTool.Interfaces;
using SignatureDbTool.Logger;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureDbTool
{
	public class Program
	{
		static void Main(string[] args)
		{
			IFileLogger logger = new FileLogger(ConfigurationManager.AppSettings["LogFilePath"]); //Initializes FileLogger instance with log file path from config file
			try
			{
				IDatabaseConnector connection = new DatabaseConnector(ConfigurationManager.AppSettings["ConnectionString"]); //Initializes DatabaseConnector instance with connection string from config file
				connection.Connect(); //Establishes connection to database 
				logger.Log("Connection to the database established."); //Logs message for successful db connection

				IScriptGenerator scriptGenerator = new ScriptGenerator(logger); //Initializes ScriptGenerator instance with the initialized logger
				scriptGenerator.GenerateAndLogScripts(connection); //Generates and logs scripts based on the db connection
			}
			catch (Exception ex)
			{
				logger.Log($"Error: {ex.Message}"); //Logs erroir message if exception occurs during exec
			}
		}
	}
}
