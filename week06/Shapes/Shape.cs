public class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    // Virtual so it can be overridden by subclasses
    public virtual double GetArea()
    {
        // No default area, so just return 0 or throw if you want
        return 0;
    }
}
