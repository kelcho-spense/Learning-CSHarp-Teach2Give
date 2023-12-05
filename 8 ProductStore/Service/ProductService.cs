using _8_ProductMS;
using _8_ProductStore;
using _8_ProductStore.Service.Iservices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _8_ProductStore.Service
{
    public class ProductService 
    {
        public readonly string _URL = "http://localhost:8000/api/products";
        private readonly HttpClient _httpClient;

        public ProductService()
        {
            _httpClient = new HttpClient();
        }

        //1. Create a method that returns a list of products

        public async Task<List<_8_ProductMS.ProductModels>> GetProducts()
        {
            var response = await _httpClient.GetAsync(_URL);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var products = JsonConvert.DeserializeObject<ProductModels>(content);
                return products;
            }
            return null;
        }

        //2.get a product by id

        public async Task<ProductModels> GetProductById(int id)
        {
            var response = await _httpClient.GetAsync(_URL + "/" + id);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var product = JsonConvert.DeserializeObject<ProductModels>(content);
                return product;
            }
            return null;
        }

        //3. Create a product

        public async Task<string> AddProduct(ProductDTO product)
        {
            var json = JsonConvert.SerializeObject(product);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(_URL, data);
            if (response.IsSuccessStatusCode)
            {
                return "Product added successively";
            }
            return null;
        }

        //4. Update a product

        public async Task<string> UpdateProduct(int id, ProductDTO product)
        {
            var json = JsonConvert.SerializeObject(product);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync(_URL + "/" + id, data);
            if (response.IsSuccessStatusCode)
            {
                return "Product updated successively";
            }
            return null;
        }
        //5. Delete a product

        public async Task<bool> DeleteProduct(int id)
        {
            var response = await _httpClient.DeleteAsync(_URL + "/" + id);
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        Task<ProductModels> IProductService.GetProducts()
        {
            throw new NotImplementedException();
        }
    }
}
