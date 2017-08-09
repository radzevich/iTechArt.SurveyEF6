namespace EF6CodeFirstApplication
{
    using System.Data.Entity;
    using entities;

    public class SurveyContext : DbContext
    {
        static SurveyContext()
        {
            // Database.SetInitializer(new DropCreateDatabaseAlways<SurveyContext>()); 
        }

        public SurveyContext()
            : base("name=SurveyContext")
        {
        }

        public virtual DbSet<Survey> Surveys { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}