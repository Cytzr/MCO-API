using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MCO_API.Models.Database
{
    [Table("Events")]
    public class EventsDatabaseModel
    {
        [Key]
        public Guid? eventID { get; set; }
        public string? eventWriter { get; set; }
        public string? eventName { get; set; }
        public string? eventDescription { get; set; }
        public string? eventPicture { get; set; }
        public string? startDate { get; set; }
        public string? endDate { get; set; }
        public Guid? eventGameID { get; set; }
    }
}
