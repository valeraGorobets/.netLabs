using System;
using System.Collections.Generic;

namespace lab7_interfaces
{
    public interface IPaper<T>
    {
        void Burn(int temperature);
        void WriteOnMe(T information);
    }

    public abstract class Notebook<T> : IPaper<T>
    {
        private readonly int IgnitionTemperature = 233;
        private readonly int pageAmount;

        public int PageAmount { get => PageAmount; set => PageAmount = value; }

        public void Burn(int temperature)
        {
            if ( temperature >= this.IgnitionTemperature)
            {
                Console.WriteLine("Fire! Notebook is buring!");
            }
        }

        public abstract void WriteOnMe(T information);
    }
}
