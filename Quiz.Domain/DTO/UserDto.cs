﻿using Quiz.Domain.Entities;

namespace Quiz.Application.DTO;

public class UserDto
{
    public Guid Id { get; init; } = default!;
    public string Username { get; init; } = default!;
    public string Email { get; init; } = default!;
    public string Password { get; init; } = default!;
    public ICollection<UserDto> Friends { get; init; } = default!;
}