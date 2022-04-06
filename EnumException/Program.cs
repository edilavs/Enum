using System;
using ClassLibrary;

namespace EnumException
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store1 = new Store();

            Product product = new Product();
            product.Name = "Journal";
            product.No = 67;
            product.Type = ProductType.Diary;
            product.Price = 3.20;

            Product product1 = new Product();
            product1.Name = "Meat1";
            product1.No = 7;
            product1.Type = ProductType.Meat;
            product1.Price = 14.50;

            Product product2 = new Product();
            product2.Name = "Bread";
            product2.No = 99;
            product2.Type =ProductType.Baker ;
            product2.Price = 0.80;

            Product product3 = new Product();
            product3.Name = "Coca-Cola";
            product3.No =58;
            product3.Type = ProductType.Drink;
            product3.Price = 4.50;

            Product product4 = new Product();
            product4.Name = "Water";
            product4.No = 59;
            product4.Type = ProductType.Drink;
            product4.Price = 1.60;

            bool check = true;
            while (check)
            {
                Console.WriteLine("-------MENU-------");
                Console.WriteLine("Secim edin:1-Product elave et\n2-Productin tipine gore filterle");
                int answer = Convert.ToInt32(Console.ReadLine());
                switch (answer)
                {
                    case 1:
                        Console.WriteLine("elave etmek istediyiniz mehsulun adini yazin:");
                        Product addedPr = (ProductType)Console.ReadLine();
                        store1.AddProduct(addedPr);
                        break;
                    case 2:
                        string prType;
                        Console.WriteLine("Axtaris etmek istediyiniz tipi yazin:");
                        prType = Console.ReadLine();
                        while (!Enum.IsDefined(typeof(ProductType), prType))
                        {
                            Console.WriteLine("SEcim yanlisdir,Dogru secim edin!");
                            prType = Console.ReadLine();
                        }
                        break;

                    //foreach (var item in store1.FilterProductsByType(ProductType.Meat))
                    //{
                    //    Console.WriteLine($"{item}");
                    //}
                    //break;
                    default:
                        check = false;
                        Console.WriteLine("dogru secim edin:");
                        break;

                }
            }
            //store1.AddProduct(product);
            //store1.AddProduct(product1);
            //store1.AddProduct(product2);
            //store1.AddProduct(product3);
            //store1.AddProduct(product4);
            

            //store1.RemoveProductByNo(58);

            //Console.WriteLine( "================\n");

            //foreach (var item in store1.FilterProductsByType(ProductType.Meat))
            //{
            //    Console.WriteLine($"{item}");
            //}


            //Console.WriteLine(" \n");
            //foreach (var item in store1.FilterProductByName("corek"))
            //{
            //    Console.WriteLine($"{item}");
            //}

        }
    }
}
