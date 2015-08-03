using System;
using System.Runtime.CompilerServices;
using System.IO;

namespace SysproUtils
{
    /// <summary>
    /// Class used to log messages to the specified output.
    /// </summary>
    public static class Logger
    {
        /// <summary>
        ///   Logs output with the current datetime, file, method, line number and message of the caller.
        ///   Example usage: Logger.Log("My message");
        ///   Example output: 7/24/2015 7:14:53 PM CSVExplorer.cs_searchBtn_Click(31): My message
        /// </summary>
        /// <param name="message">String passed in by end-user.</param>
        /// <param name="file">File where the Log method was called.</param>
        /// <param name="lineNumber">Line number where Log method was called.</param>
        /// <param name="caller">Method where the Log method was called.</param>
        public static void Log(string message,
            [CallerFilePath] string file = "",
            [CallerLineNumber] int lineNumber = 0,
            [CallerMemberName] string caller = null)
        {
            var filePath = Helpers.AssemblyDirectory + "\\CSVExplorerLog.log";

            if (!File.Exists(filePath))
            {
                // Create a file to write to.
                StreamWriter swNew = File.CreateText(filePath);
                swNew.WriteLine(string.Format("{0} {1}_{2}({3}): {4} \n", DateTime.Now, Path.GetFileName(file), caller, lineNumber, message));
                swNew.Close();
            }
            else
            {

                StreamWriter swAppend = File.AppendText(filePath);
                swAppend.WriteLine(string.Format("{0} {1}_{2}({3}): {4} \n", DateTime.Now, Path.GetFileName(file), caller, lineNumber, message));
                swAppend.Close();
            }
        }
    }
}
