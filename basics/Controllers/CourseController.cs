using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

public class CourseController: Controller
{
    //details
    public IActionResult Details(int? id)
    {
        if (id == null){
            return RedirectToAction("List","Course");
        }
        var courselistobject = Repository.GetById(id);

        return View(courselistobject);
    }
    //course/list
    public IActionResult List()
    {

        return View("CourseList",Repository.Courses);
    }


}