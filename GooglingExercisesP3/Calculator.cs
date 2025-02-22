using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GooglingExercisesPt3
{
    public class Calculator
    {
        public double Number { get; private set; } = 0;
        public double Pi { get; } = Math.PI;
        public double Tau { get; } = Math.Tau;
        public double E { get; } = Math.E;

        public void Clear()
        {
            Number = default(double);
        }

        public double Add(double num)
        {
            return Number += num;
        }

        
    }
}
