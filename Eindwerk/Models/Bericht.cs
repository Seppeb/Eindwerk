using Eindwerk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eindwerk.Data
{
    public class Bericht
    {
        public int BerichtId { get; set; }
        public string Titel { get; set; }
        public string Inhoud { get; set; }
        public bool  IsIntern { get; set; }

        public ICollection<Aanvraag> Aanvragen { get; set; }
        public ICollection<ApplicationUser> Gebruiker { get; set; }
    }
}
