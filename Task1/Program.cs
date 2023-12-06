// See https://aka.ms/new-console-template for more information
class Car
{
    // Question-1
    private string brand;
    private int year;
    private float price;

    //Question-2
    public Car(string brand, int year, float price)
    {
        this.brand = brand;
        this.year = year;
        this.price = price;
    }
    public void DisplayCarDetails()
    {
        Console.WriteLine($"Brand: {brand}");
        Console.WriteLine($"Year: {year}");
        Console.WriteLine($"Price: ${price}");
    }
}

class Program
{
    static void Main()
    {
        //Question-3
        Car myCar = new Car("Tesla", 1969, 69420.69f);
        myCar.DisplayCarDetails();
    }
}