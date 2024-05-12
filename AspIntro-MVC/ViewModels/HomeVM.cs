using AspIntro_MVC.Models;

namespace AspIntro_MVC.ViewModels
{
    public class HomeVM
    {
        public string Text { get; set; }
        public List<string> Students { get; set; }

        public List<User> Users { get; set; }

        public List<Student> Studentss { get; set; }

        public List<Product> Products { get; set; }
    }
}
