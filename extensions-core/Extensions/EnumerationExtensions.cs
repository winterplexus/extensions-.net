//
//  Enumerations.cs
//
//  Code Construct System 2025
//
using System.ComponentModel.DataAnnotations;

namespace Extensions
{
    public static class EnumerationExtensions
    {
        public static string GetEnumerationDescription(this Enum enumValue)
        {
            if (enumValue != null)
            {
                var field = enumValue.GetType().GetField(enumValue.ToString());
                if (field != null)
                {
                    if (Attribute.GetCustomAttribute(field, typeof(DisplayAttribute)) is DisplayAttribute attribute)
                    {
                        if (attribute.Name != null)
                        {
                            return attribute.Name;
                        }
                    }
                }
            }
            return string.Empty;
        }

        public static T? GetEnumerationValueByDescription<T>(this string description) where T : Enum
        {
            foreach (Enum enumItem in Enum.GetValues(typeof(T)))
            {
                if (enumItem.GetEnumerationDescription() == description)
                {
                    return (T)enumItem;
                }
            }

            var message = $"Unknown description: {description}";
            throw new ArgumentException(message, nameof(description));
        }
    }
}