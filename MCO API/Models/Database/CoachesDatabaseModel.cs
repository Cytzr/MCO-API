using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace MCO_API.Models.Database
{
    [Table("Coaches")]
    public class CoachesDatabaseModel
    {
        [Key]
        public Guid? coachID { get; set; }
        public string? coachName { get; set; }
        public string? coachPassword { get; set; }
        public string? coachDescription { get; set; }
        public double? coachRating { get; set; }
        public string? coachPicture { get; set; }
        public int? coachPrice { get; set; }
        public Guid? coachGameID { get; set; } 
    }
}
