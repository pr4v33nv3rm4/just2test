using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Calculator
    {
        private double varA { get; set; }
        private double varB { get; set; }

        public Calculator(double a,double b)
        {
            varA = a;
            varB = b;
        }

        //method to add
        public double Add(){
            return (varA+varB);
        }
        //subtract 
        public double Subtract()
        {
            return (varA-varB);
        }
        //Multiply
        public double Multiply()
        {
            return (varA*varB);
        }
        //Devide
        public double Devide()
        {
            return (varA/varB);
        }
    }
}
