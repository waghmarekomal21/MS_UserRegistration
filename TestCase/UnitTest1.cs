using MSUserRegistration;

namespace TestCase
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FName()
        {   //Arrange
            string expected = "Komal";
            //Act
            UC1FirstName Uc1 = new UC1FirstName("Komal");
            string actual = Uc1.ValidateFirstName();
            //Assert
            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);

        }

        [TestMethod]
        public void LName()
        {
            string expected = "Waghmare";

            UC1FirstName Uc2 = new UC1FirstName("Waghmare");
            string actual = Uc2.ValidateFirstName();

            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);

        }


        [TestMethod]
        public void Email()
        {
            string expected = "waghmare@gmail.com";

            UC3Email UC3 = new UC3Email("waghmare@gmail.com");
            string actual = UC3.ValidateEmail();

            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }

        [TestMethod]
        public void MobileNumber()
        {
            string expected = "+91 9236425886";

            UC4Mobile UC4 = new UC4Mobile("+91 9236425886");
            string actual = UC4.ValideMobileNumber();

            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }
        [TestMethod]
        
        public void TestPasswordRuleOne()
        {
            string expected = "komalwaghmare";

            UC5Rule1 UCFive = new UC5Rule1("komalwaghmare");
            string actual = UC5Rule1.ValidatePassword();

            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }
        [TestMethod]

        public void Rule2()
        {
            string expected = "KomalWaghmare";

            UC6Rule2 UC6 = new UC6Rule2("KomalWaghmare");
            string actual = UC6.ValidatePassword();

            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }

        [TestMethod]
        public void Rule3()
        {
            string expected = "Komal2112";

            UC7Rule3 UC7 = new UC7Rule3("Komal2112");
            string actual = UC7.ValidatePassword();

            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }
        [TestMethod]
        public void Rule4()
        {
            string expected = "Komz@1103";

            UC8Rule4 UC8 = new UC8Rule4("Komz@1103");
            string actual = UC8.ValidatePassword();

            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }
        

    }
}