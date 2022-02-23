
using Microsoft.AspNetCore.Mvc;

using SMS.Data.Models; //student lives here
using SMS.Data.Services;//service lives here

namespace SMS.Web.Controllers
{
    public class StudentController : Controller
    {
        private IStudentService svc;

        public StudentController()
        {
            svc = new StudentServiceDb();//initialized the service
        }//this controller cannot operate without this service(hard coupling-bad)

        // GET /student
        public IActionResult Index()
        {
            // TBC - load students using service and pass to view
           
            var students = svc.GetStudents();
            return View(students);
        }

        // GET /student/details/{id}
        public IActionResult Details(int id)
        {
            // retrieve the student with specifed id from the service
            var s = svc.GetStudent(id);

            // TBC check if s is null and return NotFound()
            if(s == null)
            {
                return NotFound();
            }

            // pass student as parameter to the view
            return View(s);
        }

        // GET: /student/create
        public IActionResult Create()
        {
            // display blank form to create a student
            return View();
        }

        // POST /student/create
        [HttpPost]
        public IActionResult Create(Student s)
        {
            // complete POST action to add student
            if (ModelState.IsValid)
            {
                // TBC call service AddStudent method using data in s
                var student = svc.AddStudent(s.Name,s.Course,s.Email,s.Age,s.Grade,s.PhotoUrl);
                
                return RedirectToAction(nameof(Index));
            }
            
            // redisplay the form for editing as there are validation errors
            return View(s);
        }

        // GET /student/edit/{id}
        public IActionResult Edit(int id)
        {
            // load the student using the service
            var s = svc.GetStudent(id);

            // TBC check if s is null and return NotFound()
            if(s == null)
            {
                return NotFound();
            }  
            // pass student to view for editing
            return View(s);
        }

        // POST /student/edit/{id}
        [HttpPost]
        public IActionResult Edit(int id, Student s)
        {
            // complete POST action to save student changes
            if (ModelState.IsValid)
            {
                // TBC pass data to service to update
                var student = svc.UpdateStudent(s);

                return RedirectToAction(nameof(Index));
            }

            // redisplay the form for editing as validation errors
            return View(s);
        }

        // GET / student/delete/{id}
        public IActionResult Delete(int id)
        {
            // load the student using the service
            var s = svc.GetStudent(id);
            // check the returned student is not null and if so return NotFound()
            if (s == null)
            {
                return NotFound();
            }     
            
            // pass student to view for deletion confirmation
            return View(s);
        }

        // POST /student/delete/{id}
        [HttpPost]
        public IActionResult DeleteConfirm(int id)
        {
            // TBC delete student via service
            var s = svc.DeleteStudent(id);
            
            // redirect to the index view
            return RedirectToAction(nameof(Index));
            
        }
    }
}

