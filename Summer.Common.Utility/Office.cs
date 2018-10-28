using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Summer.Common.Utility
{
    public static class Office
    {
        public static string WordToPdf(string sourcePath)
        {
            Microsoft.Office.Interop.Word.Application application = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document document = null;
            try
            {
                application.Visible = false;
                document = application.Documents.Open(sourcePath);
                string destPath = Path.ChangeExtension(sourcePath, ".pdf");
                document.ExportAsFixedFormat(destPath, Microsoft.Office.Interop.Word.WdExportFormat.wdExportFormatPDF);

                return destPath;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                document.Close();
            }
        }
    }
}
