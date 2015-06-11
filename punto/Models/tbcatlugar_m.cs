using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace punto.Models
{
    public partial class tbcatlugar
    {
        void ss()
        {

        }
    }
    public interface itbcatlugar
    {
        [Display(Name = "catlugar")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Tonto!!!!...")]//tipo de dato

        [Editable(false)]//no se podra editar        
        object lugar { get; set; }//nombre de la column
        [Key]
        [ScaffoldColumn(false)]
        object idcatlugares { get; set; }

    }
}