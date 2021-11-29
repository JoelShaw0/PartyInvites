using System.ComponentModel.DataAnnotations;

namespace Example.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your age")]
        public string Age { get; set; }
        [Required(ErrorMessage = "Please enter the Time")]
        public string Time { get; set; }
        [Required(ErrorMessage = "Select if you will be requiring Parking")]
        //public string Parking { get; set; }
        public bool ? Parking { get; set; }
    }
}
