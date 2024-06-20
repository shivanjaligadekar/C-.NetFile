using DelegateLibrary;

public delegate int DivRem(int n, int d);


internal class Program
{
    //private static void Main(string[] args)
    //{
    //   Products p= new Products();  
    //   ProductIdGeneration delobj=new ProductIdGeneration(p.GenerateId);//
    //   int Productid=delobj.Invoke();//it is a method
    //   Console.WriteLine(Productid);

    //    Console.WriteLine("-----------");
    //    Productid = delobj.Invoke();//it is a method
    //    Console.WriteLine(Productid);

    //    WorkingWithProductData[] delobj1 =
    //        new WorkingWithProductData[2] {p.AddProduct,p.UpdateProduct };
    //      WorkingWithProductData del=(WorkingWithProductData)MulticastDelegate.Combine(delobj1);
    //    del();
    //    Console.WriteLine("===============================================");

    //    ProductDeleteFind del1 = new ProductDeleteFind(p.DeleteProduct);
    //    ProductDeleteFind del2 = new ProductDeleteFind(p.FindProductByName);

    //    ProductDeleteFind combineDel = (ProductDeleteFind)MulticastDelegate.Combine(del1, del2);
    //    combineDel.Invoke("tea");


    //    Console.WriteLine("==================");
    //    Console.WriteLine("=======Anonymous Delegates===========");
    //    ProductDeleteFind anonDel = delegate (string n) {
    //        Console.WriteLine("Anonymois method called...");
    //        Console.WriteLine(n.ToUpper());
    //        //Console.WriteLine(n.TrimEnd(' '));
    //       // Console.WriteLine()
    //    };
    //    anonDel("Hello world");
    //    Console.WriteLine("=================================");
    //    DivRem dm = delegate (int i, int j)
    //    {
    //        long rem;
    //        long l=Math.DivRem(i, j,out  rem);
    //        return Convert.ToInt32(rem);
    //    };
    //    int remindar = dm(11, 2);
    //    Console.WriteLine(remindar);




        //MulticastDelegate.Combine(del1,del2);




    }
