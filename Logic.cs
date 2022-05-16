using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    // Operand + Operator + Operand = Operand
    // Operator.Calculate(Operand1, Operand2)
    public abstract class Base_operator
    {
        public abstract Operand Calculate(Operand first, Operand second);
    }
    public abstract class Additional_operator
    {
        public abstract Operand Calculate(Operand first);
    }
    public class Plus : Base_operator
    {
        public override Operand Calculate(Operand first, Operand second)
        {
            return new Operand(first.value + second.value);
        }
    }
    public class Division : Base_operator
    {
        public override Operand Calculate(Operand first, Operand second)
        {
            return new Operand(first.value / second.value);
        }
    }
    public class Minus : Base_operator
    {
        public override Operand Calculate(Operand first, Operand second)
        {
            return new Operand(first.value - second.value);
        }
    }
    public class Myltiply : Base_operator
    {
        public override Operand Calculate(Operand first, Operand second)
        {
            return new Operand(first.value * second.value);
        }
    }
    public class Sign : Additional_operator
    {
        public override Operand Calculate(Operand first)
        {
            return new Operand(first.value * -1);
        }
    }

    public class Operand
    {
        public double value;
        public Operand(double value)
        {
            this.value = value;
        }
    }





}
