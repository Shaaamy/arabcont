using System.ComponentModel.DataAnnotations;

namespace ArabCont.PL.ViewModels
{
    public class NewsViewModel
    {
        [MaxLength(200 ,ErrorMessage ="The Max Length is 200 Chars")]
        public string? Title { get; set; }
        public DateTime NewsDate { get; set; }
        [MaxLength(100,ErrorMessage = "The Max Length is 100 Chars")]
        public IFormFile? Image { get; set; }
        public string? ImageName { get; set; }
    }
}
