from abc import ABC, abstractmethod

class Printer(ABC):
    @abstractmethod
    def print_doc(self):
        pass

class Scanner(ABC):
    @abstractmethod
    def scan_doc(self):
        pass

class MultiFunctionMachine(Printer, Scanner):

    def print_doc(self):
        print("Printing")

    def scan_doc(self):
        print("Scanning")

m = MultiFunctionMachine()
m.print_doc()
m.scan_doc()
