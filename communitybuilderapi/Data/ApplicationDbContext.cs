
using Microsoft.EntityFrameworkCore;
using communitybuilderapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using communitybuilderapi.DataModel;

namespace communitybuilderapi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<BusinessEvents>().HasKey(vf => new { vf.BusinessID, vf.EventID });
            //modelBuilder.Entity<ClientContacts>().HasKey(vf => new { vf.ClientID, vf.ContactID });
            //modelBuilder.Entity<ClientSites>().HasKey(vf => new { vf.ClientID, vf.SiteID });
            //modelBuilder.Entity<FundingPlanInvestor>().HasKey(vf => new { vf.FundingPlanID });
            //modelBuilder.Entity<Referral>().HasKey(vf => new { vf.ReferredUserID, vf.ReferrerUserID });
            //modelBuilder.Entity<SiteEvents>().HasKey(vf => new { vf.SiteID, vf.EventID });
        }
        public virtual DbSet<address> address { get; set; }
        public virtual DbSet<business> business { get; set; }
        public virtual DbSet<business_address> business_address { get; set; }
        public virtual DbSet<business_person> business_person { get; set; }
        public virtual DbSet<person> person { get; set; }
        public virtual DbSet<person_address> person_address { get; set; }
        public virtual DbSet<site> site { get; set; }
        public virtual DbSet<site_address> site_address { get; set; }
        public virtual DbSet<site_business> site_business { get; set; }

        //public virtual DbSet<SiteHeader> SiteHeader { get; set; }
        //public virtual DbSet<BusinessCommentSub> BusinessCommentSub { get; set; }
        //public virtual DbSet<BusinessEvents> BusinessEvents { get; set; }
        //public virtual DbSet<Client> Client { get; set; }
        //public virtual DbSet<ClientContacts> ClientContacts { get; set; }
        //public virtual DbSet<ClientSites> ClientSites { get; set; }
        //public virtual DbSet<Contact> Contact { get; set; }
        //public virtual DbSet<Country> Country { get; set; }
        //public virtual DbSet<FundingPlan> FundingPlan { get; set; }
        //public virtual DbSet<FundingPlanInvestor> FundingPlanInvestor { get; set; }
        //public virtual DbSet<FundingType> FundingType { get; set; }
        //public virtual DbSet<Referral> Referral { get; set; }
        //public virtual DbSet<SiteEvents> SiteEvents { get; set; }
        //public virtual DbSet<xStage1> xStage1 { get; set; }
        //public virtual DbSet<xStage2> xStage2 { get; set; }
        //public virtual DbSet<SitePage> SitePage { get; set; }
        //public virtual DbSet<CustomCss> CustomCss { get; set; }
        //public virtual DbSet<File> File { get; set; }
    }

}
