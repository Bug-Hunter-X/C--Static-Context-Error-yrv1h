public class ExampleClass
{
    public static int MyStaticProperty { get; set; } //Static property
    public int MyProperty { get; set; } // instance property 

    public void MyMethod()
    {
        int x = MyProperty; // Access the instance property
    }

    public static void MyStaticMethod()
    {
        // Accessing the static property from the static method
        int y = MyStaticProperty; 

        // Accessing the instance property would result in error. In order to access instance property in static method, we need to create instance first. 
        ExampleClass example = new ExampleClass();
        int z = example.MyProperty;
    }
}