using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ActivityCenter.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace ActivityCenter.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context {get; set;}

        public User GetUser()
        {
            return _context.Users.FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("userId"));
        }

        public HomeController(MyContext context)
        {
            _context = context;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {

                if (_context.Users.Any(u => u.Email == user.Email))
                {
                    ModelState.AddModelError("Email", "This email is already in use!");
                    return View("Index");
                }
                else
                {
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    user.Password = Hasher.HashPassword(user, user.Password);
                    _context.Users.Add(user);
                    _context.SaveChanges();
                    HttpContext.Session.SetInt32("userId", user.UserId);
                    return Redirect("/home");
                }
            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet("login/form")]
        public IActionResult LoginForm()
        {
            return View();
        }

        [HttpPost("login")]
        public IActionResult Login(LoginUser log)
        {
            if (ModelState.IsValid)
            {
                var userInDb = _context.Users.FirstOrDefault(u => u.Email == log.LoginEmail);
                if (userInDb == null)
                {
                    ModelState.AddModelError("LoginEmail", "Invalid Email/Password");
                    return View("LoginForm");
                }
                else
                {
                    var hasher = new PasswordHasher<LoginUser>();
                    var result = hasher.VerifyHashedPassword(log, userInDb.Password, log.LoginPassword);
                    if (result == 0)
                    {
                        ModelState.AddModelError("LoginPassword", "Invalid email or password");
                        return View("LoginForm");
                    }
                    HttpContext.Session.SetInt32("userId", userInDb.UserId);
                    return Redirect("/home");
                }
            }
            else
            {
                return View("LoginForm");
            }
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }


        [HttpGet("home")]
        public IActionResult Home()
        {
            User current = GetUser();
            if (current == null)
            {
                return Redirect("/");
            }
            ViewBag.User = current;
            List<PlayActivity> AllActivites = _context.PlayActivities.Include(p => p.Organizer).Include(p => p.Friends).ThenInclude(wp => wp.Person).Where(p => p.Time >= DateTime.Now).OrderBy(p => p.Time).ToList();
            return View(AllActivites);
        }

        [HttpGet("activity/{playActivityId}/delete")]
        public IActionResult DeleteActivity(int playActivityId)
        {
            User current = GetUser();
            if (current == null)
            {
                return Redirect("/");
            }
            PlayActivity remove = _context.PlayActivities.FirstOrDefault( p => p.PlayActivityId == playActivityId);
            _context.PlayActivities.Remove(remove);
            _context.SaveChanges();
            return RedirectToAction("Home");
        }

        [HttpGet("activity/{playActivityId}/{status}")]
        public IActionResult ToggleActivity(int playActivityId, string status)
        {
            User current = GetUser();
            if (current == null)
            {
                return Redirect("/");
            }
            if(status == "join")
            {
                PlayDate newActivity = new PlayDate();
                newActivity.UserId = current.UserId;
                newActivity.PlayActivityId = playActivityId;
                _context.PlayDates.Add(newActivity);
            }
            else if(status == "leave")
            {
                PlayDate leave = _context.PlayDates.FirstOrDefault( h => h.UserId == current.UserId && h.PlayActivityId == playActivityId );
                _context.PlayDates.Remove(leave);
            }
            _context.SaveChanges();
            return RedirectToAction("Home");
        }

        [HttpGet("new")]
        public IActionResult NewActivityForm()
        {
            User current = GetUser();
            if (current == null)
            {
                return Redirect("/");
            }
            ViewBag.User = current;
            return View();
        }

        [HttpPost("create/activity")]
        public IActionResult CreateActivity(PlayActivity newP)
        {
            User current = GetUser();
            if (current == null)
            {
                return Redirect("/");
            }
            if(ModelState.IsValid)
            {
                newP.UserId = current.UserId;
                _context.PlayActivities.Add(newP);
                _context.SaveChanges();
                return Redirect($"/activity/{newP.PlayActivityId}");
            }
            else
            {
                return View("NewActivityForm");
            }
        }

        [HttpGet("activity/{playActivityId}")]
        public IActionResult ViewActivity(int playActivityId)
        {
            User current = GetUser();
            if (current == null)
            {
                return Redirect("/");
            }
            ViewBag.User = current;
            PlayActivity activity = _context.PlayActivities.Include( x => x.Friends).ThenInclude( y => y.Person).Include(x => x.Organizer).FirstOrDefault(p => p.PlayActivityId == playActivityId);
            return View(activity);
        }
    }
}

