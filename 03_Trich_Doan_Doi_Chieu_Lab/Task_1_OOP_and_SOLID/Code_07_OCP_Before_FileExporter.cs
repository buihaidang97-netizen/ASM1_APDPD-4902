public class FileExporter
{
    public void Export(string data, string format)
    {
        if (format == "Excel") Console.WriteLine("Exporting data to Excel: " + data);
        else if (format == "Pdf") Console.WriteLine("Exporting data to PDF: " + data);
        // every new format means editing this method
    }
}
