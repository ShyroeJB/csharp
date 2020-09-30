using System.Collections.Generic;

namespace email_manager.Models
{
    public class Email
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }

        public List<Campaign> Campaigns { get; set; }
    }
}
