using System;
using Lab4_Kulazhin.Lab4Exceptions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Kulazhin
{
    class Rectangle : ITwoDimensionObjects
    {
        private readonly TwoDimensionPoint LeftBottom;
        private double length;
        private double width;

        public double Length
        {
            get { return length; }
            private set
            {
                if (value <= 0)
                    throw new ArgumentException("Length must be greater than zero!");
                else
                length = value;
            }
        }

        public double Width
        {
            get { return width; }
            private set
            {
                if (value <= 0)
                    throw new ArgumentException("Width must be greater than zero!");
                else
                    width = value;
            }
        }

        public TwoDimensionPoint StartPoint
        {
            get { return LeftBottom; }
        }

        public Rectangle(TwoDimensionPoint startPoint, double length, double width)
        {
            LeftBottom = startPoint;
            Length = length;
            Width = width;
        }

        public Rectangle()
        {
            LeftBottom = new();
            Length = 10.0;
            Width = 5.0;
        }

        public void Move(double x, double y)
        {
            LeftBottom.X += x;
            LeftBottom.Y += y;
        }

        public void Resize(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public static Rectangle CreateNewIntersection(Rectangle rect1, Rectangle rect2)
        {
            double leftX = Math.Max(rect1.LeftBottom.X, rect2.LeftBottom.X);
            double rightX = Math.Min(rect1.LeftBottom.X + rect1.Length, rect2.LeftBottom.X + rect2.Length);
            double bottomY = Math.Max(rect1.LeftBottom.Y, rect2.LeftBottom.Y);
            double topY = Math.Min(rect1.LeftBottom.Y + rect1.Width, rect2.LeftBottom.Y + rect2.Width);

            if (leftX < rightX && bottomY < topY)
            {
                return new Rectangle(new TwoDimensionPoint(leftX, bottomY), rightX - leftX, topY - bottomY);
            }
            else
                throw new NotIntersectException("Rectangles do not intersect!");
        }

        public static Rectangle CreateNewLeastConsistingTwo(Rectangle rect1, Rectangle rect2)
        {
            double leftX = Math.Min(rect1.LeftBottom.X, rect2.LeftBottom.X);
            double rightX = Math.Max(rect1.LeftBottom.X + rect1.Length, rect2.LeftBottom.X + rect2.Length);
            double bottomY = Math.Min(rect1.LeftBottom.Y, rect2.LeftBottom.Y);
            double topY = Math.Max(rect1.LeftBottom.Y + rect1.Width, rect2.LeftBottom.Y + rect2.Width);

            return new Rectangle(new TwoDimensionPoint(leftX, bottomY), rightX - leftX, topY - bottomY);
        }

        // Assistive methods.
    }
}
