using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Summer.Common.Utility
{
    public static class Compress
    {
        public static void CreateZipFile(string sourcePath, string destPath)
        {
            using (ZipFile zip = new ZipFile(Encoding.UTF8))
            {
                zip.AddDirectory(sourcePath);
                zip.Save(destPath);
            }
        }
    }
}
