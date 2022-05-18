using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2122_4E_INF_GiacchettiManuel_GestioneArticoli
{
    internal class Articolo
    {
        string codice;
        string prezzo;
        string unitaDimisura;
        string descrizione;

        string Codice { get { return codice; } }

        string Descrizione { get { return descrizione;} }
        
        string UnitaDiMisura { get { return unitaDimisura; } }

        double Prezzo { get { return Prezzo; } }


    }
}
