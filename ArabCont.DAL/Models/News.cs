using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabCont.DAL.Models
{
    public class News
    {
        public int Id { get; set; }
        [MaxLength(200)]
        public string? Title { get; set; }
        public DateTime NewsDate { get; set; }
        [MaxLength(100)]
        public string? ImageName { get; set; }
    }
}
