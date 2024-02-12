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
        
        [HttpPost]
        public async Task<Game> CreateGame(IEnumerable<string> usernames, Guid questionPackId)
        {
            return await _gameService.CreateAsync(usernames, questionPackId);
        }

        [HttpPost("{id:guid}")]
        public async Task<IActionResult> EndGame(Guid id, [FromBody]GameResultDto result)
        {
            var response = await _gameService.EndGame(id, result);
            return response == null? BadRequest() : Ok();
        }
        
        
    }
}
