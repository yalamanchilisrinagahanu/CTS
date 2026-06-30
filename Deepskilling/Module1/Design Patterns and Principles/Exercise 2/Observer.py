class Subject:

    def __init__(self):
        self.observers = []

    def add(self, obs):
        self.observers.append(obs)

    def notify(self):
        for o in self.observers:
            o.update()

class Observer:

    def update(self):
        print("Notification Received")

subject = Subject()

observer = Observer()

subject.add(observer)

subject.notify()
