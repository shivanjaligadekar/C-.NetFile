using DelegateLibrary;

namespace DelegateLibrary
{
    public  delegate int ProductIdGeneration();  //declare delegate inside the namespace & outside the class 

    public delegate void WorkingWithProductData();

    public delegate void ProductDeleteFind(string name);

    public class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int CategoryId { get; set; }

        static List<Products> productsList = new List<Products>()
        {
            new Products{ ProductId = 1,ProductName="Tea",Price=20,CategoryId=1},
            new Products{ ProductId = 2,ProductName="sugar",Price=50,CategoryId=1},
            new Products{ ProductId = 3,ProductName="cup",Price=100, CategoryId = 1},
            new Products{ ProductId = 4,ProductName="plate",Price=150, CategoryId = 1},
            new Products{ ProductId = 5,ProductName="bowle",Price=50, CategoryId = 1},
            new Products{ ProductId = 6,ProductName="bucket",Price=250, CategoryId = 2}
        };

        static int cnt = 0;
        public int GenerateId()
        {
            return ++cnt;
        }

        public void AddProduct(Products p)
        {
            //Console.WriteLine("Product Add Called");
            productsList.Add(p);
        }
        public void UpdateProduct(int id, Products p)
        {
            //Console.WriteLine("Product Updated");
            Products foundProduct = productsList.Find(p => p.ProductId == id);
            if (foundProduct != null)
            {
                foundProduct.ProductId = p.ProductId;
                foundProduct.ProductName = p.ProductName;
                foundProduct.Price = p.Price;
                foundProduct.CategoryId = p.CategoryId;
            }
            else
            {
                Console.WriteLine("Product id not found...");
            }
        }
        public List<Products> FindByCategoryid(int categoryId)
        {
            List<Products> allproductsInCategory = productsList.FindAll(p => p.CategoryId == categoryId);
            return allproductsInCategory;
        }
        public void DeleteProduct(string name)
        {
            Products foundProduct = productsList.Find(p => p.ProductName == name);
            Console.WriteLine("Found the following details.Confirm with");
            Console.WriteLine(foundProduct.ProductName);
            Console.WriteLine(foundProduct.ProductId);
            Console.WriteLine(foundProduct.Price);
            Console.WriteLine(foundProduct.CategoryId);
            Console.WriteLine("press y if u want to delete");
            char userAns = Convert.ToChar(Console.ReadLine());
            if (userAns == 'y')
            {
                productsList.Remove(foundProduct);
                Console.WriteLine("Product successfully deleted");
            }
            productsList.Remove(foundProduct);

        }
        public Products FindProductByName(string name)
        {
            Products foundProduct = productsList.Find(p => p.ProductName == name);
                return foundProduct;
            }

        public List<Products> ShowUpdateDetails()
        {
            return productsList;
        }

        }
    }

