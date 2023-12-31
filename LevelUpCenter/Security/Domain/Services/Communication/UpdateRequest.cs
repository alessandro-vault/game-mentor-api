﻿using LevelUpCenter.Security.Domain.Models;

namespace LevelUpCenter.Security.Domain.Services.Communication;

public class UpdateRequest
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }

    public UserRole Role { get; set; }
}
