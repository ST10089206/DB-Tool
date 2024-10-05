using SignatureDbTool.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureDbTool.Logger
{
	public class FileLogger : IFileLogger
	{
		/// <summary>
		/// Represents the FileLogger that logs messages to the script log file
		/// </summary>
		private readonly string _logFilePath;

		/// <summary>
		/// Initializes a new instance of the FileLogger with the script log file path
		/// </summary>
		/// <param name="logFilePath">The file path where the log will be written</param>
		public FileLogger(string logFilePath)
		{
			_logFilePath = logFilePath;
		}

		/// <summary>
		/// Writes the message along with the current time to the script log file.
		/// </summary>
		/// <param name="message">The message to be logged</param>
		public void Log(string message)
		{
			using (StreamWriter sw = File.AppendText(_logFilePath))
			{
				sw.WriteLine($"{DateTime.Now.ToString()} - {message}");
			}
		}
	}
}
