def decorator(func):

    def wrapper():

        print("Before")

        func()

        print("After")

    return wrapper

@decorator
def hello():
    print("Hello")

hello()
