using System;
using System.Collections.Generic;

namespace BuldringNo.Entities
{
    public class Boulder : IEntityBase
    {
        public Boulder()
        {
            Problems = new List<Problem>(); 
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string DescriptionMain { get; set; }
        public string DescriptionSecondary { get; set; }
        public string Size { get; set; }
        public string Return { get; set; }
        public double GPSNorth { get; set; }
        public double GPSSouth { get; set; }
        public virtual Area Area { get; set; }
        public int AreaId { get; set; }
        public DateTime DateCreated { get; set; }
        public virtual ICollection<Problem> Problems { get; set; }
    }
}
