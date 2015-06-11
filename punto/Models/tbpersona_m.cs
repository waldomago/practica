using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace punto.Models
{
    [MetadataType(typeof(itbpersona))]
    public partial class tbpersona
    {
        void ss(){
            
        }
    }
    public interface itbpersona {
        [Display(Name="Tu nombre")]//nombre de los labels
        [DataType(DataType.Text,ErrorMessage="Tonto!!!!...")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [Editable(false)]//no se podra editar
        [MaxLength(20,ErrorMessage="no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Required]
        [Range(60000,15000000)]
        object nombre { get; set; }//nombre de la column
        [Key]
        [ScaffoldColumn(false)]
        object idpersona { get; set; }

    }
}