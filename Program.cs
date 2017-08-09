using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  EF6CodeFirstApplication.entities;

namespace EF6CodeFirstApplication
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            using (var db = new SurveyContext())
            {
                var user = new User();

                db.Users.Add(user);
                db.SaveChanges();

                var survey = new Survey()
                {
                    Title = "Test",
                    Creator = user,
                    CreationTime = new DateTime(2017, 4, 27),
                };

                db.Surveys.Add(survey);
                db.SaveChanges();
            }

            using (var db = new SurveyContext())
            {
                foreach (var user in db.Users)
                {
                    Console.WriteLine("{0}", user.Id);
                }

                foreach (var survey in db.Surveys)
                {
                    Console.WriteLine("{0} {1} {2} {3}", survey.Id, survey.Title, survey.CreationTime, survey.Creator.Id);
                }
                Console.ReadKey();
            }
        }
    }
}
