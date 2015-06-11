using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace punto.Models
{
    public class tbgaleria
    {
        void ss()
        {

        }
    }
    public interface itbgaleria
    {
        [Display(Name = "galeria")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "fracasado")]//tipo de dato

        [Editable(false)]//no se podra editar        
        object galeria { get; set; }//nombre de la column
        [Key]
        [ScaffoldColumn(false)]
        object idimagen { get; set; }

    }
}