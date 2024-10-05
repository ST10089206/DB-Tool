using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureDbTool.Interfaces
{
	public interface IDatabaseConnector
	{
		/// <summary>
		/// Method for establishing a connection to the database.
		/// </summary>
		void Connect();
	}
}
