using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace email_manager.ViewModels
{
    public class CampaignDto
    {
        public string Name { get; set; }
        public int? EmailId { get; set; }
        public string EmailName { get; set; }
        public string EmailContent { get; set; }
        public string EmailObject { get; set; }
        public string EmailExpeditor { get; set; }

        [Display(Name = "Contact")]
        public List<string> ContactsEmailAdress { get; set; }
    }
}
