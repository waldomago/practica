using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace punto.Models
{
      // [MetadataType(typeof(itblugar))]

    public partial class tblugar
    {
        void ss()
        {

        }
    }
    public interface itblugar
    {
        [Display(Name = "lugar")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Tonto!!!!...")]//tipo de dato
        
        [Editable(false)]//no se podra editar        
        object lugar { get; set; }//nombre de la column
        [Key]
        [ScaffoldColumn(false)]
        object idvoto { get; set; }

    }
}