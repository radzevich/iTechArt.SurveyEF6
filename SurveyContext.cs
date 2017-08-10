using System;

namespace EF6CodeFirstApplication
{
    using System.Data.Entity;
    using entities;

    public class SurveyContext : DbContext
    {
        static SurveyContext()
        {
           //Database.SetInitializer(new DropCreateDatabaseAlways<SurveyContext>()); 
        }

        public SurveyContext()
            : base("name=SurveyContext")
        {
        }

        public DbSet<Survey> Surveys { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<AnswerOption> AnswerOptions { get; set; }
        public DbSet<ReceivedAnswer> ReceivedAnswers { get; set; }
        public DbSet<CompletedSurvey> CompletedSurveys { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CompletedSurvey>()
                .HasRequired(f => f.Survey)
                .WithRequiredDependent()
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ReceivedAnswer>()
                .HasRequired(f => f.Question)
                .WithRequiredDependent()
                .WillCascadeOnDelete(false);
        }
    }
}