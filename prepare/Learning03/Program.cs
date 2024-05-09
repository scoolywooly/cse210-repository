using System;

class Program
{
    static void Main(string[] args)
    {
        //   1/1
        Fraction firstNumber = new Fraction();
        string fractionString = firstNumber.GetFractionString();
        double decimalValue = firstNumber.GetDecimal();
        Console.WriteLine(fractionString);
        Console.WriteLine(decimalValue);


        //  1/5
        Fraction secondNumber = new Fraction(5);
        fractionString = secondNumber.GetFractionString();
        decimalValue = secondNumber.GetDecimal();
        Console.WriteLine(fractionString);
        Console.WriteLine(decimalValue);


        //  3/4
        Fraction thirdNumber = new Fraction(3,4);
        fractionString = thirdNumber.GetFractionString();
        decimalValue = thirdNumber.GetDecimal();
        Console.WriteLine(fractionString);
        Console.WriteLine(decimalValue);


        //  1/3
        Fraction fourthNumber = new Fraction(1,3);
        fractionString = fourthNumber.GetFractionString();
        decimalValue = fourthNumber.GetDecimal();
        Console.WriteLine(fractionString);
        Console.WriteLine(decimalValue);


        

    }
}