using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace punto.Models
{
    public partial class tbpagolugares
    {
        void ss()
        {

        }
    }
    public interface itbpagolugares
    {
        [Display(Name = "PAGO LUGARES")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "fracasado")]//tipo de dato

        [Editable(false)]//no se podra editar        
        object pago { get; set; }//nombre de la column
        [Key]
        [ScaffoldColumn(false)]
        object idlugarpagos { get; set; }

    }
}