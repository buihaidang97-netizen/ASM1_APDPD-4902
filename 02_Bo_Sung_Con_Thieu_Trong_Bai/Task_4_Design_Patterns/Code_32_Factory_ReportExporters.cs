public interface IReportExporter
{
    byte[] Export(IEnumerable<ReportRow> rows);
}
 
public class ReportExporterFactory
{
    public IReportExporter Create(string format)
    {
        return format.ToLowerInvariant() switch
        {
            "csv" => new CsvReportExporter(),
            "pdf" => new PdfReportExporter(),
            _ => throw new NotSupportedException($"Format {format} is not supported.")
        };
    }
}
 
public class ReportController : Controller
{
    private readonly ReportExporterFactory _factory;
    public ReportController(ReportExporterFactory factory) => _factory = factory;
 
    public IActionResult Download(long classId, string format)
    {
        IReportExporter exporter = _factory.Create(format);
        byte[] file = exporter.Export(LoadRows(classId));
        return File(file, "application/octet-stream", $"class-{classId}.{format}");
    }
}
