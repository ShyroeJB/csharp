using System.Collections.Generic;

namespace email_manager.Models
{
    public class Email
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string Object { get; set; }
        public string Expeditor { get; set; }

        public List<Campaign> Campaigns { get; set; }
    }
}
