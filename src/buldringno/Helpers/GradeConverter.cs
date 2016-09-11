using System.Collections.Generic;

namespace buldringno.Helpers
{
    public class GradeConverter
    {
        private List<string> _grades = new List<string>
        {
            "3", "4", "5",
            "6A", "6B", "6C",
            "7A", "7B", "7C",
            "8A", "8B", "8C"
        };

        public string GetFontGradeFromID(int id)
        {
            return _grades[id];
        }
    }
}
