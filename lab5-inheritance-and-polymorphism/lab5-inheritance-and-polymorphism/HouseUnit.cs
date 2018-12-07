using System;

namespace lab5_inheritance_and_polymorphism
{
    public class Dimentions
    {
        public int height;
        public int width;

        public Dimentions(int height, int width)
        {
            this.height = height;
            this.width = width;
        }
        public override bool Equals(Object obj)
        {
            return obj is Dimentions dimentions &&
                this.height == dimentions.height &&
                this.width == dimentions.width;
        }

        public override int GetHashCode()
        {
            return this.height.GetHashCode() ^ this.width.GetHashCode();
        }
    }
    public abstract class HouseUnit
    {
        public Dimentions dimentions;
        public int floor;

        public abstract override bool Equals(object obj);
        public abstract override int GetHashCode();
        public abstract override string ToString();
        public abstract void CloseOnKey();
    }
}
