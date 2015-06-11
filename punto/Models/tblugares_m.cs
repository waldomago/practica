using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace punto.Models
{
    public partial class tblugares
    {
        void ss()
        {

        }
    }
    public interface itblugares
    {
        [Display(Name = "LUGARES")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "fracasado")]//tipo de dato

        [Editable(false)]//no se podra editar        
        object LUGARES { get; set; }//nombre de la column
        [Key]
        [ScaffoldColumn(false)]
        object idlugar { get; set; }

    }
}