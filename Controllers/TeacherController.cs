using System;
using HomeworkExamTracker.Data;
using Microsoft.AspNetCore.Mvc;

namespace HomeworkExamTracker.Controllers
{
    [Route("api/[controller]")]
    public class TeacherController : Controller
    {
        private ITeacherService _service;

        public TeacherController(ITeacherService service)
        {
            this._service = service;
        }

        [HttpGet("get/teachers")]
        public IActionResult GetTeachers()
        {
            try {
                var teachers = _service.GetAllTeacher();
                return Ok(teachers);                
            }
            catch(Exception e) {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("get/teacher/{id}")]
        public IActionResult GetTeacher(int id)
        {
            if(id != 0) {
                try {
                    var teacher = _service.GetTeacher(id);
                    return Ok(teacher);
                }
                catch(Exception e) {
                    return BadRequest(e.Message);
                }                
            } else {
                return BadRequest();
            }
        }

        [HttpPost("add/teacher")]
        public IActionResult AddTeacher([FromBody]Teacher teacher)
        {
            if(teacher != null) {
                try {
                    _service.AddTeacher(teacher);
                    return Ok(teacher);
                } catch(Exception e) {
                    return BadRequest(e.Message);
                }
            } else {
                return BadRequest();
            }
        }

        [HttpDelete("del/teacher/{id}")]
        public IActionResult DeleteTeacher(int id)
        {
            if(id > 0) {
                try {
                    _service.DeleteTeacher(id);
                    return Ok(id);
                } catch(Exception e) {
                    return BadRequest(e.Message);
                }
            } else {
                return BadRequest();
            }
        }

        [HttpPut("update/teacher/{id}")]
        public IActionResult UpdateTeacher(int id, [FromBody]Teacher teacher)
        {
            if(id > 0 && teacher != null) {
                try {
                    _service.UpdateTeacher(id, teacher);
                    return Ok(teacher);
                } catch(Exception e) {
                    return BadRequest(e.Message);
                }
            } else {
                return BadRequest();
            }
        }
    }
}