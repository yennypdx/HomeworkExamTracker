using System;
using HomeworkExamTracker.Data;
using Microsoft.AspNetCore.Mvc;

namespace HomeworkExamTracker.Controllers
{
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        private IStudentService _service;

        public StudentController(IStudentService service)
        {
            this._service = service;
        }

        [HttpGet("get/student/{email}")]
        public IActionResult GetStudent(string email)
        {
            if(email != null) {
                try {
                    var student = _service.GetSingleStudent(email);
                    return Ok(student);                        
                }
                catch(Exception e) {
                    return BadRequest(e.Message);
                }
            } else {
                return BadRequest();
            }            
        }

        [HttpPut("update/student/{email}")]
        public IActionResult UpdateStudent(string email, [FromBody]Student student)
        {
            if(email != null && student != null) {
                try {
                    _service.UpdateStudent(email, student);
                    return Ok(student);
                }
                catch(Exception e) {
                    return BadRequest(e.Message);
                }
            } else {
                return BadRequest();
            }            
        }
    }
}