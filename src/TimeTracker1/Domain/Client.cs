using System.ComponentModel.DataAnnotations;

namespace TimeTracker1.Domain
{
    public class Client
    {
        public long Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
