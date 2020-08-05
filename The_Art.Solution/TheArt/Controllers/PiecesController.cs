using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TheArt.Models;
using System.Linq;

namespace TheArt.Controllers
{
  public class ArtistsController : Controller
  {
    private readonly TheArtContext _db;

    public ArtistsController(TheArtContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Piece> model = _db.Pieces.Include(piece => piece.Artist).ToList();
      return View(model);
    }
    
    // public ActionResult Edit(int id)
    // {
    //   var thisArtist = _db.Artists.FirstOrDefault(Artists => Artists.ArtistId == id);
    //   ViewBag.MovementId = new SelectList(_db.Movements, "MovementId", "Name");
    //   return View(thisArtist);
    // } 

    // [HttpPost]
    // public ActionResult Edit(Artist Artist, int MovementId)
    // {
    //   if(MovementId !=0)  
    //   {
    //     _db.ArtistMovement.Add(new ArtistMovement() {MovementId = MovementId, ArtistId = Artist.ArtistId});
    //   } 
    //     _db.Entry(Artist).State = EntityState.Modified;
    //     _db.SaveChanges();
    //     return RedirectToAction("Index");
      
    // }

    // public ActionResult Create()
    // {
    //   ViewBag.MovementId = new SelectList(_db.Movements, "MovementId", "Name");
    //   return View();
    // }

    // [HttpPost]
    // public ActionResult Create(Artist Artist, int MovementId)
    // {
    //   _db.Artists.Add(Artist);
    //   if(MovementId !=0)
    //     {
    //         _db.ArtistMovement.Add(new ArtistMovement() {MovementId = MovementId, ArtistId = Artist.ArtistId});
    //     }
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }

    // public ActionResult Details(int id)
    // {
    //   var thisArtist = _db.Artists
    //     .Include(Artist => Artist.Movements)// join enitities of Movementitem.
    //     .ThenInclude(join => join.Movement)
    //     .FirstOrDefault(Artist => Artist.ArtistId == id);
    //   return View(thisArtist);
    // }

    // public ActionResult AddMovement(int id)
    // {
    // var thisArtist = _db.Artists.FirstOrDefault(Artists => Artists.ArtistId == id);
    // ViewBag.MovementId = new SelectList(_db.Movements, "MovementId", "Name");
    // return View(thisArtist);
    // }

    // [HttpPost]
    // public ActionResult AddMovement(Artist Artist, int MovementId)
    // {
    //   if (MovementId != 0)
    //     {
    //     _db.ArtistMovement.Add(new ArtistMovement() { MovementId = MovementId, ArtistId = Artist.ArtistId });
    //     }
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }

    // public ActionResult Delete(int id)
    // {
    //   var thisArtist = _db.Artists.FirstOrDefault(Artists => Artists.ArtistId == id);
    //   return View(thisArtist);
    // }

    // [HttpPost, ActionName("Delete")]
    // public ActionResult DeleteConfirmed(int id)
    // {
    //   var thisArtist = _db.Artists.FirstOrDefault(Artists => Artists.ArtistId == id);
    //   _db.Artists.Remove(thisArtist);
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }
    // [HttpPost]
    // public ActionResult DeleteMovement(int joinId)
    // {
    //   var joinEntry = _db.ArtistMovement.FirstOrDefault(entry => entry.ArtistMovementId == joinId);
    //   _db.ArtistMovement.Remove(joinEntry);
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }
  }
}