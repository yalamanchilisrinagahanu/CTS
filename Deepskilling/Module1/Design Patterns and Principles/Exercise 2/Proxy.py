class RealImage:

    def display(self):
        print("Displaying Image")

class ProxyImage:

    def __init__(self):
        self.real = RealImage()

    def display(self):
        self.real.display()

img = ProxyImage()

img.display()
