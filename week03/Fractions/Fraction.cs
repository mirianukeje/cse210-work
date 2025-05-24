using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1; // Default to 1 to avoid division by zero
        _bottom = 1; // Default to 1 to avoid division by zero
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1; // Default to 1 to represent whole numbers as fractions
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetFractionDecimal()
    {
        return (double)_top / (double)_bottom;
    }
}