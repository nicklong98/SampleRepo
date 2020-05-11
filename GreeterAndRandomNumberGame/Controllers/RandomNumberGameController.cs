using System;
using GreeterAndRandomNumberGame.Models;
using Microsoft.AspNetCore.Mvc;

namespace GreeterAndRandomNumberGame.Controllers
{
    public class RandomNumberGameController : Controller
    {
        private static int? _targetNumber;
        private static readonly Random Randomizer = new Random();

        public IActionResult NewGame(int minValue = 0, int maxValue = 10)
        {
            _targetNumber = Randomizer.Next(minValue, maxValue);
            return RedirectToAction(nameof(Index));
        }

        // GET
        public IActionResult Index()
        {
            if (!_targetNumber.HasValue)
            {
                return RedirectToAction(nameof(NewGame));
            }

            return View(new RandomNumberGameViewModel
            {
                TargetNumber = _targetNumber.Value
            });
        }

        [HttpPost]
        public IActionResult Index(RandomNumberGameViewModel model)
        {
            if (model.StartNewGame)
            {
                return RedirectToAction(nameof(NewGame), new {minValue = model.MinValue, maxValue = model.MaxValue});
            }

            model.TargetNumber = _targetNumber ?? 0;

            return View(model);
        }
    }
}