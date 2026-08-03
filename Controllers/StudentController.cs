using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAPI.Models;
using StudentAPI.Services;

namespace StudentAPI.Controllers
{
        [ApiController]
        [Route("api/[controller]")]
        public class StudentController : ControllerBase
        {
            private readonly IStudentService _studentService;

            public StudentController(IStudentService service)
            {
                this._studentService = service;
            }

            [HttpGet("{id}")]
            public async Task<IActionResult> GetStudentById(int id)
            {
            var student = await
            _studentService.GetStudentById(id);
            if(student == null)
            {
                return NotFound();
            }
                return Ok(student);
            }

            [HttpPost]
            public async Task<IActionResult> Add(Student student)
            {
                await _studentService.Add(student);
                return Ok(student);
            }

            [HttpPut]
            public async Task<IActionResult> Update(Student student)
            {
                await _studentService.Update(student);
                return Ok();
            }

            [HttpDelete("{id}")]
            public async Task<IActionResult> Delete(int id)
            {
                await _studentService.Delete(id);
                return Ok();
            }
        }
    }

