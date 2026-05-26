namespace HEG.TemplateMethodDesignPattern.RealWorld.TemplateMethod
{
    public abstract class ReportGenerator
    {
        public string GenerateReport(string content)
        {
            return string.Join(Environment.NewLine, CreateHeader(), CreateBody(content), CreateFooter());
        }

        protected virtual string CreateHeader() => "Report Header";
        protected abstract string CreateBody(string content);
        protected virtual string CreateFooter() => "Report Footer";
    }

    public class HtmlReport : ReportGenerator
    {
        protected override string CreateHeader() => "<html><body><h1>HTML Report</h1>";
        protected override string CreateBody(string content) => $"<p>{content}</p>";
        protected override string CreateFooter() => "<footer>Generated as HTML</footer></body></html>";
    }

    public class PdfReport : ReportGenerator
    {
        protected override string CreateHeader() => "PDF Report\n==========";
        protected override string CreateBody(string content) => $"[PDF CONTENT] {content}";
        protected override string CreateFooter() => "==========\nGenerated as PDF";
    }
}
