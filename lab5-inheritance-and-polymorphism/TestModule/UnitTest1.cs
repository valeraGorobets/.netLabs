using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab5_inheritance_and_polymorphism;

namespace TestModule
{
    [TestClass]
    public class TestWindowsClass
    {
        [TestMethod]
        public void TestWindowEqualMethod()
        {
            Window window1 = new Window(new Dimentions(2, 1.5), 2, "Wood");
            Window window2 = new Window(new Dimentions(2, 1.5), 2, "Wood");
            Assert.IsTrue(window1.Equals(window2));
        }

        [TestMethod]
        public void TestWindowNotEqualMethod()
        {
            Window window1 = new Window(new Dimentions(2, 1.5), 2, "Wood");
            Window window2 = new Window(new Dimentions(2, 1.5), 3, "Wood");
            Assert.IsFalse(window1.Equals(window2));
        }

        [TestMethod]
        public void TestWindowToStringMethod()
        {
            const string windowReport = "Window on 1 floor, made of Plastic: 2 X 3";
            Window window = new Window(new Dimentions(2, 3), 1, "Plastic");
            Assert.AreEqual(window.ToString(), windowReport);
        }

        [TestMethod]
        public void TestWindowClosingMethod()
        {
            Window window = new Window(new Dimentions(2, 3), 1, "Plastic");
            window.CloseOnKey();
            Assert.IsTrue(window.isWindowLocked);
        }
    }

    [TestClass]
    public class TestHouseClass
    {
        House house = new House();

        [TestMethod]
        public void TestCountingWindowsMethod()
        {
            house.AddWindow(2, 1.5, 2, "Wood");
            house.AddWindow(3, 4, 1, "Plastic");
            house.AddWindow(1, 2, 3, "Wood");
            this.WriteToConsoleAmountOfWindows();
            Assert.AreEqual(house.CountAmountOfWindows(), 3);
        }

        public void WriteToConsoleAmountOfWindows()
        {
            Console.WriteLine($"Amount of Windows: {this.house.CountAmountOfWindows()}");
        }

        [TestMethod]
        public void TestCountingDoorsMethod()
        {
            house.AddDoor(2, 1.5, 2, "Red");
            house.AddDoor(2, 1.8, 2, "Red");
            house.AddDoor(2.5, 2, 1, "White");
            house.AddDoor(2.4, 1.8, 1, "Black");
            this.WriteToConsoleAmountOfDoors();
            Assert.AreEqual(house.CountAmountOfDoors(), 4);
        }

        public void WriteToConsoleAmountOfDoors()
        {
            Console.WriteLine($"Amount of Doors: {this.house.CountAmountOfDoors()}");
        }
    }
}
