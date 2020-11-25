using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportAttendanceManager.Models;

namespace SportAttendanceManager.DataAccessLayer
{
    public class SportAttendanceManagerInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SportAttendanceManagerContext>
    {
        // Seed method method takes the database context object as an input parameter,
        // and the code in the method uses that object to add new entities to the database.
        // For each entity type, the code creates a collection of new entities,
        // adds them to the appropriate DbSet property, and then saves the changes to the database
        protected override void Seed(SportAttendanceManagerContext context)
        {
            //base.Seed(context);

            var users = new List<User>
            {
                new User { FirstName = "Daniel" , LastName = "Ciucur"},
                new User {FirstName = "Alina", LastName = "Sturza"},
                new User {FirstName = "Mike", LastName = "Andrew"}
            };

            users.ForEach(m => context.Users.Add(m));
            context.SaveChanges();

            // Next step:
            // To tell Entity Framework to use your initializer class,
            // add an element to the entityFramework element in the application Web.config file
            // (the one in the root project folder)

        }
    }
}