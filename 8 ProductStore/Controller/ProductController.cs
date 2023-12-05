using _8_ProductMS;
using _8_ProductStore.Service;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_ProductStore.Controller
{
    public class ProductController
    {
        ProductService productService = new ProductService();

        public async Task init()
        {
            Console.WriteLine("1. Add a new Product");
            Console.WriteLine("2. Get all Products");
            Console.WriteLine("3. Update a Product");
            Console.WriteLine("4. Delete a Product");
            Console.WriteLine("Enter your input:");
            var input = Console.ReadLine();
            Console.WriteLine(input);

            // convert input to int
            var inputInt = int.TryParse(input, out int option);

            //checks for 1-4
            // switch
            await redirectUser(option);

        }

        private Task redirectUser(int option)
        {
            switch (option)
            {
                case 1:
                    return addProduct();
                case 2:
                    return getProducts();
                case 3:
                    return updateProduct();
                case 4:
                    return deleteProduct();
                default:
                    return init();
            }
        }

        private Task deleteProduct()
        {
            throw new NotImplementedException();
        }

        private Task updateProduct()
        {
            throw new NotImplementedException();
        }

        private async Task getProducts()
        {
           var products = await productService.GetProducts();
            foreach (var product in products)
            {
                Console.WriteLine(product.name);
            }
        }

        private async Task addProduct()
        {
            Console.WriteLine("Add a new  Product");

            Console.WriteLine(" Product Name: ");
            var Name = Console.ReadLine();

            Console.WriteLine(" Product Description: ");
            var Description = Console.ReadLine();


            Console.WriteLine(" Product Price: ");
            var priceStr = Console.ReadLine();
            var res = Double.TryParse(priceStr, out double Price);

            var newProduct = new ProductDTO() { name = Name, description = Description, price = Price };

            await AddProductRequest(newProduct);

        }

        private async Task AddProductRequest(ProductDTO newProduct)
        {
            var response = await productService.AddProduct(newProduct);
            Console.WriteLine(response);
            await init();
        }
    }
}
