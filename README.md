# DateOverride [<img src="https://raw.githubusercontent.com/raschmitt/date-override/master/icon.png" align='right' />](https://github.com/raschmitt/date-override)

[![Azure DevOps builds](https://img.shields.io/azure-devops/build/raschmitt/7618d927-8467-43e2-b5e9-1aeddc1fbfdc/15?label=Build%20%26%20Test&style=flat-square)](https://dev.azure.com/raschmitt/raschmitt/_build?definitionId=15)
[![Azure DevOps builds](https://img.shields.io/azure-devops/build/raschmitt/7618d927-8467-43e2-b5e9-1aeddc1fbfdc/17?label=Deploy&style=flat-square)](https://dev.azure.com/raschmitt/raschmitt/_build?definitionId=17)
[![Sonar Coverage](https://img.shields.io/sonar/coverage/raschmitt_date-override?label=Code%20Coverage&server=https%3A%2F%2Fsonarcloud.io&style=flat-square)](https://sonarcloud.io/dashboard?id=raschmitt_date-override)
[![Nuget](https://img.shields.io/nuget/v/DateOverride?label=Nuget&style=flat-square)](https://www.nuget.org/packages/DateOverride/)
[![Nuget](https://img.shields.io/nuget/dt/DateOverride?color=Blue&label=Downloads&style=flat-square)](https://www.nuget.org/stats/packages/DateOverride?groupby=Version)

DateOverride is a simple solution for mocking date properties with private setters in C#.

## Dependencies

- [.NET Standard 2.0](https://docs.microsoft.com/en-us/dotnet/standard/net-standard)

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
