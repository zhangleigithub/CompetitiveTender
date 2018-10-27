using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Summer.Common.Utility
{
    public static class AppDirectory
    {
        public static string Temp()
        {
            string dir = Path.GetFullPath("Temp\\");

            if (!Directory.Exists(Path.GetDirectoryName(dir)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(dir));
            }

            return dir;
        }

        public static string Temp_Dir(string directoryName)
        {
            string dir = Path.Combine(AppDirectory.Temp(), directoryName+"\\");

            if (!Directory.Exists(Path.GetDirectoryName(dir)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(dir));
            }

            return dir;
        }
    }
}
