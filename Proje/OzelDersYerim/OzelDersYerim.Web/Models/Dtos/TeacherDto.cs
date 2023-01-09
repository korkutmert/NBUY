namespace OzelDersYerim.Web.Models.Dtos
{
    public class TeacherDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string Location { get; set; }
        public string Url { get; set; }
        public string ProfilePictureUrl { get; set; }
        public Decimal? PricePerHour { get; set; }
        public int BranchId { get; set; }
    }
}
