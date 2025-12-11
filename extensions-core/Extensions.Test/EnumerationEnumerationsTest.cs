//
//  EnumerationsTest.cs
//
//  Code Construct System 2025
//
using System.ComponentModel.DataAnnotations;

[assembly: Parallelize(Scope = ExecutionScope.MethodLevel)]
namespace Extensions.Test
{
    public enum StatusCode
    {
        [Display(Name = "New")]
        New = 1,
        [Display(Name = "Opened")]
        Opened = 2,
        [Display(Name = "In Progress")]
        InProgress = 3,
        [Display(Name = "Completed")]
        Completed = 4,
        [Display(Name = "Closed")]
        Closed = 5
    }

    [TestClass]
    public class EnumerationEnumerationsTest
    {
        [TestMethod]
        public void GetEnumerationDescriptionTest()
        {
            Console.WriteLine("");
            Console.WriteLine("class method EnumerationExtensions.GetEnumerationDescription tests");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("StatusCode.New        : {0}", EnumerationExtensions.GetEnumerationDescription(StatusCode.New));
            Console.WriteLine("StatusCode.Opened     : {0}", EnumerationExtensions.GetEnumerationDescription(StatusCode.Opened));
            Console.WriteLine("StatusCode.InProgress : {0}", EnumerationExtensions.GetEnumerationDescription(StatusCode.InProgress));
            Console.WriteLine("StatusCode.Completed  : {0}", EnumerationExtensions.GetEnumerationDescription(StatusCode.Completed));
            Console.WriteLine("StatusCode.Closed     : {0}", EnumerationExtensions.GetEnumerationDescription(StatusCode.Closed));

            Assert.AreEqual("New",         EnumerationExtensions.GetEnumerationDescription(StatusCode.New));
            Assert.AreEqual("Opened",      EnumerationExtensions.GetEnumerationDescription(StatusCode.Opened));
            Assert.AreEqual("In Progress", EnumerationExtensions.GetEnumerationDescription(StatusCode.InProgress));
            Assert.AreEqual("Completed",   EnumerationExtensions.GetEnumerationDescription(StatusCode.Completed));
            Assert.AreEqual("Closed",      EnumerationExtensions.GetEnumerationDescription(StatusCode.Closed));
        }

        [TestMethod]
        public void GetEnumerationValueByDescriptionTest()
        {
            Console.WriteLine("");
            Console.WriteLine("class method EnumerationExtensions.GetEnumerationValueByDescription tests");
            Console.WriteLine("-------------------------------------------------------------------------");

            if (EnumerationExtensions.GetEnumerationValueByDescription<StatusCode>("New") == StatusCode.New)
            {
                Console.WriteLine("enumeration value: StatusCode.New");
            }
            if (EnumerationExtensions.GetEnumerationValueByDescription<StatusCode>("Opened") == StatusCode.Opened)
            {
                Console.WriteLine("enumeration value: StatusCode.Opened");
            }
            if (EnumerationExtensions.GetEnumerationValueByDescription<StatusCode>("In Progress") == StatusCode.InProgress)
            {
                Console.WriteLine("enumeration value: StatusCode.InProgress");
            }
            if (EnumerationExtensions.GetEnumerationValueByDescription<StatusCode>("Completed") == StatusCode.Completed)
            {
                Console.WriteLine("enumeration value: StatusCode.Completed");
            }
            if (EnumerationExtensions.GetEnumerationValueByDescription<StatusCode>("Closed") == StatusCode.Closed)
            {
                Console.WriteLine("enumeration value: StatusCode.Closed");
            }

            Console.WriteLine("");
            Console.Write("invalid argument test: ");

            try
            {
                if (EnumerationExtensions.GetEnumerationValueByDescription<StatusCode>("Old") == StatusCode.New)
                {
                    Console.WriteLine("enumeration value: StatusCode.New");
                }
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine("argument exception-> {0}", ae.Message);
            }

            Assert.AreEqual(StatusCode.New,        EnumerationExtensions.GetEnumerationValueByDescription<StatusCode>("New"));
            Assert.AreEqual(StatusCode.Opened,     EnumerationExtensions.GetEnumerationValueByDescription<StatusCode>("Opened"));
            Assert.AreEqual(StatusCode.InProgress, EnumerationExtensions.GetEnumerationValueByDescription<StatusCode>("In Progress"));
            Assert.AreEqual(StatusCode.Completed,  EnumerationExtensions.GetEnumerationValueByDescription<StatusCode>("Completed"));
            Assert.AreEqual(StatusCode.Closed,     EnumerationExtensions.GetEnumerationValueByDescription<StatusCode>("Closed"));
        }
    }
}