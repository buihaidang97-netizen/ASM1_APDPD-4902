using System;
using System.Collections.Generic;
using System.Text;

namespace lab16._10.OCP_Exporter
{
    public class ExcelFileExporter : FIleExporterOCP
    {
        public override void Export(string data)
        {
            // Implement Excel export logic here
            // For now, just a placeholder
            Console.WriteLine("Exporting data to Excel: " + data);
        }
    }
}
