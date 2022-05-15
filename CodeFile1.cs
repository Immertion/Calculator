using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    // Operand + Operator + Operand = Operand
    // Operator.Calculate(Operand1, Operand2)
    public abstract class Operator
    {
        public abstract Operand Calculate(Operand first, Operand second);
    }
    public class Plus : Operator
    {
        public override Operand Calculate(Operand first, Operand second)
        {
            return new Operand(first.value + second.value);
        }
    }
    public class Division : Operator
    {
        public override Operand Calculate(Operand first, Operand second)
        {
            return new Operand(first.value / second.value);
        }
    }

    public class Operand
    {
        public int value;
        public Operand(int value)
        {
            this.value = value;
        }
    }



    class Program
    {

    }

}
