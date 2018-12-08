using System;

namespace lab5_inheritance_and_polymorphism
{
    public class Window: HouseUnit
    {
        public string material;
        public bool isWindowLocked = false;

        public Window(
            Dimentions dimentions,
            int floor,
            string material
        ) {
            this.dimentions = dimentions;
            this.floor = floor;
            this.material = material;
        }

        public override void CloseOnKey()
        {
            this.isWindowLocked = true;
        }

        public override bool Equals(Object obj)
        {
            return obj is Window window &&
                 this.dimentions.Equals(window.dimentions) &&
                 this.floor == window.floor &&
                 this.material == window.material;
        }

        public override int GetHashCode()
        {
            return this.dimentions.GetHashCode() ^ this.floor.GetHashCode() ^ this.material.GetHashCode();
        }

        public override string ToString()
        {
            return $"Window on {this.floor} floor, made of {this.material}: {this.dimentions.height} X {this.dimentions.width}";
        }
    }
}
