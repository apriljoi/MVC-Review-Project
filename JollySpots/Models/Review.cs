using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JollySpots.Models
{
    public class Review       
    {
        [Key]
        public int ID { get; set; }

        public string Destination { get; set; }
        public string DateVisited { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }

        /*used the bookshelf example as a template for this foreign key*/
        [ForeignKey("Category")] 
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}