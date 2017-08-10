﻿using System;
using System.Collections.Generic;

namespace EF6CodeFirstApplication.entities
{
    public class CompletedSurvey
    {
        public int Id { get; set; }

        public int SurveyId { get; set; }
        public Survey Survey { get; set; }

        public int? CreatorId { get; set; }
        public User Creator { get; set; }

        public DateTime Date { get; set; }

        public virtual ICollection<ReceivedAnswer> ReceivedAnswers { get; set; }

        public CompletedSurvey()
        {
            ReceivedAnswers = new List<ReceivedAnswer>();
        }
    }
}
