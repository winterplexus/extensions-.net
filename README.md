Extensions Library for .NET
=================================
Extensions library based on .NET 9 platform and contains classes for .NET object extensions.

Library includes the following components:

* Enumerations class
* Strings class

## Enumerations class

```
public static class Enumerations
{
    public static string GetEnumerationDescription(this Enum enumValue) ...
    public static T? GetEnumerationValueByDescription<T>(this string description) where T : Enum ...
}
```
## Strings class

```
public static class Strings
{
    public static string GetDelimitedString(this ICollection<string> collection, char delimiter) ...
    public static ICollection<string> SplitDelimitedString(this string stringValue, char delimiter) ...
}
```