using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace conciertos.Models
{
    [Table("t_conciertos")]
    public class Concierto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id {get; set;}
        public string artista {get; set;}
        public int fecha {get; set;}
        public decimal precio {get; set;}
       
    }
}