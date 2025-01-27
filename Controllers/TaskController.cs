using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PowerCred.Data;
using PowerCred.Models;
namespace PowerCred.Controllers
{
   
    public class TaskController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TaskController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(string sortOrder, string searchString, int pageNumber = 1, int pageSize = 5)
        {
            var tasks = _context.TaskDetails.AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                tasks = tasks.Where(t => t.Title.Contains(searchString) || t.Description.Contains(searchString));
            }

            tasks = sortOrder switch
            {
                "priority" => tasks.OrderBy(t => t.Priority),
                "duedate" => tasks.OrderBy(t => t.DueDate),
                _ => tasks
            };

            var totalCount = tasks.Count();
            ViewBag.CurrentPage = pageNumber;
            ViewBag.TotalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

            var paginatedTasks = tasks
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            return View(paginatedTasks);
        }



    }
}
