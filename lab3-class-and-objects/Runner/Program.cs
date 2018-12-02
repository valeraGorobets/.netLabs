using System;
using BoolVectorLibrary;

namespace Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            BoolVector boolVector = new BoolVector(true, true, false, false, true);
            Console.WriteLine(boolVector.GetVectorsStringFormat());
            Console.WriteLine(boolVector.CountAmountOf(FindValue.Zero));
        }
    }
}
