public class ExampleClass
{
    public int MyProperty { get; set; }

    // Constructor to initialize the property
    public ExampleClass()
    {
        MyProperty = 0; // Initialize MyProperty
    }

    public void MyMethod()
    {
        Console.WriteLine(MyProperty); // Now this is safe
    }
}