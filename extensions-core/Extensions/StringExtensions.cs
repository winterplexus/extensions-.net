//
//  Strings.cs
//
//  Code Construct System 2025
//
namespace Extensions
{
    public static class StringExtensions
    {
        public static string GetDelimitedString(this ICollection<string> collection, char delimiter)
        {
            string delimitedString = string.Empty;

            if (collection != null)
            {
                foreach (var item in collection)
                {
                    if (item.GetType() == typeof(string))
                    {
                        if (string.IsNullOrEmpty(delimitedString))
                        {
                            delimitedString = (string)item;
                        }
                        else
                        {
                            delimitedString += $"{delimiter}{(string)item}";
                        }
                    }
                }
            }
            return delimitedString;
        }

        public static ICollection<string> SplitDelimitedString(this string stringValue, char delimiter)
        {
            var delimitedStringList = new List<string>();

            if (!string.IsNullOrEmpty(stringValue))
            {
                char[] delimiters = [delimiter];
                foreach (var item in stringValue.Split(delimiters))
                {
                    var trimmedItem = item.Trim();

                    if (!string.IsNullOrEmpty(trimmedItem) && !delimitedStringList.Contains(trimmedItem))
                    {
                        delimitedStringList.Add(trimmedItem);
                    }
                }
            }
            return delimitedStringList.ToList();
        }
    }
}