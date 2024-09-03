﻿using Microsoft.AspNetCore.Identity;

namespace GymMarket.API.Models
{
    public class AppUser : IdentityUser
    {
        public string? FullName { get; set; }
    }
}
