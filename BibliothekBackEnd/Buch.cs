using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliothekBackEnd {
  public class Buch {
    // static belongs to the class, not the instance!
    // when instances read this, they all see the same static number,  because it is not an instance-specific value.
    static int number = 0;  // this is no longer an instance property due to 'static'    
    public string Name { get; set; }
    public string Autor { get; set; }
    public string SeiteAnzahl { get; set; }
    public string Sprache { get; set; }
    public string Note { get; set; }

    public int Number { get; }
    public DateOnly ErscheinungsDatum { get; set; }

    public List<Bestand>? bestandList { get; set; }  // prevents null reference issues when used elsewhere.

    public List<Standort>? standortList { get; set; }

    public List<Reservierung>? reservierungList { get; set; }

    public Buch() {
      number++; // static counter increases for each created object
      this.Number = number; // assign the generated number to this instance as its ID
      this.bestandList = new List<Bestand>();
      this.standortList = new List<Standort>();
      this.reservierungList = new List<Reservierung>();

    }





  }
}
