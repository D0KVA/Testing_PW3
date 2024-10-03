using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputationalOperations
{
    public class ComputationalOp
    {
        
        public List<double> Root_Combing(int a, int b, int c)
        {
            int Discriminant = (b * b) - (4 * a * c);
            List<double> roots = new List<double>();

            if (Discriminant > 0)
            {
                double x1 = (-b - Math.Sqrt(Discriminant)) / (2 * a);
                double x2 = (-b + Math.Sqrt(Discriminant)) / (2 * a);
                roots.Add(x1);
                roots.Add(x2);
            }
            else if (Discriminant == 0)
            {
                double x = -b / (2 * a);
                roots.Add(x);
            }
            else
            {
                Console.WriteLine("Анлак, корни комплексные");
            }
            return roots;
        }

        public double CalculatePercentage(double number, double percentage)
        {
            return (number * percentage) / 100;
        }
    }
}
