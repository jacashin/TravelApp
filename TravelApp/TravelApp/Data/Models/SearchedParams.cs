using System.ComponentModel.DataAnnotations;
namespace TravelApp.Data.Models
{
    public class SearchedParams
    {
        [Required(ErrorMessage = "A valid date is required")]
        public DateOnly? DateRequested { get; set; }
        [Required(ErrorMessage = "A valid time is required")]
        public TimeOnly? TimeRequested { get; set; }
        [Required(ErrorMessage = "Please enter a departing address")]
        public string? FromLocationAddress { get; set; }
        [Required(ErrorMessage = "Please enter a departing city")]
        public string? FromLocationCity { get; set; }
        [Required(ErrorMessage = "A valid 5-digit Zip is required"), RegularExpression(@"^([0-9]{5})$")]
        public string? FromLocationAreaCode { get; set; }
        [Required(ErrorMessage = "Please enter your destination address")]
        public string? ToLocationAddress { get; set; }
        [Required(ErrorMessage = "Please enter your destination city")]
        public string? ToLocationCity { get; set; }
        [Required(ErrorMessage = "A valid 5-digit Zip is required"), RegularExpression(@" ^ ([0-9]{5})$"), ]
        public string? ToLocationAreaCode { get; set; }
    }
}
