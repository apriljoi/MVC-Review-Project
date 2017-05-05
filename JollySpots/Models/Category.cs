using System.Collections.Generic;

namespace JollySpots.Models
{
    public class Category
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }


    }
}