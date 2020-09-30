using System.Collections.Generic;

namespace email_manager.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAdress { get; set; }

        public List<CampaignContact> CampaignContacts { get; set; }
    }
}
