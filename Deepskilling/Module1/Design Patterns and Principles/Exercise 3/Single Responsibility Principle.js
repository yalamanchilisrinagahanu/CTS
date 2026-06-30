class Report{

    constructor(content){
        this.content = content;
    }

}

class ReportPrinter{

    print(report){
        console.log(report.content);
    }

}

let report = new Report("Monthly Report");

let printer = new ReportPrinter();

printer.print(report);
