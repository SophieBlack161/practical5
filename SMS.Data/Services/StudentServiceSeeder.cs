using System;
using System.Text;
using System.Collections.Generic;

namespace SMS.Data.Services
{
    public static class StudentServiceSeeder
    {
        // use this class to seed the database with dummy test data using an IStudentService 
        public static void Seed(IStudentService svc)
        {
            // wipe and recreate the database
            svc.Initialise();

            // add students
            svc.AddStudent("Homer Simpson","Physics", "homer@mail.com", 41, 56, "https://static.wikia.nocookie.net/simpsons/images/b/bd/Homer_Simpson.png" );
            svc.AddStudent("Marge Simpson","English", "marge@mail.com", 38, 69 , "https://static.wikia.nocookie.net/simpsons/images/4/4d/MargeSimpson.png");
            svc.AddStudent("Bart Simpson","Maths", "bart@mail.com", 14, 61, "https://upload.wikimedia.org/wikipedia/en/a/aa/Bart_Simpson_200px.png" );
            svc.AddStudent("Lisa Simpson","Poetry", "lisa@mail.com", 13, 80, "https://upload.wikimedia.org/wikipedia/en/e/ec/Lisa_Simpson.png" );
            svc.AddStudent("Mr Burns","Management", "burns@mail.com", 81, 63, "https://static.wikia.nocookie.net/simpsons/images/a/a7/Montgomery_Burns.png" );
            svc.AddStudent("Moe","Business","moe@mail.com",41,73,"https://compote.slate.com/images/db5e5e2e-2b98-4b97-af5e-83c6c9c3ffee.jpg?width=960");
        }
    }
}
