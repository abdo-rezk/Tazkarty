using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Tazkarty.Data;

namespace Tazkarty.Models
{
    [Table("Movie")]
    public class Movie
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }

        //relation with actor
        public virtual ICollection<Movie_Actor> Movie_Actors { get; set; }

        //relation with cinema
       
        [ForeignKey("Cinema")]
        public int CinemaId { get; set; }
        public virtual Cinema Cinema { get; set; }

        //relation with producer
       
        [ForeignKey("Producer")]
        public int ProducerId { get; set; }
        public virtual Producer Producer { get; set; }


    }
}