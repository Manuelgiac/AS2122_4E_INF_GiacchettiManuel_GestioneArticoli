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

        string Descrizione { get { return descrizione; } }

        string UnitaDiMisura { get { return unitadimisura; } }

        double Prezzo { get { return prezzo; } }



        public Articolo {string codice, string descrizione,string unitadimisura, double prezzo)
            
         {   
            this.codice=codice;
            this.descrizione=descrizione;
            this.unitadimisura=unitaDiMisura;
            this.prezzo=Prezzo;
         }
        
    }
}
