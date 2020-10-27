using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;

namespace TechnologyTests
{
    [TestClass]
    public class Program
    {
        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(10, 10, 0.001);
        }

        Computer computer;
        int baseMemory = 512; // 512 MB
        int baseStorage = 500; // 512 GB
        Laptop laptop;
        double monitorSize = 17.2; // 17.2 inch screen
        SmartPhone phone;

        [TestInitialize]
        public void InitializeTests()
        {
            computer = new Computer("Intel", baseMemory, baseStorage);
            laptop = new Laptop("AMD", baseMemory, baseStorage, monitorSize);
            phone = new SmartPhone("Qualcomm", 512, 2, "Verizon");
        }

        [TestMethod]
        public void TestConstructor()
        {
            Assert.AreEqual(baseMemory, computer.Memory);
            Assert.AreEqual(baseStorage, computer.Storage);
        }

        [TestMethod]
        public void TestMemoryUpgrade()
        {
            computer.UpgradeMemory(512);
            Assert.AreEqual(baseMemory + 512, computer.Memory);
        }

        [TestMethod]
        public void TestStorageUpgrade()
        {
            computer.UpgradeStorage(1500);
            Assert.AreEqual(baseStorage + 1500, computer.Storage);
        }

        [TestMethod]
        public void TestLaptopConstructor()
        {
            Assert.AreEqual(baseMemory, laptop.Memory);
            Assert.AreEqual(baseStorage, laptop.Storage);
            Assert.AreEqual(monitorSize, laptop.MonitorSize, 0.001);
        }

        [TestMethod]
        public void TestLaptopUpgradeMemory()
        {
            laptop.UpgradeMemory(512);
            Assert.AreEqual(baseMemory + 512, laptop.Memory);
        }

        [TestMethod]
        public void TestLaptopReimage()
        {
            Assert.AreEqual("Laptop reimaged successfully", laptop.Reimage());
        }

        [TestMethod]
        public void TestSmartPhoneConstructor()
        {
            Assert.AreEqual("Verizon", phone.Carrier);
        }

        [TestMethod]
        public void TestActivateSmartPhone()
        {
            phone.ActivateService();
            Assert.AreEqual(true, phone.GetServiceStatus());
        }

        [TestMethod]
        public void TestDeactivateSmartPhone()
        {
            phone.DeactivateService();
            Assert.AreEqual(false, phone.GetServiceStatus());
        }
    }
}
