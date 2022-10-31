using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentMVCApp.Models;
using StudentMVCApp.Models.ViewModel;
using StudentMVCApp.Services;



namespace StudentMVCApp.Controllers
{
    public class StudentController : Controller
    {
        private StudentService student = new StudentService();
        // GET: Student
        public ActionResult Home()
        {
            var vm = new HomeVm();
            var Service = new StudentService();
            vm.StudentCount = Service.GetHeadCount();
            vm.Students = Service.GetStudents();
            return View(vm);
        }

        public ActionResult Add()
        {
            var vm = new AddVM();
            vm.Title = "AddStudent";
            vm.ID = 1;
            vm.FirstName = "unknown";
            vm.LastName = "unknown";
            vm.CGPA = 1;
            return View(vm);
        }


        [HttpPost]
        public ActionResult Add(AddVM vM)
        {
            var service = new StudentService();
            if (!Validation(vM))
            {
                return View(vM);
            }
            service.AddStudent(new Student(vM.ID,vM.FirstName,vM.LastName,vM.CGPA));
            return Redirect("Home");

        }

        public bool Validation(AddVM vm)
        {
            if (vm.ID == 0  || vm.LastName == null || vm.FirstName == null || vm.CGPA == 0)
            {
                return false;
            }
           
            return true;
        }


        // GET: Edit

        public ActionResult Edit(int id)
        {
            var edit = new EditVm();
            edit.stu = student.GetStudentById(id);
            return View(edit);
        }

        [HttpPost]
        public ActionResult Edit(EditVm vm, int? id)
        {
            if (id == null)
            {
                return View(vm);
            }
            else
            {
                student.Update(vm.stu);
                return Redirect("Home");
            }
        }


        // GET: LogIn

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Index(LogInVm vm)
        {
            if (Validation(vm.UserName, vm.Password) == true)
            {
                vm.Message = "Wrong credentials";
            }
            else
            {
                vm.Message = "Successfull Login";
            }
               return View(vm);
           
        }

        public bool Validation(string username, string password)
        {
            if (username != "" || password != "")
            {
                return true;
            }
            return false;
        }


    

    }
}