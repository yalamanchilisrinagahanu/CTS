# Single Responsibility Principle (SRP)
class Report:
    def __init__(self, content):
        self.content = content


class ReportPrinter:
    def print_report(self, report):
        print("Report Content:")
        print(report.content)


class ReportSaver:
    def save_report(self, report):
        print("Saving report...")
        print("Report saved successfully.")


# Main Program
report = Report("Monthly Sales Report")

printer = ReportPrinter()
printer.print_report(report)

saver = ReportSaver()
saver.save_report(report)
