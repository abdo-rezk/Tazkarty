using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Tazkarty.Models
{
    [Table("Actor")]
    public class Actor
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string ProfilePictureURL { get; set; }
       // [Required,MaxLength(100)]
        public string FullName { get; set; }

        public string Bio { get; set; }

        //relation with movie
        public virtual ICollection<Movie_Actor>Movie_Actors { get; set; }

    }
}