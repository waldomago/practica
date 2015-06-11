using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace punto.Models
{
    public partial class tbtelefonos
    {
        void ss()
        {

        }
    }
    public interface itbtelefonos
    {
        [Display(Name = "TELEFONO")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "fracasado")]//tipo de dato

        [Editable(false)]//no se podra editar        
        object telefono { get; set; }//nombre de la column
        [Key]
        [ScaffoldColumn(false)]
        object idtelefonos { get; set; }

    }
}