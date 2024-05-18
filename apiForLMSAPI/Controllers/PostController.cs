using apiForLMSAPI.Model;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace apiForLMSAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Post>> GetPosts()
        {
            List<Post> posts = new List<Post>{
                new Post
                {
                    MainSubject = "Vacation",
                    SubjectName = "Tickets",
                    SubjectData = new List<Dictionary<string, string>>
                    {
                        new Dictionary<string, string> { { "Buss to airport", "2024-07-30 15:30" } },
                        new Dictionary<string, string> { { "Airplane", "2024-07-30 17:45" } }
                    },
                    Subjects = new List<string>(),
                    HeadSubject = "Vacation",
                    Id = 233
                },
                new Post
                {
                    MainSubject = "Vacation",
                    SubjectName = "Passport",
                    SubjectData = new List<Dictionary<string, string>>
                    {
                        new Dictionary<string, string> { { "Expire", "2025-08-25" } },
                    },
                    Subjects = new List<string>(),
                    HeadSubject = "Vacation",
                    Id = 2331
                },
                new Post
                {
                    MainSubject = "Vacation",
                    SubjectName = "Vaccin",
                    SubjectData = new List<Dictionary<string, string>>
                    {
                        new Dictionary<string, string> { { "Hepatit", "2024-08-25, not Taken" } },
                        new Dictionary<string, string> { { "Malaria", "2024-08-25, not Taken" } },
                    },
                    Subjects = new List<string>(),
                    HeadSubject = "Vacation",
                    Id = 23310
                },
                new Post
                {
                    MainSubject = "Chores",
                    SubjectName = "This Week",
                    SubjectData = new List<Dictionary<string, string>>
                    {
                        new Dictionary<string, string> { { "Fishtank", "Change water and clean sand" } },
                        new Dictionary<string, string> { { "Lawn", "Cut grass" } },
                        new Dictionary<string, string> { { "ASAP", "Trashes" } }
                    },
                    Subjects = new List<string> { "shopping" },
                    HeadSubject = "Chores",
                    Id = 801
                },
                new Post
                {
                    MainSubject = "Chores",
                    SubjectName = "shopping",
                    SubjectData = new List<Dictionary<string, string>>
                    {
                        new Dictionary<string, string> { { "Food", "Milk, bread and egg" } }
                    },
                    Subjects = new List<string>(),
                    HeadSubject = "This Week",
                    Id = 8012
                },
                new Post
                {
                    MainSubject = "Cars",
                    SubjectName = "VW Passat",
                    SubjectData = new List<Dictionary<string, string>>
                    {
                        new Dictionary<string, string> { { "Service", "24/9" } }
                    },
                    Subjects = new List<string>(){"Last Service"},
                    HeadSubject = "Cars",
                    Id = 890
                },
                new Post
                {
                    MainSubject = "Cars",
                    SubjectName = "Fiat Punto",
                    SubjectData = new List<Dictionary<string, string>>
                    {
                        new Dictionary<string, string> { { "Service", "20/9" } }
                    },
                    Subjects = new List<string>(){"Latest inspection"},
                    HeadSubject = "Cars",
                    Id = 8991
                },
                new Post
                {
                    MainSubject = "Cars",
                    SubjectName = "Latest inspection",
                    SubjectData = new List<Dictionary<string, string>>
                    {
                        new Dictionary<string, string> { { "Oil", "Changed" } }
                    },
                    Subjects = new List<string>(),
                    HeadSubject = "Fiat Punto",
                    Id = 89955
                },
                new Post
                {
                    MainSubject = "Cars",
                    SubjectName = "Last Service",
                    SubjectData = new List<Dictionary<string, string>>
                    {
                        new Dictionary<string, string> { { "Price", "3000" } },
                        new Dictionary<string, string> { { "Changes", "Oil, back tiers" } }
                    },
                    Subjects = new List<string>(),
                    HeadSubject = "VW Passat",
                    Id = 8440
                }
            };
            return Ok(posts);
        }
    }
}
