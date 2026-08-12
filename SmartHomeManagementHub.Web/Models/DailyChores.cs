using System.ComponentModel.DataAnnotations;

namespace SmartHomeManagementHub.Web.Models
{
    public class DailyChores
    {
        [Required]
        public string Task { get; set; }

        [Required]
        public string AssignedPerson { get; set; }

        [Required]
        public string Day { get; set; }

        [Required]
        public string Status { get; set; }
    }
}
