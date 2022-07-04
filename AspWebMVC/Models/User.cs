using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
namespace AspWebMVC.Models
{
    public class User//:IdentityUser<string>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
