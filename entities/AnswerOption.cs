using System.ComponentModel.DataAnnotations;

namespace EF6CodeFirstApplication.entities
{
    public class AnswerOption
    {
        public int Id { get; set; }

        public int QuestionId { get; set; }
        public Question Question { get; set; }

        [StringLength(512)]
        public string Value { get; set; } 
    }
}
