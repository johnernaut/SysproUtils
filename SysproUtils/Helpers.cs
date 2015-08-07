using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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
