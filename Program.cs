using System;
using System.Linq;
using  EF6CodeFirstApplication.entities;

namespace EF6CodeFirstApplication
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            using (var db = new SurveyContext())
            {
                var user = new User { };

                db.Users.Add(user);
                db.SaveChanges();

                var survey = new Survey
                {
                    Title = "Test",
                    Creator = user,
                    CreationTime = new DateTime(2017, 4, 27)
                };

                db.Surveys.Add(survey);
                db.SaveChanges();

                var page = new Page
                {
                    Title = "Страница"
                };

                db.Pages.Add(page);
                db.SaveChanges();

                var question = new Question
                {
                    TypeId = 1,
                    Text = "Вопрос?",
                    Page = page,
                    Survey = survey
                };

                db.Questions.Add(question);
                db.SaveChanges();

                var answerOption = new AnswerOption
                {
                    Question = question,
                    Value = "Ответ"
                };

                db.AnswerOptions.Add(answerOption);
                db.SaveChanges();

                var completedSurvey = new CompletedSurvey
                {
                    Survey = survey,
                    Creator = user,
                    Date = new DateTime(2017, 6, 3),
                };

                db.CompletedSurveys.Add(completedSurvey);
                db.SaveChanges();

                var receivedAnswer = new ReceivedAnswer
                {
                    Question = question,
                    CompletedSurvey = completedSurvey,
                    Value = "Полученный ответ"
                };

                db.ReceivedAnswers.Add(receivedAnswer);
                db.SaveChanges();
            }

            using (var db = new SurveyContext())
            {
                foreach (var cs in db.Surveys)
                {
                    Console.WriteLine($"{cs.Title}");
                }

                foreach (var user in db.Users)
                {
                    Console.WriteLine($"{user.CompletedSurveys.FirstOrDefault()?.Date}");
                }
                Console.ReadKey();

            }
        }
    }
}
