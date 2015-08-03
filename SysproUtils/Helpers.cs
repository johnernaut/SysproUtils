using System;
using System.IO;
using System.Reflection;

namespace SysproUtils
{
    /// <summary>
    /// Helper functions unrelated to Syspro for data manipulation and extraction.
    /// </summary>
    public class Helpers
    {
        /// <summary>
        /// Returns file location of currently running assembly.
        /// </summary>
        public static string AssemblyDirectory
        {
            get
            {
                string codeBase = Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);

                return Path.GetDirectoryName(path);
            }
        }
    }
}
