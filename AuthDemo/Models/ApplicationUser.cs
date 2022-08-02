using Microsoft.AspNetCore.Identity;

namespace AuthDemo.Models
{
    public class ApplicationUser: IdentityUser
    {
        public ICollection<Vehicle> Vehicles { get; set; } = new HashSet<Vehicle>();    
        public ApplicationUser(): base()
        {

        }
    }
}
