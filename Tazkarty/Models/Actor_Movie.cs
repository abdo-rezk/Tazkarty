using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Tazkarty.Models
{
    [Table("Actor_Movie")]
    public class Actor_Movie
    {
        [Key, Column(Order = 0)]
        [ForeignKey("Movie")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }


        [Key, Column(Order = 1)]
        [ForeignKey("Actor")]
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
   
    }
}