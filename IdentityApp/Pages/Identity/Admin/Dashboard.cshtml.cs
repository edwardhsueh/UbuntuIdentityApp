using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.Extensions.Configuration;
namespace IdentityApp.Pages.Identity.Admin {
    public class DashboardModel : AdminPageModel {
    // Two of the most important parts of the Identity API are the user manager and the user class. The user manager provides access to the data that Identity manages, and the user class describes the data that Identity manages for a single user account.

// The second key class is the user manager, which is UserManager<T>. The generic type argument, T, is used to specify the user class. Since the example application uses the built-in user class, the user manager will be UserManager<IdentityUser> . The user manager is configured as a service through the ASP.NET Core dependency injection feature. To access the user manager in the Razor Page model class, I added a constructor with a UserManager<IdentityUser> parameter, like this:
        public DashboardModel(UserManager<IdentityUser> userMgr, IConfiguration configuration){
            DashboardRole = configuration["Dashboard:Role"] ?? "Dashboard";
             UserManager = userMgr;

        }
        public UserManager<IdentityUser> UserManager { get; set; }
        public string DashboardRole { get; set; }


        public int UsersCount { get; set; } = 0;
        public int UsersUnconfirmed { get; set; } = 0;
        public int UsersLockedout { get; set; } = 0;
        public int UsersTwoFactor { get; set; } = 0;
        private readonly string[] emails = {
            "alice@example.com", "bob@example.com", "charlie@example.com"
        };

        public void OnGet() {
            UsersCount = UserManager.Users.Count();
            UsersTwoFactor = UserManager.Users.Where(u => u.TwoFactorEnabled).Count();
            UsersUnconfirmed = UserManager.Users
                    .Where(u => !u.EmailConfirmed).Count();
            int i =0;
            foreach (IdentityUser existingUser in UserManager.Users.ToList()) {
                Console.WriteLine($"########## {i++} #############");
                Console.WriteLine($"{existingUser.ToString()}");
                Console.WriteLine($"LockoutEnabled:{existingUser.LockoutEnabled}");
                Console.WriteLine($"LockoutEnd:{existingUser.LockoutEnd}");    
                Console.WriteLine($"Now:{System.DateTimeOffset.Now}");    
                bool result = existingUser.LockoutEnabled && (existingUser.LockoutEnd??= System.DateTimeOffset.Now) > System.DateTimeOffset.Now;
                Console.WriteLine($"result:{result}");    
                if(result){
                     UsersLockedout++;
                }
            }
            Console.WriteLine($"##########################");
            Console.WriteLine($"UsersLockedout:{   UsersLockedout}");    
            
        //     UsersLockedout = UserManager.Users.Where(u => u.LockoutEnabled && ((u.LockoutEnd??= System.DateTimeOffset.Now) > System.DateTimeOffset.Now))
        //     .Count();
         
        //        UsersLockedout = (from u in UserManager.Users
        //                          where u.LockoutEnabled && (u.LockoutEnd??= System.DateTimeOffset.Now) > System.DateTimeOffset.Now 
        //                          select u).ToList().Count();
            
        }
    
        public async Task<IActionResult> OnPostAsync() {
            foreach (IdentityUser existingUser in UserManager.Users.ToList()) {
                bool userRoleIsDashboard = await UserManager.IsInRoleAsync(existingUser, DashboardRole);
                Console.WriteLine($"existUser.Email:{existingUser.Email}, userRoleIsDashboard:{userRoleIsDashboard}");
                // make sure DashBoard Role is not deleted
                if (emails.Contains(existingUser.Email) && !userRoleIsDashboard) {
                    IdentityResult result= await UserManager.DeleteAsync(existingUser);
                    result.Process(ModelState);
                }    
//                 IdentityResult result = await UserManager.DeleteAsync(existingUser);
//                 result.Process(ModelState);
            }

            foreach (string email in emails) {
    // The type of the user class is specified using the generic type argument to the AddDefaultIdentity method. The user class defines a set of properties that describe the user account and provide the data values that Identity needs to implement its features. To create a new user object, I create a new instance of the IdentityUser class and set three of these properties, like this:
                IdentityUser userObject = new IdentityUser {
                    UserName = email,
                    Email = email,
                    EmailConfirmed = true
                };
                IdentityResult result = await UserManager.CreateAsync(userObject);
//                 result.Process(ModelState);
                if (result.Process(ModelState)) {
                    result = await UserManager.AddPasswordAsync(userObject, "mypasswd");
                    result.Process(ModelState);
                }
            }
            if (ModelState.IsValid) {
                return RedirectToPage();
            }
            return Page();
        }
    }
}