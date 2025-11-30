using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliothekBackEnd {
  public class Bibliothek {

    List<Buch> buchList { get; set; }


    public Bibliothek() {
      buchList = new List<Buch>();
    }

    private string Add(Buch buch) {
      string message;
      if (buchList.Contains(buch))
      {

        message = "Das Buch wurde schon in ihrem List hinzugefugt.";
        return message;
      } else {
        buchList.Add(new Buch());
        message = "Das Buch wird in ihrem List hinzugefugt.";
        return message;
      }
      
    }
  }
}
