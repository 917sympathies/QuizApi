using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Quiz.Application.Services.GameService;
using Quiz.Domain.DTO;
using Quiz.Domain.Entities;

namespace Quiz.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly IGameService _gameService;
        
        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetGameById(Guid id)
        {
            var response = await _gameService.GetByIdAsync(id);
            return response == null ? BadRequest() : Ok(response);
        }
        
        [HttpPost]
        public async Task<IActionResult> CreateGame(IEnumerable<string> usernames, Guid questionPackId)
        {
            var response = await _gameService.CreateAsync(usernames, questionPackId);
            return response == null ? BadRequest() : Ok(response);
        }

        [HttpPost("{id:guid}")]
        public async Task<IActionResult> EndGame(Guid id, [FromBody]GameResultDto result)
        {
            var response = await _gameService.EndGame(id, result);
            return response == null ? BadRequest() : Ok();
        }
        
        
    }
}
