**Command Pattern Using C#** is a project demonstrating the implementation of the Command Design Pattern in C#. This pattern is useful for encapsulating all the information needed to perform an action or trigger an event.

## Key Components

### Command.cs
- Defines the `ICommand` interface with a `Execute` method.
- Contains concrete command classes implementing the `ICommand` interface.

### Program.cs
- Sets up and demonstrates the use of the command pattern.
- Creates command objects and executes them through an invoker.

## Features

- **Encapsulation of Requests:** Encapsulates a request as an object, thereby allowing for parameterization and queuing of requests.
- **Decoupling of Sender and Receiver:** Decouples the classes that invoke the operation from the object that performs the operation.
