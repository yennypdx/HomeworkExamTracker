using System;
using HomeworkExamTracker.Data;
using Microsoft.AspNetCore.Mvc;

namespace HomeworkExamTracker.Controllers
{
    [Route("api/[controller]")]
    public class ExamController : Controller
    {
        private IExamService _service;

        public ExamController(IExamService service)
        {
            this._service = service;
        }

        [HttpGet("get/examllist/{id}")]
        public IActionResult GetExamsPerSubject(int id) 
        {
            if(id > 0) {
                try {
                    var exams = _service.GetAllExamPerSubject(id);
                    return Ok(exams);
                } catch(Exception e) {
                    return BadRequest(e.Message);
                }
            } else {
                return BadRequest();
            }
        }

        [HttpGet("get/exam/{id}")]
        public IActionResult GetSingleExam(int id) 
        {
            if(id > 0) {
                try {
                    var exam = _service.GetSingleExam(id);
                    if(exam != null) {
                        return Ok(exam);
                    } else {
                        return BadRequest();
                    }
                } catch(Exception e) {
                    return BadRequest(e.Message);
                }                
            } else {
                return BadRequest();
            }
        }

        [HttpPost("add/exam")]
        public IActionResult AddExam([FromBody]Exam exam)
        {
            if(exam != null) {
                try {
                    _service.AddExam(exam);
                    return Ok(exam);
                } catch(Exception e) {
                    return BadRequest(e.Message);
                }                
            } else {
                return BadRequest();
            }
        }

        [HttpDelete("del/exam/{id}")]
        public IActionResult DeleteExam(int id)
        {
            if(id > 0) {
                try {
                    _service.DeleteExam(id);
                    return Ok(id);
                } catch(Exception e) {
                    return BadRequest(e.Message);
                }
            } else {
                return BadRequest();
            }
        }

        [HttpPut("update/exam/{id}")]
        public IActionResult UpdateExam(int id, [FromBody]Exam exam)
        {
            if(id > 0 && exam != null) {
                try {
                    _service.UpdateExam(id, exam);
                    return Ok(id);
                } catch(Exception e) {
                    return BadRequest(e.Message);
                }
            } else {
                return BadRequest();
            }
        }
    }
}