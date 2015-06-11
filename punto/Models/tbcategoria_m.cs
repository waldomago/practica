using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace punto.Models
{
   [MetadataType(typeof())]
    public partial class tbcategoria
    {
        void ss()
        {

        }
    }
    public interface itbpersona
    {
        [Display(Name = "categoria")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Tonto!!!!...")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [Editable(false)]//no se podra editar        
        object categoria { get; set; }//nombre de la column
        [Key]
        [ScaffoldColumn(false)]
        object idcategorias { get; set; }

    }
}