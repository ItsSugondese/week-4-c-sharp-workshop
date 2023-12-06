class Student
{
    private string name;
    private int age;
    private string major;

    //Question-2
    public Student(string name, int age, string major)
    {
        this.name = name;
        this.age = age;
        this.major = major;
    }

    //Question-3
    public void Introduce()
    {
        System.Console.WriteLine($"Name is {name} and age is {age} years old, and  major is {major}.");
    }
}

//Question-4
class Program
{
    static void Main()
    {
        Student kcl = new("Rohan Niraula", 20, "Bsc. (Hons) Computing");
        kcl.Introduce();
    }
}