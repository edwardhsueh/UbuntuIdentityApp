using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
namespace IdentityApp.Pages.Identity.Admin {
    public class EditBindingTarget {
        [Required]
        public string Username { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
    }
    public class EditModel : AdminPageModel {
        
        // dependencey injection
        public EditModel(UserManager<IdentityUser> mgr) => UserManager = mgr;
        public UserManager<IdentityUser> UserManager { get; set; }
        public IdentityUser IdentityUser { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Id { get; set; }
        public async Task<IActionResult> OnGetAsync() {
            if (string.IsNullOrEmpty(Id)) {
                return RedirectToPage("Selectuser",
                    new { Label = "Edit User", Callback = "Edit" });
            }
            IdentityUser = await UserManager.FindByIdAsync(Id);
            return Page();
        }
        public async Task<IActionResult> OnPostAsync([FromForm(Name = "IdentityUser")] EditBindingTarget userData) {
            if (!string.IsNullOrEmpty(Id) && ModelState.IsValid) {
                IdentityUser user = await UserManager.FindByIdAsync(Id);
                if (user != null) {
                    user.UserName = userData.Email; // Keep UserName/Email the same
                    user.Email = userData.Email;
                    user.EmailConfirmed = true;
                    if (!string.IsNullOrEmpty(userData.PhoneNumber)) {
                        user.PhoneNumber = userData.PhoneNumber;
                    }
                }
                /// <summary>
                /// ASP.NET Core represents users with the ClaimsPrincipal class and a ClaimsPrincipal object for the current user is available through the User property defined by the Controller and RazorPageBase classes, which means the same features are available for the MVC Framework and Razor Pages
                /// </summary>
                /// <returns></returns>
                IdentityResult result = await UserManager.UpdateAsync(user);
                if (result.Process(ModelState)) {
                    return RedirectToPage();
                }
            }
            IdentityUser = await UserManager.FindByIdAsync(Id);
            return Page();
        }
    }
}