// using Microsoft.AspNetCore.Mvc;
// using Microsoft.AspNetCore.Identity;
// using TravelClient.Models;
// using System.Threading.Tasks;
// using TravelClient.ViewModels;

// namespace TravelClient.Controllers
// {
//     public class AccountController : Controller
//     {
//         private readonly TravelApiContext _db;
//         private readonly UserManager<ApplicationUser> _userManager;
//         private readonly SignInManager<ApplicationUser> _signInManager;

//         private readonly RoleManager<IdentityRole> _roleManager;

//         public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<IdentityRole> roleManager, TravelApiContext db)
//         {
//             _userManager = userManager;
//             _signInManager = signInManager;
//             _roleManager = roleManager;
//             _db = db;
//         }

//         public ActionResult Index()
//         {
//             return View();
//         }

//         public IActionResult Register()
//         {
//             return View();
//         }

//         [HttpPost]
//         public async Task<ActionResult> Register(RegisterViewModel model)
//         {
//             var user = new ApplicationUser { UserName = model.Email };
//             IdentityResult result = await _userManager.CreateAsync(user, model.Password);
//             if (result.Succeeded)
//             {
//                 return RedirectToAction("Login");
//             }
//             else
//             {
//                 return View();
//             }
//         }

//         public ActionResult Login()
//         {
//             return View();
//         }

//         [HttpPost]
//         public async Task<ActionResult> Login(LoginViewModel model)
//         {
//             Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: true, lockoutOnFailure: false);
//             if (result.Succeeded)
//             {
//                 return RedirectToAction("Index", "Home");
//             }
//             else
//             {
//                 return View();
//             }
//         }

//         [HttpPost]
//         public async Task<ActionResult> LogOff()
//         {
//             await _signInManager.SignOutAsync();
//             return RedirectToAction("Index", "Home");
//         }
//     }
// }