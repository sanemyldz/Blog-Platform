using Microsoft.EntityFrameworkCore;
namespace AspWebMVC.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string surname { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
    }
}
