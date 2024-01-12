# Fluentassertions.Callbacks

A FluentAssertion extension to easily assert on callbacks.

In our projects, we often take a more functional approach and inject callbacks. A lot.
The test code often looked like this:

```csharp
public void BadUnitTest
{
    // Arrange
    int? arg1;
    string? arg2;
    var testCallback = (int a1, string a2) =>
    {
        arg1 = a1;
        arg2 = a2;
    };
    var sut = new Sut();
    
    // Act
    sut.DoSomething(testCallback);
    
    // Assert
    arg1.Should().Be(42);
    arg2.Should().Be("Hello World");
}
```

To avoid the overhead of storing the arguments in local variables, I created this extension.

## Installation

Add the `FluentAssertions.Callbacks` NuGet package to your test project.

## Usage

```csharp
using FluentAssertions.Callbacks;

public void GoodUnitTest()
{
    var testCallback = new CallbackSpy<int, string>();
    var sut = new Sut();
    
    sut.DoSomething(testCallback.Callback);
    
    testCallback.Should().HaveBeenCalledWith(42, "Hello World");
    
    // The following assertions are also possible
    testCallback.Should().HaveBeenCalled();
    testCallback.Should().HaveBeenCalledWith(Arg<int>.Is(x => x > 40), "Hello World");
}
```
