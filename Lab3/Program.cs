using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лаб-ная №3 - Полиморфизм\nВыполнил - Подолянко Владимир\n");


            Rectangle a = new Rectangle()
            {
                Name = "Прямоугольник",
                Width = 150,
                Height = 60,
                Color = System.Drawing.Color.DarkRed,
                Position = new System.Drawing.Point(30, 30)
            };
            /*Rectangle b = new Rectangle() {
                Name = "Прямоугольник Б", Width = 7.9, Height = 2.6
            };

            Console.WriteLine("Название фигуры = {0}\nПлощадь фигуры = {1}\n", a.Name, a.GetArea());*/
            Console.WriteLine("Фигура = {0}\nПлощадь = {1}\nЦвет = {2}\nПоложение фигруы = {3}\nКоординаты центра = {4}", a.Name, a.GetArea(), a.Color, a.Position, a.GetCenter());

            
            Circle c = new Circle()
            {
                Name = "Круг", R = 50,
                Color = System.Drawing.Color.Blue,
                Position = new System.Drawing.Point(50, 250)
            };
            Console.WriteLine("Фигура = {0}\nПлощадь = {1}\nЦвет = {2}\nПоложение фигруы = {3}\nКоординаты центра = {4}", c.Name, c.GetArea(), c.Color, c.Position, c.GetCenter());


            Square d = new Square()
            {
                Name = "Квадрат", Width = 100, Height = 100,
                Color = System.Drawing.Color.DarkGreen,
                Position = new System.Drawing.Point(50, 120)
            };
            Console.WriteLine("Фигура = {0}\nПлощадь = {1}\nЦвет = {2}\nПоложение фигруы = {3}\nКоординаты центра = {4}", d.Name, d.GetArea(), d.Color, d.Position, d.GetCenter());


            Triangle e = new Triangle()
            {
                Name = "Треугольник Е", Footing = 50, Height = 100,
                Color = System.Drawing.Color.Orange,
                Position = new System.Drawing.Point(50, 450),
            };
            Console.WriteLine("Название фигуры = {0}\nПлощадь фигуры = {1}\n", e.Name, e.GetArea());

            /*
             Trapezoid f = new Trapezoid()
            {
                Name = "Трапеция Ф", Height = 10, Side_1=5, Side_2=10
            };
            Console.WriteLine("Название фигуры = {0}\nПлощадь фигуры = {1}\n", f.Name, f.GetArea());


             Rhomb u = new Rhomb()
            {
                Name = "Ромб У", Footing = 12, Height = 20
            };
            Console.WriteLine("Название фигуры = {0}\nПлощадь фигуры = {1}\n", u.Name, u.GetArea());


            Rhomb k = new Rhomb()
            {
                Name = "Параллелограмм К", Footing = 13, Height = 18
            };
            Console.WriteLine("Название фигуры = {0}\nПлощадь фигуры = {1}\n", k.Name, k.GetArea());


             Regular_pentagon l = new Regular_pentagon()
            {
                Name = "Правильный пятиугольник К", R=10
            };
            Console.WriteLine("Название фигуры = {0}\nПлощадь фигуры = {1}\n", l.Name, l.GetArea());


            Regular_decagon m = new Regular_decagon()
            {
                Name = "Правильный десятиугольник М",
                R = 15
            };
            Console.WriteLine("Название фигуры = {0}\nПлощадь фигуры = {1}\n", m.Name, m.GetArea());*/

            Form frm = new Form()
            {
                Text = "Лабораторная №3 - Полиморфизм",
                Size = new System.Drawing.Size(800, 600),
                StartPosition = FormStartPosition.CenterScreen
            };
            frm.Paint += Frm_Paint;
            Application.Run(frm);
        }
        private static void Frm_Paint(object sender, PaintEventArgs e) {
            foreach (Figure f in figures) {
                f.Draw(e.Graphics);
            }
        }
        public static Figure[] figures = {
            new Rectangle(){ 
                Name = "Прямоугольник",
                Color = System.Drawing.Color.DarkRed,
                Position = new System.Drawing.Point(30, 30),
                Width = 150, Height = 60
            },
            new Square(){
                Name = "Квадрат", Width = 100, Height = 100,
                Color = System.Drawing.Color.DarkGreen,
                Position = new System.Drawing.Point(50, 120)
            },
            new Circle(){
                 Name = "Круг", R = 50,
                Color = System.Drawing.Color.Blue,
                Position = new System.Drawing.Point(50, 250)
            },
            new Triangle(){
                Name = "Треугольник",
                Color = System.Drawing.Color.Green,
                Position = new System.Drawing.Point(50, 350),
                Footing = 100, Height = 150
            },
        };
    }
}
