using DelegateLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    internal class ProductsOperations
    {
        static void Main(string[] args)
        {
            Products p = new Products();
            Console.WriteLine("\n 1.Add \n 2.Delete \n 3.Update \n 4.Show List \n 5.FindProduct \n 6.Exit");
            int choice=Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Products newProducts = new Products();
                    Console.WriteLine("Enter Product ID");
                    newProducts.ProductId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter ProductName");
                    newProducts.ProductName = Console.ReadLine();
                    Console.WriteLine("Enter Product Price");
                    newProducts.Price = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter category ID");
                    newProducts.CategoryId = Convert.ToInt32(Console.ReadLine());
                    p.AddProduct(newProducts);

                    Console.WriteLine("Showing the update details:");
                    List<Products> updateDet = p.ShowUpdateDetails();
                    updateDet.foreach (
                        item =>{
                            Console.WriteLine(item.ProductId + "" + item.ProductName + "" + item.Price)});


                    break;
                case 2:
                    Console.WriteLine("Enter ProductName");
                    p.ProductName = Console.ReadLine();
                    p.DeleteProduct(p.ProductName);

                    break;
                case 3:
                    Console.WriteLine("Enter Productid to update  Details");
                    int prodid=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the new product ID");
                    Products updateProducts = new Products();
                    updateProducts.ProductId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter new product name");
                    updateProducts.ProductName = Console.ReadLine();
                    Console.WriteLine("Enter new Price");
                    updateProducts.Price = Convert.ToInt32(Console.ReadLine());
                    

                    p.UpdateProduct(prodid, updateProducts);
                    Console.WriteLine("Showing the update details:");
                    List<Products> updateDet = p.ShowUpdateDetails();
                    foreach (
                        item
                        )
                        
                    }
                    break;
                case 4:
                    Console.WriteLine("Enter the Category of the product");
                    int catid=Convert.ToInt32(Console.ReadLine());  
                    List<Products> list=p.FindByCategoryid(catid);
                    list.ForEach(item => { 
                        Console.WriteLine(item.ProductId + " " + item.ProductName + " " + item.Price + " " + item.CategoryId);
                    }
                    );
                        double Avgprice=list.Average(item => item.Price);
                        Console.WriteLine("Average price of category of ID 1:-"+Avgprice);

                        int mxprice=list.Max(item => item.Price);
                        Console.WriteLine("Average price of category of ID 1:-" + mxprice);

                Console.WriteLine("Showing the update details:");
                List<Products> updateDet = p.ShowUpdateDetails();
                foreach (
                    item

                    )



                    //foreach(var item in list)
                    //{
                    //    Console.WriteLine(item.ProductId+" "+item.ProductName+" "+item.Price+" "+item.CategoryId);
                    //}

                    break;
                case 5:
                    break;
                case 6:
                    Environment.Exit(0);
                    break; 
            }
        }
    }
}
