using System.ComponentModel.DataAnnotations;

namespace Henrique.Unisolution.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}