using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
     class Rectangle 
    {

        private double Ax, Ay, Bx, By,  RLenght, RWide, P, S;

        public Rectangle(double Ax, double Ay, double Bx, double By)
        {

             this.Ax = Ax;
             this.Ay = Ay;

             this.Bx = Bx;
             this.Ay = Ay;

            if (Ax > Bx) {
                RLenght = Ax - Bx;
            }

            else if (Bx > Ax) {
                RLenght = Bx - Ax;
            }

            else Console.WriteLine("\n NEVIRNO VVEDENO");


            if (Ay > By){
                RWide = Ay - By;
            }

            else if (By > Ay){
                RLenght = By - Ay;
            }

            else Console.WriteLine("\n NEVIRNO VVEDENO");

        }


        public double CalcS() {

            S = RLenght * RWide;
            return S;
        }


        public double CalcP() {
            P = 2 * (RLenght + RWide);
            return P;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("VVEDIT COORDYNATY (Ax, Ay, Bx, By) : ");

            double Ax = Convert.ToDouble(Console.ReadLine());
            double Ay = Convert.ToDouble(Console.ReadLine());
            double Bx = Convert.ToDouble(Console.ReadLine());
            double By = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle (Ax,  Ay, Bx, By);

            Console.WriteLine(rectangle.CalcP());
            Console.WriteLine(rectangle.CalcS());

            rectangle.CalcP();
            rectangle.CalcS();

            Console.ReadLine();

        }
    }
}