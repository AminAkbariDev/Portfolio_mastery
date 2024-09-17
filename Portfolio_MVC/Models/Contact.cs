
using System.ComponentModel.DataAnnotations;

namespace Portfolio_MVC.Models
{
	public class Contact
	{
        [Required(ErrorMessage ="این فیلد اجباری است!")]
        [MinLength(3, ErrorMessage = "حداقل طول نام 3 کاراکتر است.")]
        [MaxLength(100)]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage = "ایمیل وارد شده صحیح نیست!")]
        public string Email { get; set; }
        public string Message { get; set; }
        public string Service { get; set; }
    }
}
