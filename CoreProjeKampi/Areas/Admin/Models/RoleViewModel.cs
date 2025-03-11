using System.ComponentModel.DataAnnotations;

namespace CoreProjeKampi.Areas.Admin.Models
{
    public class RoleViewModel
    {
        [Required(ErrorMessage = "Lütfen Rol Adı Giriniz")]
        public string Name { get; set; }
    }
}
