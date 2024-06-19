using EmillysLibrary;
namespace LibrariesExample;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Class1.About");

        //Console.WriteLine(Class1.About2"); cannont do this bc About2 is not static, meaning you can't just create an instance of the class. You need to define the property before you can reference the class within this class. 


    }


        var c1 = new Class1();
        Console.WriteLine(c1About2);
}