class Rectangle
{
    private float length;
    private float width;

    //Question-2
    public Rectangle(float width, float length)
    {
        this.width = width;
        this.length = length;
    }

    //Question-3
    public float CalculateArea()
    {
        return length * width;
    }
}

//Question-4
class Program
{
    static void Main()
    {
        Rectangle myRectangle = new Rectangle(435f, 234f);
        float area = myRectangle.CalculateArea();
        Console.WriteLine("Rectangle's area : " + area);
    }
}