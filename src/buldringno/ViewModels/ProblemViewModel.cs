using System;

namespace BuldringNo.ViewModels
{
    public class ProblemViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Uri { get; set; }
        public int BoulderId { get; set; }
        public string BoulderTitle { get; set; }

        public DateTime DateUploaded { get; set; }
    }
}
