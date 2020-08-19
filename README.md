# DateOverride [<img src="https://raw.githubusercontent.com/raschmitt/date-override/master/icon.png" align='right' />](https://github.com/raschmitt/date-override)

[![GitHub Workflow Status](https://img.shields.io/github/workflow/status/raschmitt/date-override/.NET%20Core%20-%20Build%20&%20Test?label=Build%20%26%20Test&style=flat-square)](https://github.com/raschmitt/date-override/actions?query=workflow%3A%22.NET+Core+-+Build+%26+Test%22)
[![GitHub Workflow Status](https://img.shields.io/github/workflow/status/raschmitt/date-override/Nuget%20Deploy?label=Deploy&style=flat-square)](https://github.com/raschmitt/date-override/actions?query=workflow%3A%22Nuget+Deploy%22)
[![Codecov](https://img.shields.io/codecov/c/github/raschmitt/date-override?label=Code%20Coverage&style=flat-square)](https://codecov.io/gh/raschmitt/date-override)
[![Nuget](https://img.shields.io/nuget/v/DateOverride?label=Nuget&style=flat-square)](https://www.nuget.org/packages/DateOverride/)
[![Nuget](https://img.shields.io/nuget/dt/DateOverride?color=Blue&label=Downloads&style=flat-square)](https://www.nuget.org/stats/packages/DateOverride?groupby=Version)

DateOverride is a simple solution for mocking date properties with private setters in C#.

## Dependencies

- .NETStandard 2.0

## Install

- ### Package Manager Console

```
Install-Package DateOverride
```

- ### .Net CLI

```
dotnet add package DateOverride
```

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
    item.SetDate(nameof(item.CreatedAt), tomorrow);
    
    //Assert
    item.Date.Should().BeAfter(today);
}
    
```

## Contributions

  Contributions and feature requests are always welcome.
