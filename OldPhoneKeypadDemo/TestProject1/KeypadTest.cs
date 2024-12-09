using ConsoleKeypad;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class KeypadTest
    {
        

        [TestInitialize]
        public void Setup()
        { 
        }

        [TestMethod]
        public void ValidationE()
        {
            var result = CommonDisplay.OldPhonePad("33#");
            Assert.AreEqual("E", result);
        }
        [TestMethod]
        public void ValidationB()
        {
            var result = CommonDisplay.OldPhonePad("227*#");
            Assert.AreEqual("B", result);
        }
        [TestMethod]
        public void  ValidationHello()
        {
            var result = CommonDisplay.OldPhonePad("4433555 555666#");
            Assert.AreEqual("HELLO", result);
        }
        [TestMethod]
        public void ValidationTurning()
        {
            var result = CommonDisplay.OldPhonePad("8 88777444666*664#");
            Assert.AreEqual("TURING", result);
        }
    }
}