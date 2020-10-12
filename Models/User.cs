using Microsoft.AspNetCore.Identity;

namespace CodeSuccessFrontEnd.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}