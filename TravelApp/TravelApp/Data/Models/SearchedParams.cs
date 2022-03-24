using System.ComponentModel.DataAnnotations;
namespace TravelApp.Data.Models
{
    public class SearchedParams
    {
        [Required]
        public DateOnly? DateRequested { get; set; }
        public TimeOnly? TimeRequested { get; set; }
        public string? FromLocationAddress { get; set; }
        public string? FromLocationCity { get; set; }
        [Required, RegularExpression(@"^([0-9]{5})$")]
        public string? FromLocationAreaCode { get; set; }
        public string? ToLocationAddress { get; set; }
        public string? ToLocationCity { get; set; }
        [Required, RegularExpression(@"^([0-9]{5})$")]
        public string? ToLocationAreaCode { get; set; }
    }
}
