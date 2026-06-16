using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab2
{
    abstract class Shape
    {
        protected float _x;
        protected float _y;
        protected float _width;
        protected float _height;

        protected Shape(float x, float y, float width, float height)
        {
            _x = x;
            _y = y;
            _width = width;
            _height = height;
        }

        public abstract float Area();

        public abstract void Draw(PictureBox pictureBox, Color color);

        public float AreaValue()
        {
            return Area();
        }

        public static Shape operator ++(Shape s)
        {
            s._x += 10;
            s._y += 10;
            return s;
        }

        public static Shape operator --(Shape s)
        {
            s._x -= 10;
            s._y -= 10;
            return s;
        }

        public static float operator +(Shape a, Shape b)
        {
            return a.Area() + b.Area();
        }

        public static float operator -(Shape a, Shape b)
        {
            return a.Area() - b.Area();
        }

        public static bool operator >(Shape a, Shape b)
        {
            return a.Area() > b.Area();
        }

        public static bool operator <(Shape a, Shape b)
        {
            return a.Area() < b.Area();
        }
    }
}