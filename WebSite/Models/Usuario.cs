using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

       
       [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail não é valido")]
        public string Email { get; set; }

  
        [Required(ErrorMessage = "Senha é requirida.")]
        [StringLength(8, ErrorMessage = "Caracteres quantidade entre 5 a 8", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Nome completo é requirido.")]
        public string NomeCompleto { get; set; }

        [Required(ErrorMessage = "Data de nascimento em formato dd/mm/aaaa é requirida.")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string DataNascimento { get; set; }

        
        public bool UsuarioContribuidor { get; set; }
    }
}
