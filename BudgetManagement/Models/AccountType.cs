using System.ComponentModel.DataAnnotations;
using BudgetManagement.Validations;

namespace BudgetManagement.Models
{
    public class AccountType //: IValidatableObject
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage = "{0} must be between {2} and {1} characters long")]
        [Display(Name = "Account Type Name")]
        [FirstCapitalLetter]
        public string Name { get; set; }
        public int UserId { get; set; }
        public int Orden { get; set; }

        // public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        // {
        //     if (Name != null && Name.Length > 0)
        //     {
        //         var firstLetter = Name[0].ToString();

        //         if (firstLetter != firstLetter.ToUpper())
        //         {
        //             yield return new ValidationResult($"The first letter of {validationContext.DisplayName} must be uppercase.", new[] { nameof(Name) });
        //         }
        //     }
        // }
    }
}