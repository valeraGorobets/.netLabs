using System;
using System.Linq;

namespace BoolVectorLibrary
{
    public enum FindValue { Zero, One };

    public class BoolVector
    {
        private bool[] vector;

        public bool[] Vector { get => vector; set => vector = value; }

        public BoolVector(params bool[] values)
        {
            Vector = values;
        }

        public string GetVectorsStringFormat()
        {
            return string.Join(", ", Vector.Select(b => b.ToString()).ToArray());
        }

        public int CountAmountOf(FindValue param)
        {
            int result = 0;
            foreach (var value in Vector)
            {
                int boolToIntValue = value ? 1 : 0;
                if (boolToIntValue == (int)param)
                {
                    result++;
                }
            }
            return result;
        }

        public static BoolVector operator !(BoolVector boolVector)
        {
            int vectorLength = boolVector.Vector.Length;
            bool[] resultVector = new bool[vectorLength];
            for (int i = 0; i < vectorLength; i++)
            {
                resultVector[i] = !boolVector.Vector[i];
            }
            return new BoolVector(resultVector);
        }

        public static BoolVector operator &(BoolVector boolVector1, BoolVector boolVector2)
        {
            if (boolVector1.Vector.Length != boolVector2.Vector.Length)
            {
                throw new System.ArgumentException("Parameters should have same length", "original");
            }

            int vectorLength = boolVector1.Vector.Length;
            bool[] resultVector = new bool[vectorLength];
            for (int i = 0; i < vectorLength; i++)
            {
                resultVector[i] = boolVector1.Vector[i] && boolVector2.Vector[i];
            }
            return new BoolVector(resultVector);
        }

        public static BoolVector operator |(BoolVector boolVector1, BoolVector boolVector2)
        {
            if (boolVector1.Vector.Length != boolVector2.Vector.Length)
            {
                throw new System.ArgumentException("Parameters should have same length", "original");
            }

            int vectorLength = boolVector1.Vector.Length;
            bool[] resultVector = new bool[vectorLength];
            for (int i = 0; i < vectorLength; i++)
            {
                resultVector[i] = boolVector1.Vector[i] || boolVector2.Vector[i];
            }
            return new BoolVector(resultVector);
        }
    }
}
