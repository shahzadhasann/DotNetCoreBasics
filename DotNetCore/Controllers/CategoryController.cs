using DotNetCore.Data;
using DotNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DotNetCore.Controllers
{
    public class CategoryController : Controller
    {
        MyDbContext context = new MyDbContext();
        public IActionResult Index()
        {
            // There are 2 ways tomtransfer data from Controller to View 
            // 1. ViewBag, ViewData, TempData, Session
            // 2. Model

            // Get CategoryList from the Database
            var CategoryList = context.Category.ToList();

            // Ways to assign data in Category
            // 1. Declare obj then assign.
            //Category obj1 = new Category() { CategoryId=1, Name= "Fruits" };
            //Category obj2 = new Category() { CategoryId=2, Name= "Vegetables" };
            //Category obj3 = new Category() { CategoryId=3, Name= "Beverages" };
            //CategoryList.Add(obj1);
            //CategoryList.Add(obj2);
            //CategoryList.Add(obj3);

            // 2. Declare and assign at once.
            CategoryList.Add(new Category() {CategoryId=1, Name="Fruits"});
            CategoryList.Add(new Category() {CategoryId=2, Name="Vegetables"});
            CategoryList.Add(new Category() {CategoryId=3, Name="Beverages"});
            ViewBag.CategoryList = CategoryList;    
            return View();
        }
    }
}
