using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EF6CodeFirstApplication.entities
{
    public class Page
    {
        public int Id { get; set; }

        public int SurveyId { get; set; }
        public Survey Survey { get; set; }

        [StringLength(256)]
        public string Title { get; set; }

        public ICollection<Question> Questions { get; set; }

        public Page()
        {
            Questions = new List<Question>();
        }
    }
}
