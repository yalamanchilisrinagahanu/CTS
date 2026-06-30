class Add:

    def execute(self, a, b):
        return a + b

class Multiply:

    def execute(self, a, b):
        return a * b

strategy = Add()

print(strategy.execute(5, 4))

strategy = Multiply()

print(strategy.execute(5, 4))
