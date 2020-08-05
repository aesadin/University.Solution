using System.Collections.Generic;
using System;

namespace TheArt.Models
{
    public class Artists
    {
        public Artist()
        {
            this.Movements = new HashSet<ArtistMovement>();
        }

        public int ArtistId { get; set; }
        public string ArtistName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfDeath { get; set; }
        public ICollection<ArtistMovement> Pieces { get; }
        public ICollection<ArtistMovement> Movements { get;} // has all Id's joined data which is associated to the caregory object
    }
}