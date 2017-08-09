using System.Collections.Generic;

namespace EF6CodeFirstApplication.entities
{
    public class User
    {
        public int Id { get; set; }

        public ICollection<Survey> CreatedSurveys { get; set; }
        //public ICollection<CompletedSurvey> CompletedSurveys { get; set; }
       
        public User()
        {
            CreatedSurveys = new List<Survey>();
        //    CompletedSurveys = new List<CompletedSurvey>();
        }
    }
}
