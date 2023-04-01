using Microsoft.AspNetCore.Mvc;

namespace WebApplicationclass28._03.Controllers
{
    public class ProductController : Controller
    {
        // public ContentResult GetInfo()
        // { 
        //ContentResult result=new ContentResult();
        //      result.Content = "product info";
        //      return result;
        // }

        //public JsonResult getInfo()
        //{
        //    JsonResult result = new JsonResult(new { Name = "samsung" ,Price=45}); 
        //    return result;
        //}
        public ViewResult Detail()
        { 
        ViewResult result = new ViewResult();
            result.ViewName = "detail";
            return result;
        }
        public ContentResult GetInfo( string brand, string category)
        { 
            ContentResult result = new ContentResult();
            result.Content = "product info-brand:" +brand+ "category"+category;
            return result;
        }
    }
  
}
