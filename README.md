# DateOverride <img src="https://raw.githubusercontent.com/raschmitt/date-override/master/DateOverride/DateOverride/icon.png" align='right' />
![.NET Core - Build & Test](https://github.com/raschmitt/date-override/workflows/.NET%20Core%20-%20Build%20&%20Test/badge.svg) ![Nuget Deploy](https://github.com/raschmitt/date-override/workflows/Nuget%20Deploy/badge.svg)

DateOverride is a simple solution for mocking date properties with private setters in C#.

## Dependencies

- .NETStandard 2.0

## Install

- ### Package Manager Console

`Install-Package DateOverride`

- ### .Net CLI

`dotnet add package DateOverride`

## How to use

DateOverride can set any `DateTime` or `DateTimeOffset` property, with the `SetDate()` extension method, trough the following syntax:

```c#
  object.SetDate(property, date);
```
Where:

- obejct : the object containing the property to be set
- property : the property name as a string
- date : the date which to set the property

### Sample

```c#
public class Item
{
  public DateTime CreatedAt { get; private set; }
}

[Fact]
public void Should_set_DateTime()
{
    //Arrange
    var item = new Item();   
    
    var today = DateTime.Now;
    var tomorrow = DateTime.Now.AddDays(1);
    
    //Act
    item.SetDate(nameof(sut.CreatedAt), tomorrow);
    
    //Assert
    item.Date.Should().BeAfter(today);
}
    
```

## Constributions

  Contributions and feature requests are always welcome.
