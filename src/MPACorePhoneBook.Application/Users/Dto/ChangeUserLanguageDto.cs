using System.ComponentModel.DataAnnotations;

namespace MPACorePhoneBook.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}