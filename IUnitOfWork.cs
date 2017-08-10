using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF6CodeFirstApplication.entities;
using EF6CodeFirstApplication.Repositories;

namespace EF6CodeFirstApplication
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<User> Users { get; }
        IRepository<Survey> Surveys { get; }
        IRepository<CompletedSurvey> CompletedSurveys { get; }
        IRepository<Question> Questions { get; }
        IRepository<Page> Pages { get; }
        IRepository<AnswerOption> AnswerOptions { get; }
        IRepository<ReceivedAnswer> ReceivedAnswers { get; }

        void Save();
    }
}
