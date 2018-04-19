using Eindwerk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eindwerk.Data
{
    public class Status
    {

        public int StatusId { get; set; }

        public string Naam { get; set; }

        public string Omschrijving { get; set; }

        public ICollection<Aanvraag> Aanvragen { get; set; }
    }
}
