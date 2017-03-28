﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotepadSimulation
{
    class Persoon
    {
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public DateTime GeboorteDatum { get; set; }

        public override string ToString()
        {
            return Voornaam + " " + Achternaam + " " +string.Format( "({0})", GeboorteDatum);

        }
    }
}
