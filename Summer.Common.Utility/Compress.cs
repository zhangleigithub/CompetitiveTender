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

        public static void ExtractZipFile(string sourcePath, string destPath)
        {
            using (ZipFile zip = ZipFile.Read(sourcePath, new ReadOptions() { Encoding = Encoding.UTF8 }))
            {
                zip.ExtractAll(destPath, ExtractExistingFileAction.OverwriteSilently);
            }
        }
    }
}
