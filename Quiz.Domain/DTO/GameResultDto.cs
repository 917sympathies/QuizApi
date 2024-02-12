using Quiz.Domain.Entities;

namespace Quiz.Domain.DTO;

public class GameResultDto
{
    public Game GameId { get; set; }
    public ICollection<PlayerResultDto> PlayersResults { get; set; }
}