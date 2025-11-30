using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BibliothekBackEnd {
  public class Bestand {

    [XmlAttribute("Result")]
    public string Verfugbar {

      get {

        if (Anzahl > 0)
        {

          return "Verfugbar";
        } else return "nicht Verfugbar";
      }
    }
    [XmlAttribute("Anzahl")]
    public int Anzahl { get; set; }


    public Bestand() {

    }

    public Bestand(int anzahl) {
      this.Anzahl = anzahl; 
    }




   
    
    
    
   
  }
}
