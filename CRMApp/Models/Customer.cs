using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;

namespace CRMApp.Models
{
    public class Customer
    {
        public ObjectId Id { get; set; } // Assuming you're using ObjectId for MongoDB
        [Required] // Use DataAnnotations for validation
        public string Name { get; set; } = string.Empty;
        [EmailAddress] // Validate email format
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty; // Ensure this line exists
    }
}
