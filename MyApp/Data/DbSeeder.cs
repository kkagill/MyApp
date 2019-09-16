using Microsoft.AspNetCore.Identity;
using MyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Data
{
    public class DbSeeder
    {
        private readonly MyAppContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public DbSeeder(MyAppContext context,
                        UserManager<ApplicationUser> userManager,
                        RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task SeedDatabase()
        {
            if (!_context.Teachers.Any())
            {
                List<Teacher> teachers = new List<Teacher>()
                {
                    new Teacher() { Name = "세종대왕", Class = "한글" },
                    new Teacher() { Name = "이순신", Class = "해상전략" },
                    new Teacher() { Name = "제갈량", Class = "지략" },
                    new Teacher() { Name = "을지문덕", Class = "지상전략" }
                };

                await _context.AddRangeAsync(teachers);
                await _context.SaveChangesAsync();
            }

            var adminAccount = await _userManager.FindByNameAsync("admin@gmail.com");
            var adminRole = new IdentityRole("Admin");
            await _roleManager.CreateAsync(adminRole);
            await _userManager.AddToRoleAsync(adminAccount, adminRole.Name);
        }
    }
}
