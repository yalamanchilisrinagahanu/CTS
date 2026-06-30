class OldPrinter:

    def old_print(self):
        return "Old Printer"

class Adapter:

    def __init__(self, old):
        self.old = old

    def print(self):
        print(self.old.old_print())

obj = Adapter(OldPrinter())

obj.print()
