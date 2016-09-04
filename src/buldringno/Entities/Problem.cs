using System;

namespace BuldringNo.Entities
{
    public class Problem : IEntityBase
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Uri { get; set; }
        public virtual Boulder Boulder { get; set; }
        public int BoulderId { get; set; }
        public string Grade { get; set; }
        public DateTime DateUploaded { get; set; }
    }
}
