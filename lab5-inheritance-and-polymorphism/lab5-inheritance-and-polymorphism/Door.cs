using System;

namespace lab5_inheritance_and_polymorphism
{
    public class Door: HouseUnit
    {
        public string color;
        private bool isDoorLocked = false;

        public Door (
            Dimentions dimentions,
            int floor,
            string color
        ) {
            this.dimentions = dimentions;
            this.floor = floor;
            this.color = color;
        }

        public override void CloseOnKey()
        {
            this.isDoorLocked = true;
        }

        public override bool Equals(Object obj)
        {
            return obj is Door door &&
                 this.dimentions.Equals(door.dimentions) &&
                 this.floor == door.floor &&
                 this.color == door.color;
        }

        public override int GetHashCode()
        {
            return this.dimentions.GetHashCode() ^ this.floor.GetHashCode() ^ this.color.GetHashCode();
        }

        public override string ToString()
        {
            return $"Door on {this.floor} floor, {this.color} color: {this.dimentions.height} X {this.dimentions.width}";
        }
    }
}
