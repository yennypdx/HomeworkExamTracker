using System;
using System.Collections.Generic;
using HomeworkExamTracker.Data;
using Microsoft.AspNetCore.Mvc;

namespace HomeworkExamTracker.Controllers
{
    [Route("api/[controller]")]
    public class HomeworkController : Controller
    {
        private IHomeworkService _service;

        public HomeworkController(IHomeworkService service)
        {
            this._service = service;
        }

        [HttpGet("get/hwlist/{id}")]
        public IActionResult GetHomeworkListPerSubject(int id)
        {
            if(id > 0)
            {
                try {
                    var homeworks = _service.GetAllHomeworkPerSubject(id);
                    return Ok(homeworks);
                } catch(Exception e) {
                    return BadRequest(e.Message);
                }
            } else {
                return BadRequest();
            }
        }

        [HttpGet("get/homework/{id}")]
        public IActionResult GetSingleHomework(int id)
        {
            if(id > 0) {
                try {
                    var homework = _service.GetSingleHomework(id);
                    return Ok(homework);
                } catch(Exception e) {
                    return BadRequest(e.Message);
                }
            } else {
                return BadRequest();
            }
        }

        [HttpPost("add/homework")]
        public IActionResult AddHomework([FromBody]Homework homework)
        {
            if(homework != null) {
                try {
                    _service.AddHomework(homework);
                    return Ok(homework);
                } catch(Exception e) {
                    return BadRequest(e.Message);
                }
            } else {
                return BadRequest();
            }
        }

        [HttpDelete("del/homework/{id}")]
        public IActionResult DeleteHomework(int id)
        {
            if(id > 0) {
                try {
                    _service.DeleteHomework(id);
                    return Ok(id);
                } catch(Exception e) {
                    return BadRequest(e.Message);
                }
            } else {
                return BadRequest();
            }
        }

        [HttpPut("update/homework/{id}")]
        public IActionResult UpdateHomework(int id, [FromBody]Homework homework)
        {
            if(id > 0 && homework != null) {
                try {
                    _service.UpdateHomework(id, homework);
                    return Ok(homework);
                } catch(Exception e) {
                    return BadRequest(e.Message);
                }
            } else {
                return BadRequest();
            }
        }
    }
}