using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSU.EPAM._1501.Day1.Bychkovksy.Task1
{
    public class Method
    {
        /// <summary>
        /// calculating the roots of Newton's method
        /// </summary>
        /// <param name="number"></param>
        /// <param name="pow"></param>
        /// <returns>double</returns>
        public static double Newton(double number, double pow, double eps)
        {
            if ((pow < 0) || ((pow % 2 == 0) && (number < 0)))
                return double.NaN;
            if ((eps > 1) || (eps < 0))
                //throw new IncorrectEpsilonException("Epsilon outside the allowable values");
                throw new Exception("Epsilon outside the allowable values");
            double x = ((pow - 1) * number + number / Math.Pow(number, pow - 1)) / pow;
            double xn;
            double temp;
            do
            {
                xn = ((pow - 1) * x + number / Math.Pow(x, pow - 1)) / pow;
                temp = x;
                x = xn;
            } while (Math.Abs((temp - xn)) > eps);

            return temp;
        }
    }
}
