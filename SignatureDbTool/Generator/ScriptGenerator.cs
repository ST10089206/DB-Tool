using SignatureDbTool.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureDbTool.Generator
{
	public class ScriptGenerator : IScriptGenerator
	{
		/// <summary>
		/// Represents a ScriptGenerator that generates scripts and logs them using the IFileLogger interface
		/// </summary>
		private readonly IFileLogger _filelogger;

		/// <summary>
		/// Initializes a new instance of the ScriptGenerator with the script file logger
		/// </summary>
		/// <param name="filelogger">The file logger used for logging the generated scripts</param>
		public ScriptGenerator(IFileLogger filelogger)
		{
			_filelogger = filelogger;
		}

		/// <summary>
		/// Generates and logs SQL scripts using the database connection.
		/// </summary>
		/// <param name="connection">The database connector to be used for script generation</param>
		public void GenerateAndLogScripts(IDatabaseConnector connection)
		{
			//Scripts generator to be logged (user input?)
			string createScript = "CREATE TABLE Student (Id INT IDENTITY(1,1) PRIMARY KEY, Name varchar(255));";
			string insertScript = "INSERT INTO Student (Name) VALUES ('John Doe');";
			string updateScript = "UPDATE Employee SET Name = 'James Dawn' WHERE Id = 1;";
			string alterScript = "ALTER TABLE Employee ADD Age int;";

			//Logging of generated scripts above using the filelogger
			_filelogger.Log("Generated CREATE script: " + createScript);

			_filelogger.Log("Generated INSERT script: " + insertScript);

			_filelogger.Log("Generated UPDATE script: " + updateScript);

			_filelogger.Log("Generated ALTER script: " + alterScript);
		}
	}
}
