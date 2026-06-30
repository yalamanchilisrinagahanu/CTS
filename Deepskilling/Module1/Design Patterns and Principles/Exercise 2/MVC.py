class Model:

    def get_data(self):
        return "Welcome"

class View:

    def display(self, data):
        print(data)

class Controller:

    def __init__(self):
        self.model = Model()
        self.view = View()

    def update(self):
        data = self.model.get_data()
        self.view.display(data)

Controller().update()
