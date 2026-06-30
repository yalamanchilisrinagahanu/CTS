class Keyboard:

    def type(self):
        print("Typing")

class Computer:

    def __init__(self, keyboard):
        self.keyboard = keyboard

    def start(self):
        self.keyboard.type()

keyboard = Keyboard()
computer = Computer(keyboard)

computer.start()
