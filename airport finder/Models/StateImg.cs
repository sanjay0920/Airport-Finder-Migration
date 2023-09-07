using System.ComponentModel.DataAnnotations;

namespace airport_finder.Models
{
    public class StateImg
    {
        [Key]
        public string State { get; set; }

        public string Photo { get; set; }
    }
}
