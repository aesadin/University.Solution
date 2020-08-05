using Microsoft.AspNetCore.Mvc;
using UniversityRegistrar.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace TheArt.Controllers
{
  public class MovementsController : Controller
  {
    private readonly UniversityRegistrarContext _db;

    public MovementsController(UniversityRegistrarContext db)
    {
      _db = db;
    }

    public ActionResult Index(string searchQuery = null)
    {
      if (searchQuery == null)
      {
        ViewBag.SearchFlag = 0;
        return View(_db.Movements.ToList());
      }
      else
      {
        ViewBag.SearchFlag = 1;
        List<Movement> model = _db.Movements.Where(Movement => Movement.Name.ToLower().Contains(searchQuery.ToLower())).ToList();
        return View(model);
      }
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Movement Movement)
    {
      _db.Movements.Add(Movement);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisMovement = _db.Movements
          .Include(Movement => Movement.Students)
          .ThenInclude(join => join.Student)
          .FirstOrDefault(Movement => Movement.MovementId == id);
      return View(thisMovement);
    }

    public ActionResult Edit(int id)
    {
      var thisMovement = _db.Movements.FirstOrDefault(Movement => Movement.MovementId == id);
      return View(thisMovement);
    }

    [HttpPost]
    public ActionResult Edit(Movement Movement)
    {
      _db.Entry(Movement).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisMovement = _db.Movements.FirstOrDefault(Movement => Movement.MovementId == id);
      return View(thisMovement);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisMovement = _db.Movements.FirstOrDefault(Movement => Movement.MovementId == id);
      _db.Movements.Remove(thisMovement);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}