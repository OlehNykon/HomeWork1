using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Rectangle
    {
         private double RLenght, RWide, P, S;

         public double Ax { get; set; }
         public double Ay { get; set; }
         public double Bx { get; set; }
         public double By { get; set; }


    public void CountData()
    {

        if (Ax > Bx)
        {
            RLenght = Ax - Bx;
        }

        else if (Bx > Ax)
        {
            RLenght = Bx - Ax;
        }

        else Console.WriteLine("\n NEVIRNO VVEDENO");


        if (Ay > By)
        {
            RWide = Ay - By;
        }

        else if (By > Ay)
        {
            RLenght = By - Ay;
        }

        else Console.WriteLine("\n NEVIRNO VVEDENO");

    }


    public double CalcS()
    {
         S = RLenght * RWide;
        return S;
    }


    public double CalcP()
    {
        P = 2 * (RLenght + RWide);
        return P;
    }
}



     
namespace RetGetSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VVEDIT COORDYNATY (Ax, Ay, Bx, By) : ");

            Rectangle rectangle = new Rectangle();

           rectangle.Ax = Convert.ToDouble(Console.ReadLine());
           rectangle.Ay = Convert.ToDouble(Console.ReadLine());
           rectangle.Bx = Convert.ToDouble(Console.ReadLine());
           rectangle.By = Convert.ToDouble(Console.ReadLine());


            rectangle.CountData(); 
            Console.WriteLine("Perymetr: " +rectangle.CalcP());
            Console.WriteLine("Ploscha: " +rectangle.CalcS());
            
            Console.ReadLine();
        }
    }
}
