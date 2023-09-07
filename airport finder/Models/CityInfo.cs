using System.ComponentModel.DataAnnotations;

namespace airport_finder.Models
{
    public class CityInfo
    {
        [Key]
        public string City { get; set; }

        public double Lat { get; set; }

        public double Long { get; set; }
    }
}
