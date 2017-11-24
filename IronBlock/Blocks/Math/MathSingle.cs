using System;
using System.Collections.Generic;
using System.Linq;

namespace IronBlock.Blocks.Math
{
    public class MathSingle : IBlock
    {
        public override object Evaluate(IDictionary<string, object> variables)
        {
            var op = this.Fields.Evaluate("OP");
            var number = (double) this.Values.Evaluate("NUM", variables);

            switch (op)
            {
                case "ROOT": return System.Math.Sqrt(number);
                case "ABS": return System.Math.Abs(number);
                case "NEG": return -1 * number;
                case "LN": return System.Math.Log(number);
                case "LOG10": return System.Math.Log10(number);
                case "EXP": return System.Math.Exp(number);
                case "POW10": return System.Math.Pow(number, 10);
                
                case "SIN": return System.Math.Sin(number / 180 * System.Math.PI);
                case "COS": return System.Math.Cos(number / 180 * System.Math.PI);
                case "TAN": return System.Math.Tan(number / 180 * System.Math.PI);
                case "ASIN": return System.Math.Asin(number / 180 * System.Math.PI);
                case "ACOS": return System.Math.Acos(number / 180 * System.Math.PI);
                case "ATAN": return System.Math.Atan(number / 180 * System.Math.PI);

                case "ROUND": return System.Math.Round(number);
                case "ROUNDUP": return System.Math.Ceiling(number);
                case "ROUNDDOWN": return System.Math.Floor(number);
                
                default: throw new ApplicationException($"Unknown OP {op}");
            }
        }
    }

}