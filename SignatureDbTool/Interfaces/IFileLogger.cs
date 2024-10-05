using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureDbTool.Interfaces
{
	public interface IFileLogger
	{
		/// <summary>
		/// Logs a message to script file
		/// </summary>
		/// <param name="message">The message to be logged</param>
		void Log(string message);
	}
}
