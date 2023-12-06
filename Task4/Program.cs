class Shape
{
    public virtual float CalculateArea()
    {
        return 0;
    }
}

//Question-2
class Circle : Shape
{
    private float radius;

    public Circle(float radius)
    {
        this.radius = radius;
    }

    public override float CalculateArea()
    {
        return (float)(Math.PI * Math.Pow(radius, 2));
    }
}

//Question-3
class Program
{
    static void Main()
    {
        Circle myCircle = new Circle(65.3f);
        float area = myCircle.CalculateArea();
        Console.WriteLine("Circle's area : " + area);
    }
}