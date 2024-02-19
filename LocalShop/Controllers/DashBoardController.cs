using LocalShop.Data;
using LocalShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace LocalShop.Controllers
{
    public class DashBoardController : Controller
    {
        private static List<BlogType> _BlogTypes = new List<BlogType>();
        private static List<Company> _companys = new List<Company>();
        private readonly ApplicationDbContext _db;
        public DashBoardController(ApplicationDbContext db)
        {
            _db = db;
            _companys.Add(new Company { Id = 1, Name = "nike" });
            _companys.Add(new Company { Id = 2, Name = "adidas" });

            _BlogTypes.Add(new BlogType { Id = 1, Name = "comedy" });
            _BlogTypes.Add(new BlogType { Id = 2, Name = "romantic" });
            _BlogTypes.Add(new BlogType { Id = 3, Name = "horror" });
            _BlogTypes.Add(new BlogType { Id = 4, Name = "scientific" });

        }
        public IActionResult Index()
        {
            return View();
        }

        #region AddProduct
        public IActionResult AddProduct()
        {
            return View();

        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            _db.products.Add(product);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
        #endregion

        #region ViewProducts
        public IActionResult ViewProducts()
        {

            var Product = _db.products.Include(p => p.company).ToList();
            return View(Product);
        }

        #endregion

        #region DeleteProduct
        public IActionResult Delete(int id)
        {
            Product? product = _db.products.FirstOrDefault(x => x.Id == id);
            _db.products.Remove(product);
            _db.SaveChanges();
            return RedirectToAction("ViewProducts");
        }

        #endregion

        #region EditProduct
        public IActionResult EditProduct(int id)
        {
            Product product = _db.products.FirstOrDefault(y => y.Id == id);
            return View(product);
        }
        [HttpPost]

        public IActionResult EditProduct(Product product)
        {
            Product newProduct = _db.products.FirstOrDefault(x => x.Id == product.Id);
            newProduct.Name = product.Name;
            newProduct.Description = product.Description;
            newProduct.Price = product.Price;
            newProduct.EnableSize = product.EnableSize;
            newProduct.CompanyId = product.CompanyId;
            newProduct.Quantity = product.Quantity;
            _db.products.Update(newProduct);
            _db.SaveChanges();
            return RedirectToAction("index");
        }


        #endregion

        #region AddBlog
        public IActionResult AddBlog()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddBlog(Blog blog)
        {

            _db.blogs.Add(blog);
            _db.SaveChanges();
            return RedirectToAction("index");

        }
        #endregion

        #region ViewBlogs

        public IActionResult ViewBlogs()
        {

            var blog = _db.blogs.Include(p => p.BlogType).ToList();
            return View(blog);
        }


        #endregion

        #region DeleteBlog
        public IActionResult DeleteBlog(int id)
        {
            Blog? blog = _db.blogs.FirstOrDefault(x => x.Id == id);
            _db.blogs.Remove(blog);
            _db.SaveChanges();
            return RedirectToAction("GetAllDataBlogs");
        }

        #endregion

        #region EditBlog
        public IActionResult EditBlog(int id)
        {
            Blog blog = _db.blogs.FirstOrDefault(b => b.Id == id);
            return View(blog);
        }
        [HttpPost]
        public IActionResult EditBlog(Blog blog)
        {
            Blog newBlog = _db.blogs.FirstOrDefault(x => x.Id == blog.Id);
            newBlog.Name = blog.Name;
            newBlog.Description = blog.Description;
            newBlog.AuthorName = blog.AuthorName;
            newBlog.BlogTypeId = blog.BlogTypeId;
            _db.blogs.Update(newBlog);
            _db.SaveChanges();

            return RedirectToAction("index");

        }
        #endregion


    }
}
