using System.ComponentModel.DataAnnotations;

namespace BlazorCRUD.Enums
{
    public enum GenderEnum
    {
        [Display(Name = "Male")]
        Male = 1,
        [Display(Name = "Female")]
        Female = 2
    }
}
