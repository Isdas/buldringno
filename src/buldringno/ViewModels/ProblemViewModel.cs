using System;

namespace BuldringNo.ViewModels
{
    public class ProblemViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Uri { get; set; }
        public string DescriptionMain { get; set; }
        public string DescriptionSecondary { get; set; }
        public int BoulderId { get; set; }
        public string BoulderTitle { get; set; }
        public string GradeStandingStart { get; set; }
        public string GradeSitStart { get; set; }
        public double Height { get; set; }
        public int NumberOfPads { get; set; }
        public int NumberOfStars { get; set; }
        public string FirstClimberStanding { get; set; }
        public string FirstClimberSitStart { get; set; }
        public DateTime FirstClimberStandingDate { get; set; }
        public DateTime FirstClimberSitStartDate { get; set; }
        public DateTime DateUploaded { get; set; }
    }
}
