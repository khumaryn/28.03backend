using Microsoft.AspNetCore.Mvc;

namespace WebApplication28._03homework.Controllers
{
    public class ProductController:Controller
    {
        public ContentResult GetInfo(string brand, string category, decimal price)
        {
            ContentResult result = new ContentResult();
            result.Content = "Product info - brand: " + brand + " - category: " + category + " - price:" + price;
            return result;
        }

    }
}
