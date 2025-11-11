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
    public class EnumerationsTest
    {
        [TestMethod]
        public void GetEnumerationDescriptionTest()
        {
            Console.WriteLine("");
            Console.WriteLine("class method Enumerations.GetEnumerationDescription tests");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("StatusCode.New        : {0}", Enumerations.GetEnumerationDescription(StatusCode.New));
            Console.WriteLine("StatusCode.Opened     : {0}", Enumerations.GetEnumerationDescription(StatusCode.Opened));
            Console.WriteLine("StatusCode.InProgress : {0}", Enumerations.GetEnumerationDescription(StatusCode.InProgress));
            Console.WriteLine("StatusCode.Completed  : {0}", Enumerations.GetEnumerationDescription(StatusCode.Completed));
            Console.WriteLine("StatusCode.Closed     : {0}", Enumerations.GetEnumerationDescription(StatusCode.Closed));

            Assert.AreEqual("New",         Enumerations.GetEnumerationDescription(StatusCode.New));
            Assert.AreEqual("Opened",      Enumerations.GetEnumerationDescription(StatusCode.Opened));
            Assert.AreEqual("In Progress", Enumerations.GetEnumerationDescription(StatusCode.InProgress));
            Assert.AreEqual("Completed",   Enumerations.GetEnumerationDescription(StatusCode.Completed));
            Assert.AreEqual("Closed",      Enumerations.GetEnumerationDescription(StatusCode.Closed));
        }

        [TestMethod]
        public void GetEnumerationValueByDescriptionTest()
        {
            Console.WriteLine("");
            Console.WriteLine("class method Enumerations.GetEnumerationValueByDescription tests");
            Console.WriteLine("----------------------------------------------------------------");

            if (Enumerations.GetEnumerationValueByDescription<StatusCode>("New") == StatusCode.New)
            {
                Console.WriteLine("enumeration value: StatusCode.New");
            }
            if (Enumerations.GetEnumerationValueByDescription<StatusCode>("Opened") == StatusCode.Opened)
            {
                Console.WriteLine("enumeration value: StatusCode.Opened");
            }
            if (Enumerations.GetEnumerationValueByDescription<StatusCode>("In Progress") == StatusCode.InProgress)
            {
                Console.WriteLine("enumeration value: StatusCode.InProgress");
            }
            if (Enumerations.GetEnumerationValueByDescription<StatusCode>("Completed") == StatusCode.Completed)
            {
                Console.WriteLine("enumeration value: StatusCode.Completed");
            }
            if (Enumerations.GetEnumerationValueByDescription<StatusCode>("Closed") == StatusCode.Closed)
            {
                Console.WriteLine("enumeration value: StatusCode.Closed");
            }

            Console.WriteLine("");
            Console.Write("invalid argument test: ");

            try
            {
                if (Enumerations.GetEnumerationValueByDescription<StatusCode>("Old") == StatusCode.New)
                {
                    Console.WriteLine("enumeration value: StatusCode.New");
                }
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine("argument exception-> {0}", ae.Message);
            }

            Assert.AreEqual(StatusCode.New,        Enumerations.GetEnumerationValueByDescription<StatusCode>("New"));
            Assert.AreEqual(StatusCode.Opened,     Enumerations.GetEnumerationValueByDescription<StatusCode>("Opened"));
            Assert.AreEqual(StatusCode.InProgress, Enumerations.GetEnumerationValueByDescription<StatusCode>("In Progress"));
            Assert.AreEqual(StatusCode.Completed,  Enumerations.GetEnumerationValueByDescription<StatusCode>("Completed"));
            Assert.AreEqual(StatusCode.Closed,     Enumerations.GetEnumerationValueByDescription<StatusCode>("Closed"));
        }
    }
}