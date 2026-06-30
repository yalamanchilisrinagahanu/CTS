class Light:

    def on(self):
        print("Light ON")

class Command:

    def __init__(self, light):
        self.light = light

    def execute(self):
        self.light.on()

light = Light()

cmd = Command(light)

cmd.execute()
