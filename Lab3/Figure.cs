using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Lab3
{
    public abstract class Figure
    {
        public string Name { get; set; }
        public System.Drawing.Color Color { get; set; }
        public System.Drawing.Point Position { get; set; }
        public System.Drawing.Point Position1 { get; set; }
        public System.Drawing.Point Position2 { get; set; }
        public abstract double GetArea();
        public abstract System.Drawing.Point GetCenter();
        public abstract void Draw(Graphics gr);
    }

    class Rectangle : Figure { //Прямоугольник
        public double Width, Height;
        public override double GetArea()
        {
            return Width * Height;
        }
        public override Point GetCenter()
        {
            return new Point((int)(Position.X + Width / 2), (int)(Position.Y + Height / 2));
        }
        public override void Draw(Graphics gr)
        {
            gr.DrawRectangle(new Pen(Color), Position.X, Position.Y, (int)Width, (int)Height);
            gr.DrawString(GetArea().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
    class Circle: Figure //Круг
    {
        public double R;
        public override double GetArea()
        {
            return Math.PI * R * R;
        }
        public override Point GetCenter()
        {
            return new Point((int)(Position.X + R / 2), (int)(Position.Y + R / 2));
        }
        public override void Draw(Graphics gr)
        {
            gr.DrawEllipse(new Pen(Color), Position.X, Position.Y, (int)R*2, (int)R*2);
            gr.DrawString(GetArea().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());

        }
    }
    class Square : Figure //Квадрат
    {
        public double Width, Height;
        public override double GetArea()
        {
            return Width * Height;
        }
        public override Point GetCenter()
        {
            return new Point((int)(Position.X + Width / 2), (int)(Position.Y + Height / 2));
        }
        public override void Draw(Graphics gr)
        {
            gr.DrawRectangle(new Pen(Color), Position.X, Position.Y, (int)Width, (int)Height);
            gr.DrawString(GetArea().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
    class Triangle : Figure  //Треугольник
    {
        public double Footing, Height;
        
        public override double GetArea()
        {
            return 0.5 * Footing * Height;
        }
        public override Point GetCenter()
        {
            return new Point((int)(Position.X + Footing / 2), (int)(Position.Y + Height / 2));
        }
        public override void Draw(Graphics gr)
        {
            Point[] points = new Point[3];
            points[0] = new Point((int)Position.X + 0, (int)Position.Y + 0);
            points[1] = new Point((int)Position.X + 0, (int)Position.Y + (int)this.Height);
            points[2] = new Point((int)Position.X + (int)this.Footing, Position.Y + (int)this.Height);
            gr.DrawPolygon(new Pen(Color),points);
            gr.DrawString(GetArea().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }/*
    class Trapezoid : Figure //Трапеция
    {
        public double Height, Side_1, Side_2;
        public override double GetArea()
        {
            return 0.5 * Height * (Side_1 + Side_2);
        }
    }
    class Rhomb : Figure //Ромб
    {
        public double Footing, Height;
        public override double GetArea()
        {
            return Footing * Height;
        }
    }
    class Parallelogram : Figure //Параллелограмм
    {
        public double Footing, Height;
        public override double GetArea()
        {
            return Footing * Height;
        }
    }
    class  Regular_pentagon : Figure //Правильный пятиугольник
    {
        public double PI = Math.PI/5, R;
        public override double GetArea()
        {
            return 5 * R * R * Math.Tan(PI);
        }
    }
    class Regular_decagon : Figure //Правильный десятиугольник
    {
        public double PI = Math.PI / 10, R;
        public override double GetArea()
        {
            return 10 * R * R * Math.Tan(PI);
        }
    }*/
}