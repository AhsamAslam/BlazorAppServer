
using Microsoft.EntityFrameworkCore;
using communitybuilderapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace communitybuilderapi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BusinessEvents>().HasKey(vf => new { vf.BusinessID, vf.EventID });
            modelBuilder.Entity<ClientContacts>().HasKey(vf => new { vf.ClientID, vf.ContactID });
            modelBuilder.Entity<ClientSites>().HasKey(vf => new { vf.ClientID, vf.SiteID });
            modelBuilder.Entity<FundingPlanInvestor>().HasKey(vf => new { vf.FundingPlanID});
            modelBuilder.Entity<Referral>().HasKey(vf => new { vf.ReferredUserID, vf.ReferrerUserID });
            modelBuilder.Entity<SiteEvents>().HasKey(vf => new { vf.SiteID, vf.EventID });
        }
        public virtual DbSet<GenericLocalizationKeyValues> GenericLocalizationKeyValues { get; set; }
        public virtual DbSet<Site> Site  { get; set; }
        public virtual DbSet<Localization> Localization { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<LocalizationKeyValues> LocalizationKeyValues { get; set; }
        public virtual DbSet<Business> Business { get; set; }
        public virtual DbSet<BusinessComment> BusinessComments { get; set; }
        public virtual DbSet<BusinessFile> BusinessFiles { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Fan> Fans { get; set; }

        public virtual DbSet<SiteHeader> SiteHeader { get; set; }
        public virtual DbSet<BusinessCommentSub> BusinessCommentSub { get; set; }
        public virtual DbSet<BusinessEvents> BusinessEvents { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<ClientContacts> ClientContacts { get; set; }
        public virtual DbSet<ClientSites> ClientSites { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<FundingPlan> FundingPlan { get; set; }
        public virtual DbSet<FundingPlanInvestor> FundingPlanInvestor { get; set; }
        public virtual DbSet<FundingType> FundingType { get; set; }
        public virtual DbSet<Referral> Referral { get; set; }
        public virtual DbSet<SiteEvents> SiteEvents { get; set; }
        public virtual DbSet<xStage1> xStage1 { get; set; }
        public virtual DbSet<xStage2> xStage2 { get; set; }
        public virtual DbSet<SitePage> SitePage { get; set; }
        public virtual DbSet<CustomCss> CustomCss { get; set; }
        public virtual DbSet<File> File { get; set; }
    }

}
