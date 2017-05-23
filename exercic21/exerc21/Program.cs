/* 
 * Aluno: Raul Figueira Miranda
 * Exercício 21  [20/05/2017]
 * 
 * Defina uma classe abstrata Shape com o método abstrato CalculateSurface() e campos width e height. 
 * Defina duas novas classes Triangle e Rectangle que implementam o método virtual para retornar 
 * a área da figura (height*width para o retângulo e height*width/2 para o triângulo). 
 * Defina a classe Circle e o construtor adequado para que na inicialização height seja 
 * sempre igual a width e implemente o método CalculateSurface(). 
 * Escreva um programa que teste o comportamento do método CalculateSurface() para 
 * as diferentes figuras (Circle, Rectangle, Triangle) armazenadas em um array.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc21
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Shape> shapes = new List<Shape>();
            Shape triangulo = new Triangle(5, 10);
            Shape retangulo = new Rectangle(5, 10);
            Shape circulo = new Circle(5);
            //shapes.Add(triangulo);
            //shapes.Add(retangulo);
            //shapes.Add(circulo);

            Shape[] shapes = new Shape[3];
            shapes[0] = triangulo;
            shapes[1] = retangulo;
            shapes[2] = circulo;

            bool isTriangle = false, isRectangle = false, isCircle = false;

            foreach (Shape shape in shapes)
            {
                isTriangle = shape.GetType() == typeof(Triangle);
                isRectangle = shape.GetType() == typeof(Rectangle);
                isCircle = shape.GetType() == typeof(Circle);

                if(isTriangle)
                {
                    Console.WriteLine(" - Triângulo -\nLargura: {0}\nAltura: {1}\nÁrea: {2}\n", shape.Width, shape.Height, shape.CalculateSurface());
                }
                else if(isRectangle)
                {
                    Console.WriteLine(" - Retângulo -\nLargura: {0}\nAltura: {1}\nÁrea: {2}\n", shape.Width, shape.Height, shape.CalculateSurface());
                }
                else if(isCircle)
                {
                    Console.WriteLine(" - Círculo -\nDiâmetro: {0}\nÁrea: {1}\n", shape.Width, shape.CalculateSurface());
                }
                else
                {

                }
            }
            Console.ReadLine();
        }
    }

    class Circle : Shape
    {
        public Circle(double raio)
        {
            this.Width = raio * 2;
            this.Height = raio * 2;
        }

        public override double CalculateSurface()
        {
            return Math.PI * Math.Pow(this.Width / 2, 2);
        }
    }

    class Rectangle : Shape
    {
        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public override double CalculateSurface()
        {
            return (this.Height * this.Width);
        }
    }

    class Triangle : Shape
    {
        public Triangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public override double CalculateSurface()
        {
            return (this.Height * this.Width) / 2;
        }
    }

    abstract class Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public abstract double CalculateSurface();
    }
}
