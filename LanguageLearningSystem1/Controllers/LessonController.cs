using Microsoft.AspNetCore.Mvc;
using LanguageLearningSystem1.Services;
using LanguageLearningSystem1.Models;

namespace LanguageLearningSystem1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LessonController : ControllerBase
    {
        private readonly ILessonService _lessonService;

        public LessonController(ILessonService lessonService)
        {
            _lessonService = lessonService;
        }

        [HttpPost]
        public IActionResult CreateLesson(Lesson lesson)
        {
            _lessonService.AddLesson(lesson);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetLesson(int id)
        {
            var lesson = _lessonService.GetLesson(id);
            return lesson != null ? Ok(lesson) : NotFound();
        }

        [HttpPut]
        public IActionResult UpdateLesson(Lesson lesson)
        {
            _lessonService.UpdateLesson(lesson);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteLesson(int id)
        {
            _lessonService.DeleteLesson(id);
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAllLessons()
        {
            return Ok(_lessonService.GetAllLessons());
        }
    }
}

