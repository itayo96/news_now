using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebSockets.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;

namespace NewsNow.Models
{
    public static class SeedData
    {
        public static async Task Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new NewsNowContext(
                serviceProvider.GetRequiredService<DbContextOptions<NewsNowContext>>()))
            {
                // For sample purposes seed both with the same password.
                // Password is set with the following:
                // dotnet user-secrets set SeedUserPW <pw>
                // The admin user can do anything

                var adminID = await EnsureUser(serviceProvider, "admin", "1234");
                await EnsureRole(serviceProvider, adminID, "ContactManagers");

                // allowed user can create and edit contacts that they create
                var managerID = await EnsureUser(serviceProvider, "admin", "password");
                await EnsureRole(serviceProvider, managerID, "ContactAdministrators");

                SeedDB(context, adminID);
            }
        }

        private static async Task<string> EnsureUser(IServiceProvider serviceProvider,
                                                    string username, string password)
        {
            var userManager = serviceProvider.GetService<UserManager<IdentityUser>>();

            var user = await userManager.FindByNameAsync(username);
            if (user == null)
            {
                user = new IdentityUser { UserName = username };
                await userManager.CreateAsync(user, password);
            }

            return user.Id;
        }

        private static async Task<IdentityResult> EnsureRole(IServiceProvider serviceProvider,
                                                                      string uid, string role)
        {
            IdentityResult IR = null;
            var roleManager = serviceProvider.GetService<RoleManager<IdentityRole>>();

            if (roleManager == null)
            {
                throw new Exception("roleManager null");
            }

            if (!await roleManager.RoleExistsAsync(role))
            {
                IR = await roleManager.CreateAsync(new IdentityRole(role));
            }

            var userManager = serviceProvider.GetService<UserManager<IdentityUser>>();

            var user = await userManager.FindByIdAsync(uid);

            IR = await userManager.AddToRoleAsync(user, role);

            return IR;
        }

        public static void SeedDB(NewsNowContext context, string adminID)
        {
            if (context.Users.Any())
            {
                return; // DB has been seeded
            }

            context.Users.AddRange(
                new User
                {
                    Username = "admin",
                    Password = "1234",
                    FirstName = "Admin",
                    LastName = "Admin",
                    BirthDate = System.DateTime.Now,
                    isWriter = true
                },
                new User
                {
                    Username = "admin",
                    Password = "password",
                    FirstName = "Admin",
                    LastName = "Admin",
                    BirthDate = System.DateTime.Now,
                    isWriter = true
                }
            );
        }
    }
}