using AspIntro_MVC.Models;
using AspIntro_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AspIntro_MVC.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            string text = "Welcome";


            List<string> students = new List<string> { "Emirastan", "Ilqar", "Nurlan" };



            HomeVM model = new()
            {
                Text = text,
                Students = students,
                Users =  GetAllUsers(),
                Studentss = GetAllData(),
                Products = GetProduct()

            };

            return View(model);
        }

        private List<User> GetAllUsers()
        {
            return new List<User>
            {
                new User
                {
                    Id=1,
                    Age=100
                },
                new User
                {
                    Id=2,
                    Age=19
                },
                new User
                {
                    Id=3,
                    Age=20
                }
            };
        }



        private List<Student> GetAllData()
        {
            return new List<Student>
            {
                new Student
                {
                    Name = "Reshad",
                    Surname = "Aghayev",
                    Email = "rshad@gmail.com",
                    Age = 21,
                    PhoneNumber = 879898978
                },


                new Student
                {
                    Name = "Nurlan",
                    Surname = "Umudov",
                    Email = "nurlan@gmail.com",
                    Age = 22,
                    PhoneNumber = 879898978
                },

                new Student
                {
                    Name = "Ayxan",
                    Surname = "Aghayev",
                    Email = "ayxan@gmail.com",
                    Age = 24,
                    PhoneNumber = 879898978
                },

                new Student
                {
                    Name = "Kamran",
                    Surname = "Muradov",
                    Email = "kamran@gmail.com",
                    Age = 24,
                    PhoneNumber = 879898978
                }
            };
        }


        private List<Product> GetProduct()
        {
            return new List<Product>
            {
                new Product
                {
                    Name= "Samsung",
                    Price = 2000,
                    Color = "black"
                },

                 new Product
                {
                    Name= "Apple",
                    Price = 3000,
                    Color = "white"
                },

                  new Product
                {
                    Name= "Honor",
                    Price = 1000,
                    Color = "yeloow"
                },

                   new Product
                {
                    Name= "Xiaomi",
                    Price = 1100,
                    Color = "Orange"
                }
            };
        }


    }
}

















