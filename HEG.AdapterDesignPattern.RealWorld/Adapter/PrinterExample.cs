namespace HEG.AdapterDesignPattern.RealWorld.Adapter
{
    public interface IPrinter
    {
        void Print(string content);
    }

    public class LegacyPrinter
    {
        public void PrintLegacy(string text)
        {
            Console.WriteLine($"Legacy printer output: {text}");
        }
    }

    public class PrinterAdapter : IPrinter
    {
        private readonly LegacyPrinter _legacyPrinter;

        public PrinterAdapter(LegacyPrinter legacyPrinter)
        {
            _legacyPrinter = legacyPrinter;
        }

        public void Print(string content)
        {
            _legacyPrinter.PrintLegacy(content);
        }
    }
}
