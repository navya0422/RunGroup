using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunGroup.Data;
using RunGroup.Interfaces;
using RunGroup.Models;
using RunGroup.Repository;

namespace RunGroup.Controllers
{
    public class ClubController : Controller

    {
        private readonly IClubRepository _clubRepository;

        private readonly ApplicationDbContext _context;
        public ClubController(ApplicationDbContext context, IClubRepository clubRepository, IRaceRepository RaceRepository)
        {
            _clubRepository= clubRepository;
            
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Club> clubs = await _clubRepository.GetAll();
            return View(clubs);
        }

        public async Task<IActionResult> Details(int id)
        {
            Club club = await _clubRepository.GetByIdAsync(id);
            return View(club);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Club club)
        {
            if (!ModelState.IsValid)
            {
                return View(club);
            }
            _clubRepository.Add(club);
            return RedirectToAction("Index");
        }
    }
}
