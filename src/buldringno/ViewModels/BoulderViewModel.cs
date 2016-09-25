using System;

namespace BuldringNo.ViewModels
{
    public class BoulderViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string DescriptionMain { get; set; }
        public string DescriptionSecondary { get; set; }
        public string Return { get; set; }
        public double GPSNorth { get; set; }
        public double GPSSouth { get; set; }
        public int AreaId { get; set; }
        public string AreaTitle { get; set; }
        public string Thumbnail { get; set; }
        public DateTime DateCreated { get; set; }
        public int TotalProblems { get; set; }
    }
}
