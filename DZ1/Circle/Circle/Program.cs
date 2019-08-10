using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{

    class Circle
    {
        private double r, S, L;
        private const double  p = 3.14;

        public void SetRadius(double r)
        {
            this.r = r;    
        }


        public void CalcL() {
            L = 2 * p * r;
            Console.WriteLine("Circle lenth is: " + L); 
                }

        public void CalcS() {
            S = p * r * r;
            Console.WriteLine("Circle square is: " + S);
        }

    }
    

    class Program
    {
        static void Main(string[] args)
        {
            
            Circle circle = new Circle();

            Console.WriteLine("Enter the radius:  ");
            double radius;
            
            radius=Convert.ToDouble(Console.ReadLine());

            circle.SetRadius(radius);
            circle.CalcL();
            circle.CalcS();


            Console.ReadLine();
        }
    }
}
