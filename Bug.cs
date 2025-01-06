public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a non-static member from a static context
        int x = MyProperty; // Error: An object reference is required for the non-static field, method, or property 'ExampleClass.MyProperty'
    }
}