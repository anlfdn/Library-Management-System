using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliothekBackEnd {
  public class Standort {

    public string Shelf { get; set; }
    public string Reihe { get; set; }
    public string Position { get; set; }


    public Standort() {

    }

    public Standort(string shelf, string reihe, string position) {
      this.Shelf = shelf;
      this.Reihe = reihe;
      this.Position = position;
    }
  }
}
