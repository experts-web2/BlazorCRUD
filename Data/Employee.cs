using BlazorCRUD.Enums;
using System.ComponentModel.DataAnnotations;

namespace BlazorCRUD.Data
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string City { get; set; } = null!;

        [Required]
        public string Department { get; set; } = null!;

        [Required]
        public GenderEnum Gender { get; set; }
    }
}
