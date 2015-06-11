using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace punto.Models
{
    public  partial class tbusuario
    {
        void ss()
        {

        }
    }
    public interface itbusuario
    {
        [Display(Name = "USUARIO")]//nombre de los labels
        [DataType(DataType.Password, ErrorMessage = "fracasado")]//tipo de dato

        [Editable(false)]//no se podra editar        
        object usuario { get; set; }//nombre de la column
        [Key]
        [ScaffoldColumn(false)]
        object idusuario { get; set; }

    }
}