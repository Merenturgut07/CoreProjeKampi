using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Writer
    {
        [Key]
        public int WriterId { get; set; }


        public string WriterName { get; set; }
        public string WriterAbout { get; set; }
        public string WriterImage { get; set; }



        public string WriterMail { get; set; }


        [Required(ErrorMessage = "Şifre boş olamaz.")]
        [DataType(DataType.Password)]
        public string WriterPassword { get; set; }



        [Required(ErrorMessage = "Şifre tekrarı boş olamaz.")]
        [DataType(DataType.Password)]
        [Compare("WriterPassword", ErrorMessage = "Şifreler eşleşmiyor. Lütfen tekrar deneyin!")]
        public string WriterPasswordConfirm { get; set; }
        public bool WriterStatus { get; set; }


        public List<Blog> blogs { get; set; }
    }
}
