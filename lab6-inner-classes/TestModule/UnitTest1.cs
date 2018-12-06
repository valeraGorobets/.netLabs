using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab6_inner_classes;

namespace TestModule
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestOSNameSetter()
        {
            Computer windowsComputer = new Computer(Computer.OSName.Windows);
            StringAssert.Equals(windowsComputer.operatingSystem, Computer.OSName.Windows);
        }

        [TestMethod]
        public void TestRamAmountConfig()
        {
            Computer macComputer = new Computer(Computer.OSName.MacOS);
            Console.WriteLine(macComputer.GetPreferableConfig());
            Assert.AreEqual(macComputer.ram.Amount, 32);
        }

        [TestMethod]
        public void TestRamTypeConfig()
        {
            Computer macComputer = new Computer(Computer.OSName.MacOS);
            StringAssert.Equals(macComputer.ram.Type, "DDR4");
        }

        [TestMethod]
        public void TestProcessorNameConfig()
        {
            Computer linuxComputer = new Computer(Computer.OSName.Linux);
            StringAssert.Equals(linuxComputer.processor.Name, "Intel Core i5 7200U");
        }

        [TestMethod]
        public void TestProcessorCoresConfig()
        {
            Computer linuxComputer = new Computer(Computer.OSName.Linux);
            Assert.AreEqual(linuxComputer.processor.Cores, 2);
        }

        [TestMethod]
        public void TestProcessorClockFrequencyConfig()
        {
            Computer otherComputer = new Computer(Computer.OSName.Other);
            Assert.AreEqual(otherComputer.processor.ClockFrequency, 3);
        }

        [TestMethod]
        public void TestWindowsComputerConfig()
        {
            const string windowsConfig = "OS Windows, 16GB of DDR4 onboard memory, Processor 3.8GHz 4 cores Intel Core i7 7700HQ";
            Computer windowsComputer = new Computer(Computer.OSName.Windows);
            StringAssert.Equals(windowsComputer.GetPreferableConfig(), windowsConfig);
        }

        [TestMethod]
        public void TestMacComputerConfig()
        {
            const string macConfig = "OS MacOS, 32GB of DDR4 onboard memory, Processor 4.3GHz 6 cores Intel Core i9";
            Computer macComputer = new Computer(Computer.OSName.MacOS);
            StringAssert.Equals(macComputer.GetPreferableConfig(), macConfig);
        }
    }
}
