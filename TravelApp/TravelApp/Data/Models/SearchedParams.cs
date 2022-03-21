namespace TravelApp.Data.Models
{
    public class SearchedParams
    {
        public DateOnly? DateRequested { get; set; }
        public TimeOnly? TimeRequested { get; set; }
        public string? FromLocation { get; set; }
        public string? ToLocation { get; set; }
    }
}
