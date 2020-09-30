using email_manager.Models;
using Microsoft.EntityFrameworkCore;


namespace email_manager.Contexts
{
    public class EmailManagerContext : DbContext
    {
        public EmailManagerContext(DbContextOptions<EmailManagerContext> options) : base(options) { }

        public DbSet<Campaign> Campaign { get; set; }
        public DbSet<CampaignStatus> CampaignStatus { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Email> Email { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CampaignStatus>()
                .HasMany(cs => cs.Campaigns);

            modelBuilder.Entity<Campaign>()
                .HasOne(c => c.Email)
                .WithMany(e => e.Campaigns)
                .HasForeignKey(c => c.EmailId);

            modelBuilder.Entity<Campaign>()
                .HasOne(c => c.CampaignStatus)
                .WithMany(cs => cs.Campaigns)
                .HasForeignKey(c => c.CampaingStatusId);

            modelBuilder.Entity<CampaignContact>()
                .HasKey(cc => new { cc.CampaignId, cc.ContactId });

            modelBuilder.Entity<CampaignContact>()
                .HasOne(cc => cc.Campaign)
                .WithMany(c => c.CampaignContacts)
                .HasForeignKey(cc => cc.CampaignId);

            modelBuilder.Entity<CampaignContact>()
               .HasOne(cc => cc.Contact)
               .WithMany(c => c.CampaignContacts)
               .HasForeignKey(cc => cc.ContactId);
        }
    }
}
