using Eindwerk.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eindwerk.Models
{
    public class Aanvraag
    {

        public int AanvraagId { get; set; }
        public string Omschrijving { get; set; }
        public string Titel { get; set; }
        public DateTime StartDatum { get; set; }
        public DateTime? EindDatum { get; set; }


        public Status Status { get; set; }
        public Bedrijf Bedrijf { get; set; }
        public Bericht Bericht { get; set; }

        //eerst rest implementeren dan pas user control
        public ApplicationUser Gebruiker { get; set; }
    }
}
