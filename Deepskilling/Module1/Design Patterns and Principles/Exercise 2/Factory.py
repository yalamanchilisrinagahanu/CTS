class Car:

    def drive(self):
        print("Driving Car")

class Bike:

    def drive(self):
        print("Riding Bike")

class Factory:

    def create(self, vehicle):

        if vehicle == "car":
            return Car()

        return Bike()

factory = Factory()

obj = factory.create("car")

obj.drive()
