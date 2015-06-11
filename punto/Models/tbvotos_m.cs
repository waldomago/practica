using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace punto.Models
{
    public partial class tbvotos
    {
        void ss()
        {

        }
    }
    public interface itbvotos
    {
        [Display(Name = "VOTOS")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "fracasado")]//tipo de dato

        [Editable(false)]//no se podra editar        
        object votos { get; set; }//nombre de la column
        [Key]
        [ScaffoldColumn(false)]
        object id { get; set; }

    }
}