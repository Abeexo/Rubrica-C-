using System.Data;
using System.Text;


namespace RubricaTelefonica
{
    class Contatto {
    public string Nome;
    public string NumeroCasa;
    public string NumeroCellulare;
    public string NumeroUfficio;

    public Contatto(string Nome,string NumeroCasa, string NumeroCellulare, string NumeroUfficio) {
        this.Nome = Nome;
        this.NumeroCasa = NumeroCasa;
        this.NumeroCellulare = NumeroCellulare;
        this.NumeroUfficio = NumeroUfficio;
    }

    public Contatto(){
        this.Nome = "";
        this.NumeroCasa = "";
        this.NumeroCellulare = "";
        this.NumeroUfficio = "";
    }
  

   
    public override string ToString() {
        return Nome + " - " + NumeroCasa + " (casa), " + NumeroCellulare + " (cellulare), " + NumeroUfficio + " (ufficio)";
    }
} 

class Rubrica {
    private List<Contatto> contatti = new List<Contatto>();

    public void AggiungiContatto(Contatto contatto) {
        contatti.Add(contatto);
    }
    public void RimuoviContatto(Contatto contatto) {
        contatti.Remove(contatto);
    }
    public void UnisciContatti(Contatto contatto1, Contatto contatto2) {
        contatto1.NumeroCasa += ", " + contatto2.NumeroCasa;
        contatto1.NumeroCellulare += ", " + contatto2.NumeroCellulare;
        contatto1.NumeroUfficio += ", " + contatto2.NumeroUfficio;
        RimuoviContatto(contatto2);
    }
    public IEnumerable<Contatto> CercaContatti(string ricerca) {
    return contatti.Where(c => c.Nome.ToLower().Contains(ricerca.ToLower()));
}
     
    public IEnumerable<Contatto> ElencoContattiOrdinatiPerNome() {
        return contatti.OrderBy(c => c.Nome).ToList();
    }

}
    
class GestioneRubrica {
private Rubrica rubrica = new Rubrica();


    public void Avvia() {
        bool esci = false;
        while (!esci) {
            Console.WriteLine("\nCosa vuoi fare?");
            Console.WriteLine("1. Aggiungi contatto");
            Console.WriteLine("2. Rimuovi contatto");
            Console.WriteLine("3. Unisci contatti");
            Console.WriteLine("4. Cerca contatti");
            Console.WriteLine("5. Elenco contatti ordinati per nome");
            Console.WriteLine("6. Esci\n");

            int scelta = int.Parse(Console.ReadLine());

            switch (scelta) {
                case 1:
                    AggiungiContatto();
                    break;
                case 2:
                    RimuoviContatto();
                    break;
                case 3:
                    UnisciContatti();
                    break;
                case 4:
                Console.WriteLine("Inserisci il nome:");
                string ricerca = Console.ReadLine();
                var contattiTrovati = rubrica.CercaContatti(ricerca);
                foreach (var contatto in contattiTrovati) {
                Console.WriteLine(contatto);}
                    break;
                 
                case 5:
                var elencoContatti = rubrica.ElencoContattiOrdinatiPerNome();
                Console.WriteLine("\nEcco l'elenco dei contatti:\n");
                foreach (var contatto in elencoContatti) {
                Console.WriteLine(contatto);
                }
                break;
                case 6:
                    esci = true;
                    break;
                default:
                    Console.WriteLine("\nScelta non valida\n");
                    break;
            }
        }
    }

    private void AggiungiContatto() {
       Console.WriteLine("Inserisci il nome:");
        string nome = Console.ReadLine();
         Console.WriteLine("Inserisci il numero di casa:");
        string numeroCasa = Console.ReadLine();
          if (!numeroCasa.All(char.IsDigit)) {
        Console.WriteLine("\nIl numero di casa deve contenere solo numeri.\n");
        return;
    }
         Console.WriteLine("Inserisci il numero di cellulare:");
        string numeroCellulare = Console.ReadLine();
    if (!numeroCellulare.All(char.IsDigit)) {
        Console.WriteLine("\nIl numero di cellulare deve contenere solo numeri.\n");
        return;
    }
    Console.WriteLine("Inserisci il numero di ufficio:");
    string numeroUfficio = Console.ReadLine();
    if (!numeroUfficio.All(char.IsDigit)) {
        Console.WriteLine("\nIl numero di ufficio deve contenere solo numeri.\n");
        return;
    }

        Contatto contatto = new Contatto {
            Nome = nome,
            NumeroCasa = numeroCasa,
            NumeroCellulare = numeroCellulare,
            NumeroUfficio = numeroUfficio
        };

        rubrica.AggiungiContatto(contatto);
        Console.WriteLine("\nContatto aggiunto con successo!!!\n");
    }

    private void RimuoviContatto() {
        Console.WriteLine("Inserisci il nome del contatto da rimuovere:");
        string nome = Console.ReadLine();

        Contatto contattoDaRimuovere = rubrica.CercaContatti(nome).FirstOrDefault();
        if (contattoDaRimuovere == null) {
            Console.WriteLine("Contatto non trovato");
        } else {
            rubrica.RimuoviContatto(contattoDaRimuovere);
            Console.WriteLine("Contatto rimosso con successo");
        }
    }

    private void UnisciContatti() {
        Console.WriteLine("Inserisci il nome del primo contatto:");
        string nome1 = Console.ReadLine();
        Console.WriteLine("Inserisci il nome del secondo contatto:");
        string nome2 = Console.ReadLine();

        Contatto contatto1 = rubrica.CercaContatti(nome1).FirstOrDefault();
        Contatto contatto2 = rubrica.CercaContatti(nome2).FirstOrDefault();

        if (contatto1 == null || contatto2 == null) {
            Console.WriteLine("\nContatti non trovati\n");
        } else {
            rubrica.UnisciContatti(contatto1, contatto2);
            Console.WriteLine("\nContatti uniti con successo!!!\n");
        }
    }

            static void Main(string[] args){
            GestioneRubrica gestioneRubrica = new GestioneRubrica();
            gestioneRubrica.Avvia();
            }
}
}

