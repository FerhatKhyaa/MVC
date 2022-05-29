using Microsoft.AspNetCore.Mvc.Filters;

namespace AdonetCoreMVC1.Filters
{
    public class LoglamaYap : Attribute, IActionFilter  // MVC Filters olarak bir class tanımlamak için attribute ve 'IActionFilter' miras alması gereklidir.
    {
        
        public void OnActionExecuting(ActionExecutingContext context)
        {
            int sayi = 10;
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            int sayi2 = 20;
        }

        
    }
}
