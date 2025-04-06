# Java vs. C# – Overview & Cheat Sheet

This document summarizes the key similarities and differences between Java and C#.

## Similarities

- Statically typed
- Object-oriented
- Garbage collection
- Classes, inheritance, interfaces, exceptions

## Differences & Code Examples

| Feature                | Java                                | C#                                 |
|------------------------|--------------------------------------|-------------------------------------|
| Package system         | `package` + folder-based             | `namespace` + file-based            |
| Imports                | `import java.util.*;`                | `using System;`                     |
| Properties             | `getX()`, `setX()` methods           | `public string Name { get; set; }` |
| Exception handling     | Checked & unchecked exceptions       | Only unchecked (no `throws`)        |
| Nullability            | Nullable by default                  | Nullable reference types with `?`   |
| String comparison      | `equals()`                           | `==` (overloaded for strings)       |
| Functional utilities   | Streams                              | LINQ                                |
| Async programming      | CompletableFuture                    | `async` / `await`                   |
| Switch syntax          | Traditional `switch`                 | Pattern Matching in `switch`        |
| Entry point            | `public static void main()`          | `static void Main()` or top-level   |

### 1. Class Definition

**Java:**

```java
public class Player {
    private final String name;

    public Player(String name) {
        this.name = name;
    }

    public String getName() {
        return name;
    }
}
```

**C#:**

```csharp
public class Player {
    public string Name { get; }

    public Player(string name) {
        Name = name;
    }
}
```

### 2. Properties

**Java:**

```java
Player player = new Player("Alex");
System.out.println(player.getName());
```

**C#:**

```csharp
Player player = new Player("Alex");
Console.WriteLine(player.Name);
```

### 4. Null Safety

**Java:**

```java
String name = null;
if (name != null) {
    System.out.println(name.toUpperCase());
} else {
    System.out.println("No Name");
}
```

**C#:**

```csharp
string? name = null;
Console.WriteLine(name?.ToUpper() ?? "No Name");
```

### 5. Async Programming

**Java:**

```java
CompletableFuture.runAsync(() -> {
    System.out.println("Doing something asynchronously...");
});
```

**C#:**

```csharp
await Task.Run(() => Console.WriteLine("Doing something asynchronously..."));
```

### 6. Pattern Matching

**Java:**

```java
Object obj = new Player("Alex");
if (obj instanceof Player player) {
    System.out.println(player.getName());
}
```

**C#:**

```csharp
object obj = new Player("Alex");
if (obj is Player player) {
    Console.WriteLine(player.Name);
}
```

### 7. Switch

**Java:**

```java
tring value = "A";
switch (value) {
    case "A" -> System.out.println("Value is A");
    case "B" -> System.out.println("Value is B");
    default -> System.out.println("Unknown value");
}
```

**C#:**

```csharp
string value = "A";
value switch
{
    "A" => Console.WriteLine("Value is A"),
    "B" => Console.WriteLine("Value is B"),
    _   => Console.WriteLine("Unknown value")
}
```

## Style Guide

| Element        | Java        | C#          |
| -------------- | ----------- | ----------- |
| Class names    | PascalCase  | PascalCase  |
| Method names   | camelCase   | PascalCase  |
| Variable names | camelCase   | camelCase   |
| Constants      | UPPER_CASE  | PascalCase  |
| File names     | Match class | Match class |
| Braces         | New line    | Same line   |

## Creating a Project in C#

```bash
dotnet new console -n Name
cd MyApp
dotnet run
```


## Requirements

- Install the .NET SDK from dotnet.microsoft.com
- Use one of the following IDEs:
  - Visual Studio (Windows/macOS)
  - JetBrains Rider (cross-platform)
  - Visual Studio Code with C# extension
  - ...

## Helpful Resources

- https:learn.microsoft.com/dotnet/csharp/
- https:learn.microsoft.com/dotnet/core/tutorials/
- https:docs.godotengine.org/en/stable/tutorials/scripting/c_sharp/
