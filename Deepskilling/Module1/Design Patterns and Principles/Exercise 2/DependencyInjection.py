class Service:

    def serve(self):
        print("Service Running")

class Client:

    def __init__(self, service):
        self.service = service

    def execute(self):
        self.service.serve()

service = Service()

client = Client(service)

client.execute()
