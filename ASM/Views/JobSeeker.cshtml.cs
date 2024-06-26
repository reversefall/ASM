using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASM.Views
{
    [Authorize(Roles ="JobSeeker")]
    public class JobSeekerModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
