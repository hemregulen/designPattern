using HEG.AdapterDesignPattern.RealWorld.Adapter;

IPrinter printer = new PrinterAdapter(new LegacyPrinter());
printer.Print("Monthly sales report");
