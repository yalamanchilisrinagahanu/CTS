class Bird:
    def move(self):
        print("Bird is moving")

class Sparrow(Bird):
    def move(self):
        print("Sparrow flies")

class Penguin(Bird):
    def move(self):
        print("Penguin walks")

birds = [Sparrow(), Penguin()]

for b in birds:
    b.move()
