public struct Point2D
{
    public float X;
    public float Y;
}


//Question-2
public class DistanceCalculator
{
    public static double CalculateDistance(Point2D point1, Point2D point2)
    {
        float deltaX = point2.X - point1.X;
        float deltaY = point2.Y - point1.Y;

        double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

        return distance;
    }
}


//Question-3
class Program
{
    static void Main()
    {
        Point2D pointA = new Point2D { X = 4, Y = 2f };
        Point2D pointB = new Point2D { X = 6.0f, Y = 3.0f };

        double distance = DistanceCalculator.CalculateDistance(pointA, pointB);
        Console.WriteLine($"Distance between Point A and Point B: {distance}");
    }
}