﻿using Microsoft.AspNetCore.Identity;

namespace KursProject.EntityLayer.Entities
{
    public class AppUser:IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}