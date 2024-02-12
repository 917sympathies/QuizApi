using Microsoft.AspNetCore.Mvc;
using Quiz.Application.Services.QuestionPackService;
using Quiz.Domain.Entities;

namespace Quiz.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionPackController : ControllerBase
    {
        private readonly IQuestionPackService _questionPackService;
        
        public QuestionPackController(IQuestionPackService questionPackService)
        {
            _questionPackService = questionPackService;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAllQuestionPacks()
        {
            return Ok(await _questionPackService.GetAllQuestionPacksAsync());
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetQuestionPackById(Guid id)
        {
            return Ok(await _questionPackService.GetQuestionPackByIdAsync(id));
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddQuestionPack(QuestionPack questionPack)
        {
            return Ok(); // add logic in service
        }
    }
}
