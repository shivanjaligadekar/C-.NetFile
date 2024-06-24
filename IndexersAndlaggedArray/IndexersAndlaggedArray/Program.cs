using IndexersAndlaggedArray;

internal class Program
{
    private static void Main(string[] args)
    {
        //Products products = new Products();
        //products[0] = "GreenTea";
        //Console.WriteLine(products);

        ComplexMaths c=new ComplexMaths();
        c[0, false] = 10;
        c[1, true] = 500;
        c[2, false] = 400;
        Console.WriteLine(c[2,false]);
        Console.WriteLine(c[1, false]);
        
    }
}