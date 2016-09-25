using System;

namespace BuldringNo.ViewModels
{
    public class AreaViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string DescriptionMain { get; set; }
        public string DescriptionSecondary { get; set; }
        public string Parking { get; set; }
        public string ApproachTime { get; set; }
        public DateTime DateCreated { get; set; }
        public int TotalBoulders { get; set; }
    }
}
