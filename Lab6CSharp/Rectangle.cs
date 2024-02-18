using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab6CSharp
{
    public class Rectangle : IEnumerable<int>
    {
        protected int a;
        protected int b;
        protected int c;

        public Rectangle(int sideA, int sideB, int color)
        {
            a = sideA;
            b = sideB;
            c = color;
        }

        public void PrintSides()
        {
            Console.WriteLine($"Sides of rect: {a}, {b}");
        }

        public int CalculatePerimeter()
        {
            return 2 * (a + b);
        }

        public int CalculateArea()
        {
            return a * b;
        }

        public bool IsSquare()
        {
            return a == b;
        }

        public int SideA
        {
            get { return a; }
            set { a = value; }
        }

        public int SideB
        {
            get { return b; }
            set { b = value; }
        }

        public int Color
        {
            get { return c; }
        }

        // Індексатор
        public int this[int index]
        {
            get
            {
                if (index == 0)
                    return a;
                else if (index == 1)
                    return b;
                else if (index == 2)
                    return c;
                else
                    throw new IndexOutOfRangeException("Invalid index. Valid indices are 0, 1, and 2.");
            }
            set
            {
                if (index == 0)
                    a = value;
                else if (index == 1)
                    b = value;
                else if (index == 2)
                    c = value;
                else
                    throw new IndexOutOfRangeException("Invalid index. Valid indices are 0, 1, and 2.");
            }
        }



        // Перетворення типу
        public static explicit operator string(Rectangle rect)
        {
            return $"Rectangle: Side A = {rect.a}, Side B = {rect.b}, Color = {rect.c}";
        }

        public static explicit operator Rectangle(string str)
        {
            //"SideA,SideB,Color"
            string[] parts = str.Split(',');
            if (parts.Length != 3)
                throw new FormatException("Invalid format for Rectangle string conversion.");
            int sideA, sideB, color;
            if (!int.TryParse(parts[0], out sideA) || !int.TryParse(parts[1], out sideB) || !int.TryParse(parts[2], out color))
                throw new FormatException("Invalid format for Rectangle string conversion.");
            return new Rectangle(sideA, sideB, color);
        }

        // Імплементація інтерфейсу IEnumerable
        public IEnumerator<int> GetEnumerator()
        {
            yield return a;
            yield return b;
            yield return c;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
