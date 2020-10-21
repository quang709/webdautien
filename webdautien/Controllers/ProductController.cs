using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webdautien.Models;

namespace webdautien.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public ProductController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            ViewBag.Message = "mi tom";
            /*  var Product = new List<Product>
              {
              new Product{Id =1, Name = "mi tom haro hảo", Description="abcabcanc",Price= 1000, Stock=1000,ImageUrl="https://cdn.tgdd.vn/Products/Images/2565/77622/bhx/mi-hao-hao-tom-chua-cay-goi-75g-201912051022208226.JPG"},
              new Product{Id =2, Name = "mi tom haro hảo", Description="abcabcanc",Price= 1000, Stock=1000,ImageUrl="https://cdn.tgdd.vn/Products/Images/2565/77622/bhx/mi-hao-hao-tom-chua-cay-goi-75g-201912051022208226.JPG"},
                new Product{Id =3, Name = "mi tom haro hảo", Description="abcabcanc",Price= 1000, Stock=1000,ImageUrl="https://cdn.tgdd.vn/Products/Images/2565/77622/bhx/mi-hao-hao-tom-chua-cay-goi-75g-201912051022208226.JPG"},
                 new Product{Id =4, Name = "mi tom haro hảo", Description="abcabcanc",Price= 1000, Stock=1000,ImageUrl="https://cdn.tgdd.vn/Products/Images/2565/77622/bhx/mi-hao-hao-tom-chua-cay-goi-75g-201912051022208226.JPG"},
                  new Product{Id =5, Name = "mi tom haro hảo", Description="abcabcanc",Price= 1000, Stock=1000,ImageUrl="https://cdn.tgdd.vn/Products/Images/2565/77622/bhx/mi-hao-hao-tom-chua-cay-goi-75g-201912051022208226.JPG"}
              };*/
            var products = _appDbContext.Products.Include(p => p.Category).ToList();
            return View(products);
        }
/*        public IActionResult Index1()
        {
            ViewBag.Message = "thế giới động thực vật";

            var products1 = _appDbContext.Products1.Include(p => p.Category1).ToList();
            return View(products1);
        }*/
    }
}