using Microsoft.AspNetCore.Mvc;
using LanguageLearningSystem1.Services;
using LanguageLearningSystem1.Models;

namespace LanguageLearningSystem1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VocabularyController : ControllerBase
    {
        private readonly IVocabularyService _vocabularyService;

        public VocabularyController(IVocabularyService vocabularyService)
        {
            _vocabularyService = vocabularyService;
        }

        [HttpPost]
        public IActionResult CreateVocabulary(Vocabulary vocabulary)
        {
            _vocabularyService.AddVocabulary(vocabulary);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetVocabulary(int id)
        {
            var vocabulary = _vocabularyService.GetVocabulary(id);
            return vocabulary != null ? Ok(vocabulary) : NotFound();
        }

        [HttpPut]
        public IActionResult UpdateVocabulary(Vocabulary vocabulary)
        {
            _vocabularyService.UpdateVocabulary(vocabulary);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteVocabulary(int id)
        {
            _vocabularyService.DeleteVocabulary(id);
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAllVocabularies()
        {
            return Ok(_vocabularyService.GetAllVocabularies());
        }
    }
}
