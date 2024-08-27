
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AuctionCar.Models.Users
{
    public class Admin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string? PhoneNumber { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string SaltPassword { get; set; }

        public DateTime RegisteredDate { get; set; }

        public DateTime ResetPasswordDate { get; set; }

        public bool IsSuperAdmin { get; set; } = false;

        public Admin()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;
            Username = string.Empty;
            Password = string.Empty;
            SaltPassword = string.Empty;
            RegisteredDate = DateTime.UtcNow;
            ResetPasswordDate = DateTime.UtcNow.AddMonths(6);
        }
    }
}
//test git