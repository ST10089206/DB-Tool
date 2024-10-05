using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureDbTool.Interfaces
{
	public interface IScriptGenerator
	{
		/// <summary>
		/// Generates and logs scripts using the database connection.
		/// </summary>
		/// <param name="connection">The database connection to use for script generator</param>
		void GenerateAndLogScripts(IDatabaseConnector connection);
	}
}
