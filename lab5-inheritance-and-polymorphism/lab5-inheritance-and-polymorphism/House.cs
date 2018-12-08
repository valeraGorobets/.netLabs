using System;
using System.Collections.Generic;

namespace lab5_inheritance_and_polymorphism
{
    public class House
    {
        private readonly List<Window> windowsList = new List<Window>();
        private readonly List<Door> doorsList = new List<Door>();

        public House()
        {            

        }

        public void AddWindow(double height, double width, int floor, string material)
        {
            Dimentions dimentions = new Dimentions(height, width);
            this.windowsList.Add(new Window(dimentions, floor, material));
        }

        public void AddDoor(double height, double width, int floor, string color)
        {
            Dimentions dimentions = new Dimentions(height, width);
            this.doorsList.Add(new Door(dimentions, floor, color));
        }

        public int CountAmountOfDoors()
        {
            return this.doorsList.Count;
        }

        public int CountAmountOfWindows()
        {
            return this.windowsList.Count;
        }
    }
}
