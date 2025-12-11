Extensions Library for .NET
===========================
Extensions library based on .NET 9 platform and contains classes for .NET object extensions.

Library includes the following components:

* EnumerationExtensions class
* StringExtensions class

## EnumerationExtensions class

```
public static class EnumerationExtensions
{
    public static string GetEnumerationDescription(this Enum enumValue) ...
    public static T? GetEnumerationValueByDescription<T>(this string description) where T : Enum ...
}
```
## StringExtensions class

```
public static class StringExtensions
{
    public static string GetDelimitedString(this ICollection<string> collection, char delimiter) ...
    public static ICollection<string> SplitDelimitedString(this string stringValue, char delimiter) ...
}
```

