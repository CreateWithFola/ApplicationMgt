using Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class CosmosContext : DbContext
    {
        public CosmosContext(DbContextOptions<CosmosContext> options) : base(options)
        {
        }
        public DbSet<CandidateQuestion> Questions { get; set; }
        public DbSet<ApplicationForm> ApplicationForms { get; set; }
        public DbSet<Candidate> Candidates { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "AccountEndpoint=https://localhost:8081/;AccountKey=C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==";
            optionsBuilder.UseCosmos(connectionString, "ApplicationMgtDb");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasDefaultContainer("Questions");

            builder.Entity<CandidateQuestion>()
                   .ToContainer(nameof(CandidateQuestion))
                   .HasPartitionKey(c => c.Id)
                   .HasNoDiscriminator();

            builder.Entity<ApplicationForm>()
                   .ToContainer(nameof(ApplicationForm))
                   .HasPartitionKey(c => c.Id)
                   .HasNoDiscriminator();

            builder.Entity<Candidate>()
                   .ToContainer(nameof(Candidate))
                   .HasPartitionKey(c => c.Id)
                   .HasNoDiscriminator();
        }
    }

}
