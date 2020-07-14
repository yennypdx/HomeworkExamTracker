using System;
using HomeworkExamTracker.Data;
using Microsoft.AspNetCore.Mvc;

namespace HomeworkExamTracker.Controllers
{
    [Route("api/[controller]")]
    public class SubjectController : Controller
    {
        private ISubjectService _service;

        public SubjectController(ISubjectService service)
        {
            this._service = service;
        }

        [HttpGet("get/subjects")]
        public IActionResult GetSubjects()
        {
            try {
                var subjects = _service.GetAllSubject();
                return Ok(subjects);
            } catch(Exception e) {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("add/subject")]
        public IActionResult AddSubject([FromBody]Subject subject)
        {
            if(subject != null) {
                try {
                    _service.AddSubject(subject);
                    return Ok(subject);
                } catch(Exception e) {
                    return BadRequest(e.Message);
                }
            } else {
                return BadRequest();
            }
        }

        [HttpDelete("del/subject/{id}")]
        public IActionResult DeleteSubject(int id)
        {
            if(id > 0) {
                try {
                    _service.DeleteSubject(id);
                    return Ok(id);
                } catch(Exception e) {
                    return BadRequest(e.Message);
                }
            } else {
                return BadRequest();
            }
        }

        [HttpPut("update/subject/{id}")]
        public IActionResult UpdateSubject(int id, [FromBody]Subject subject)
        {
            if(id > 0 && subject != null) {
                try {
                    _service.UpdateSubject(id, subject);
                    return Ok(subject);
                } catch(Exception e) {
                    return BadRequest(e.Message);
                }            
            } else {
                return BadRequest();
            }
        }
    }
}