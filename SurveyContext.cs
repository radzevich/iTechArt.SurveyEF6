using System;

namespace EF6CodeFirstApplication
{
    using System.Data.Entity;
    using entities;

    public class SurveyContext : DbContext
    {
        static SurveyContext()
        {
           Database.SetInitializer(new DropCreateDatabaseAlways<SurveyContext>()); 
        }

        public SurveyContext()
            : base("name=SurveyContext")
        {
        }

        public virtual DbSet<Survey> Surveys { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Page> Pages { get; set; }
        public virtual DbSet<AnswerOption> AnswerOptions { get; set; }
        public virtual DbSet<ReceivedAnswer> ReceivedAnswers { get; set; }
        public virtual DbSet<CompletedSurvey> CompletedSurveys { get; set; }

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