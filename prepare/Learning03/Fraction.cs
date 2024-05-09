using System.Runtime.CompilerServices;

public class Fraction {

    private int _top;
    private int _bottom;



    public Fraction() {
        _top = 1;
        _bottom = 1;
        
    }

    public Fraction(int numerator) {
        _top = numerator;
        _bottom = 1;
        
    }

    public Fraction(int numerator, int denominator) {
        _top = numerator;
        _bottom = denominator;
       
    }

        
    

    // Getters and Setters

    public int GetNumer() {
        return _top;
    }
    public int GetDenom() {
        return _bottom;
    }
    

    public void SetNumer(int numerator) {
        _top = numerator;

    }
    public void SetDenom(int denominator) {
        _bottom = denominator;
    }

    // Methods

    public string GetFractionString() {
        
        int numerator = GetNumer();
        int denominator = GetDenom();

        
        return $"{numerator}/{denominator}";
    }

    public double GetDecimal() {
        double decimalValue = (double)_top / (double)_bottom;
        return decimalValue;
    }

}