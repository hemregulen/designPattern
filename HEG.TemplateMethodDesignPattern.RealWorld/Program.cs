using HEG.TemplateMethodDesignPattern.RealWorld.TemplateMethod;

ReportGenerator htmlReport = new HtmlReport();
ReportGenerator pdfReport = new PdfReport();

Console.WriteLine(htmlReport.GenerateReport("Quarterly revenue data"));
Console.WriteLine();
Console.WriteLine(pdfReport.GenerateReport("Quarterly revenue data"));
