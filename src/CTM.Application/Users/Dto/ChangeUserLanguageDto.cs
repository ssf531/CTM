using System.ComponentModel.DataAnnotations;

namespace CTM.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}