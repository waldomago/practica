using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace punto.Models
{
    public partial class tbvotousuario
    {
        void ss()
        {

        }
    }
    public interface itbvotousuario
    {
        [Display(Name = "VOTO USUARIO")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "fracasado")]//tipo de dato

        [Editable(false)]//no se podra editar        
        object usuario { get; set; }//nombre de la column
        [Key]
        [ScaffoldColumn(false)]
        object idvotousuario { get; set; }

    }
}