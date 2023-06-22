using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunGroup.Data;
using RunGroup.Interfaces;
using RunGroup.Models;
using RunGroup.Repository;

namespace RunGroup.Controllers
{
    public class RaceController : Controller
    {
        private readonly IRaceRepository _raceRepository;
        public RaceController(ApplicationDbContext context, IClubRepository clubRepository, IRaceRepository RaceRepository)
        {
            _raceRepository = RaceRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Race> race = await _raceRepository.GetAll();
            return View(race);
        }

        public async Task<IActionResult> Details(int id)
        {
            Race race = await _raceRepository.GetByIdAsync(id);
            return View(race);
        }
    }

}
