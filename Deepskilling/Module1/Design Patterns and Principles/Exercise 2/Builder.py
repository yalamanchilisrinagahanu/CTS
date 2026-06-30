class House:

    def __init__(self):
        self.parts = []

    def add(self, part):
        self.parts.append(part)

    def show(self):
        print(self.parts)

house = House()

house.add("Door")
house.add("Window")
house.add("Roof")

house.show()
