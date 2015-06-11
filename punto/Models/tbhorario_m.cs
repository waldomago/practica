using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace punto.Models
{
    public partial class tbhorario
    {
        void ss()
        {

        }
    }
    public interface itbhorario
    {
        [Display(Name = "HORARIO")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "fracasado")]//tipo de dato

        [Editable(false)]//no se podra editar        
        object horario { get; set; }//nombre de la column
        [Key]
        [ScaffoldColumn(false)]
        object idhorario { get; set; }

    }
}