public abstract class FIleExporterOCP
{
    public abstract void Export(string data);
}
 
public class ExcelFileExporter : FIleExporterOCP
{
    public override void Export(string data)
    {
        Console.WriteLine("Exporting data to Excel: " + data);
    }
}
 
public class PdfFileExport : FIleExporterOCP
{
    public override void Export(string data)
    {
        Console.WriteLine("Exporting data to PDF: " + data);
    }
}
