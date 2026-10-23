using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.ViewComponents
{
    public class Cart : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            // Giả lập logic đếm số lượng giỏ hàng
            int itemCount = 5;
            return View("Default", itemCount);
        }
    }
}