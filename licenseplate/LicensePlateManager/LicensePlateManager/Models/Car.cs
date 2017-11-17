using System.ComponentModel.DataAnnotations;

namespace LicensePlateManager.Models
{
    public class Car
    {
        [Key]
        public string plate { get; set; }
        public string car_brand { get; set; }
        public string car_model { get; set; }
        public string color { get; set; }
        public string year { get; set; }
    }
}
