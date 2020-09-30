using System.Collections.Generic;

namespace email_manager.Models
{
    public class Campaign
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CampaingStatusId { get; set; }
        public CampaignStatus CampaignStatus { get; set; }

        public List<CampaignContact> CampaignContacts { get; set; }

        public int EmailId { get; set; }
        public Email Email { get; set; }
    }
}
