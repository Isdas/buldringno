using System;

namespace BuldringNo.ViewModels
{
    public class AreaViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public int TotalBoulders { get; set; }
    }
}
