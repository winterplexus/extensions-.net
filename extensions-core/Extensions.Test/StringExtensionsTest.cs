//
//  StringsTest.cs
//
//  Code Construct System 2025
//
namespace Extensions.Test;

[TestClass]
public class StringExtensionsTest
{
    private readonly ICollection<string> colorsList = [ "Red",
                                                        "Blue",
                                                        "Yellow",
                                                        "Green",
                                                        "Orange",
                                                        "Purple",
                                                        "Pink",
                                                        "Brown",
                                                        "Black",
                                                        "White",
                                                        "Gray" ];

    private readonly string colorsString = "Red,Blue,Yellow,Green,Orange,Purple,Pink,Brown,Black,White,Gray";

    [TestMethod]
    public void GetDelimitedStringTest()
    {
        var result = StringExtensions.GetDelimitedString(colorsList, ',');

        Console.WriteLine("");
        Console.WriteLine("class method StringExtensions.GetDelimitedString test");
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine("delimited string: {0}", result);

        Assert.AreEqual(colorsString, result);
    }

    [TestMethod]
    public void GetSplitDelimitedStringTest()
    {
        var result = StringExtensions.SplitDelimitedString(colorsString, ',');

        Console.WriteLine("");
        Console.WriteLine("class method StringExtensions.SplitDelimitedString test");
        Console.WriteLine("-------------------------------------------------------");

        foreach (var color in colorsList)
        {
            Console.WriteLine(color);
        }

        CollectionAssert.AreEquivalent((System.Collections.ICollection?)colorsList, (System.Collections.ICollection?)result);
    }
}