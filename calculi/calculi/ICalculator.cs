using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculi
{
    interface ICalculator
    {
        int Add(int number1, int number2);
        int Multiply(int number1, int number2);
        int Divide(int number1, int number2);
    }
}
