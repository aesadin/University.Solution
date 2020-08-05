using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;

namespace TheArt.Models
{
  public class Piece
  {
    
    public int PieceId { get; set; }
    public string PieceName { get; set; }
    public DateTime PieceDate { get; set; }
    public byte[] PieceImage { get; set; }
    public int ArtistId { get; set; }
    public Artist Artist { get; set; }
    
  }
}