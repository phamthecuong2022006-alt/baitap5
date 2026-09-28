using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductRazorBasic.Models;

namespace ProductRazorBasic.Pages;

public class IndexModel : PageModel
{
    public List<Product> Products { get; set; } = new();

    public void OnGet()
    {
        Products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop ASUS", Price = 18500000 },
            new Product { Id = 2, Name = "Chuột Logitech", Price = 650000 },
            new Product { Id = 3, Name = "Bàn phím cơ", Price = 1200000 },
            new Product { Id = 4, Name = "Tai nghe Gaming", Price = 950000 },
            new Product { Id = 5, Name = "Màn hình Samsung", Price = 5200000 }
        };
    }
}
