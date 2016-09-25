using System;
using System.Collections.Generic;

namespace BuldringNo.Entities
{
    public class Area : IEntityBase
    {
        public Area()
        {
            Boulders = new List<Boulder>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string DescriptionMain { get; set; }
        public string DescriptionSecondary { get; set; }
        public string Parking { get; set; }
        public string ApproachTime { get; set; }
        public DateTime DateCreated { get; set; }
        public virtual ICollection<Boulder> Boulders { get; set; }
    }
}
