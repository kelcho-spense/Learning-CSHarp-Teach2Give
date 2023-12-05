using Async__BookMS.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async__BookMS.services
{
    public class bookService
    {
        //1. Create a method that returns a list of books
        //2. Create a method that returns a book by id
        //3. Create a method that returns a book by name    
     
        private readonly HttpClient _httpClient;
        public readonly string _URL = "http://localhost:8000/api/books";

        public bookService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<BookModel>> GetBooks()
        {
            var response = await _httpClient.GetAsync(_URL);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();  
                var books = JsonConvert.DeserializeObject<List<BookModel>>(content);
                return books;
            }
            return null;
        }   

    }
}
