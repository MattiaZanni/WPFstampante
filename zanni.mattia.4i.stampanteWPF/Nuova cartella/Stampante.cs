using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Navigation;

namespace zanni.mattia._4i.stampanteWPF.Nuova_cartella
{
    /*
      Classe "Stampante" 
- 4 serbatoi di colore: CMYB e un cassetto di fogli (tutte property int)
- un metodo bool Stampa( Pagina p ) (che torna false, se l'inchiostro non è sufficiente per stampare)
- un metodo int StatoInchiostro( Colore c ) che torna la quantità di inchiostro presente nei 4 serbatoi.
- un metodo int StatoCarta() che mi ritorna la quantità di fogli nel cassetto
- un metodo void SostituisciColore( Colore c ) che rimpiazza un serbatoio di inchiostro e lo riporta a 100
     */
    internal class Stampante
    {

        public int C { get; set; }
        public int M { get; set; }
        public int Y { get; set; }
        public int B { get; set; }
        public int Fogli { get; set; }



        public Stampante()
        {
            C = M = Y = B = 100;
            Fogli = 200;
        }
        public bool Stampa(Pagina p) {
            if (Fogli>0) {
                if (C >= p.C && M >= p.M && Y >= p.Y && B >= p.B)
                {
                C -= p.C;
                M -= p.M;
                Y -= p.Y;
                B -= p.B;
                Fogli--;
                
                return true;
                }
            }
            return false;
            
        }
        public int Statoinchiostro(string Colore)
        {
            if(Colori.ContainsKey( colore ))
            {
                return Colori[colore];
            }
        }    
        
    }
}
