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

        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public virtual ICollection<Problem> Problems { get; set; }
    }
}
