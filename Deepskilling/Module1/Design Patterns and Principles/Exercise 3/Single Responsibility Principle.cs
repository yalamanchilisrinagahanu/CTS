using System;

class Report
{
    public string Content;

    public Report(string content)
    {
        Content = content;
    }
}

class ReportPrinter
{
    public void PrintReport(Report report)
    {
        Console.WriteLine(report.Content);
    }
}

class Program
{
    static void Main()
    {
        Report report = new Report("Monthly Report");

        ReportPrinter printer = new ReportPrinter();

        printer.PrintReport(report);
    }
}
