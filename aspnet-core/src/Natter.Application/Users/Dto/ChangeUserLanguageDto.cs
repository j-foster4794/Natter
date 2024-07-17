using System.ComponentModel.DataAnnotations;

namespace Natter.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}