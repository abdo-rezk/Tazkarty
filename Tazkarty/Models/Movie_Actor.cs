using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Tazkarty.Models
{
    [Table("Movie_Actor")]
    public class Movie_Actor
    {
        [Key, Column(Order = 0)]
        [ForeignKey("Movie")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }


        [Key, Column(Order = 1)]
        [ForeignKey("Actor")]
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
        ApplicationDbContext context = new ApplicationDbContext();
    
    }
}