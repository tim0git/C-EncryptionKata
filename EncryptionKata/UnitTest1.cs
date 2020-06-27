using NUnit.Framework;

namespace EncryptionKata
{
    public class Tests
    {
        /* [SetUp]
        public void Setup()
        {
        } */

        [Test]
        public void Converts_First_Letter_to_ASCII_Code()
        {
            string input = "H";
            string output = Encryption.Class1.GetEncryption(input);

            Assert.AreEqual("72", output);
        }

        [Test]
        public void Swaps_Characters_At_potionion2_And_String_Length()
        {
            string input = "Hello";
            string output = Encryption.Class1.GetEncryption(input);

            Assert.AreEqual("72olle", output);
        }

        [Test]
        public void Good_Equals_103doo()
        {
            string input = "good";
            string output = Encryption.Class1.GetEncryption(input);

            Assert.AreEqual("103doo", output);
        }

        [Test]
        public void Hello_World_Equals_104olle_119drlo()
        {
            string input = "hello world";
            string output = Encryption.Class1.GetEncryption(input);

            Assert.AreEqual("104olle 119drlo", output);
        }

        [Test]
        public void Ab_should_be65b()
        {
            string input = "Ab";
            string output = Encryption.Class1.GetEncryption(input);

            Assert.AreEqual("65b", output);
        }

        [Test]
        public void Empty_String_Should_return_Empty_String()
        {
            string input = "";
            string output = Encryption.Class1.GetEncryption(input);

            Assert.AreEqual("", output);
        }

    }
}