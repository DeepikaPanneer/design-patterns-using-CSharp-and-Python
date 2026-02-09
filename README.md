# Design Patterns using C# and Python

This repository contains implementations of design patterns in both C# and Python, organized by pattern type.

## Structure

```
design-patterns-using-CSharp-and-Python/
├── Python/
│   ├── Creational/
│   │   ├── Singleton/
│   │   ├── Factory-Method/
│   │   ├── Abstract-Factory/
│   │   ├── Builder/
│   │   └── Prototype/
│   ├── Structural/
│   │   ├── Adapter/
│   │   ├── Bridge/
│   │   ├── Composite/
│   │   ├── Decorator/
│   │   ├── Facade/
│   │   ├── Flyweight/
│   │   └── Proxy/
│   └── Behavioral/
│       ├── Chain-of-Responsibility/
│       ├── Command/
│       ├── Interpreter/
│       ├── Iterator/
│       ├── Mediator/
│       ├── Memento/
│       ├── Observer/
│       ├── State/
│       ├── Strategy/
│       ├── Template-Method/
│       └── Visitor/
└── CSharp/
    ├── Creational/
    │   ├── Singleton/
    │   ├── Factory-Method/
    │   ├── Abstract-Factory/
    │   ├── Builder/
    │   └── Prototype/
    ├── Structural/
    │   ├── Adapter/
    │   ├── Bridge/
    │   ├── Composite/
    │   ├── Decorator/
    │   ├── Facade/
    │   ├── Flyweight/
    │   └── Proxy/
    └── Behavioral/
        ├── Chain-of-Responsibility/
        ├── Command/
        ├── Interpreter/
        ├── Iterator/
        ├── Mediator/
        ├── Memento/
        ├── Observer/
        ├── State/
        ├── Strategy/
        ├── Template-Method/
        └── Visitor/
```

## Running Python Examples

Each Python pattern has a `main.py` file that can be run directly:

```bash
# Example: Run Singleton pattern
python Python/Creational/Singleton/main.py

# Example: Run Observer pattern
python Python/Behavioral/Observer/main.py
```

## Running C# Examples

Each C# pattern has a `Program.cs` file and a `.csproj` file. To run:

```bash
# Navigate to the pattern directory
cd CSharp/Creational/Singleton

# Restore and run
dotnet restore
dotnet run

# Or run directly
dotnet run --project CSharp/Creational/Singleton/Singleton.csproj
```

## Pattern Categories

### Creational Patterns
- **Singleton**: Ensures a class has only one instance
- **Factory Method**: Creates objects without specifying exact classes
- **Abstract Factory**: Creates families of related objects
- **Builder**: Constructs complex objects step by step
- **Prototype**: Creates objects by cloning existing instances

### Structural Patterns
- **Adapter**: Allows incompatible interfaces to work together
- **Bridge**: Separates abstraction from implementation
- **Composite**: Composes objects into tree structures
- **Decorator**: Attaches additional responsibilities dynamically
- **Facade**: Provides a simplified interface to a complex subsystem
- **Flyweight**: Minimizes memory usage by sharing state
- **Proxy**: Provides a surrogate or placeholder for another object

### Behavioral Patterns
- **Chain of Responsibility**: Passes requests along a chain of handlers
- **Command**: Encapsulates requests as objects
- **Interpreter**: Defines a grammar representation and interpreter
- **Iterator**: Provides sequential access to elements
- **Mediator**: Defines how objects interact
- **Memento**: Captures and restores object state
- **Observer**: Defines one-to-many dependency between objects
- **State**: Allows object to alter behavior when state changes
- **Strategy**: Defines a family of algorithms
- **Template Method**: Defines algorithm skeleton
- **Visitor**: Separates algorithms from objects
