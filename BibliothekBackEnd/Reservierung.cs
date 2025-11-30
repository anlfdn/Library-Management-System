using BibliothekBackEnd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BibliothekBackEnd {

  
  public class Reservierung {


    public string Vorname { get; set; }
    public string Nachname { get; set; }
    public DateOnly AusleihDatum { get; set; }
    public int RestDay { get; set; }

    

  

    public Reservierung() {

    }

    public Reservierung(string vorname, string nachname, DateOnly ausleihdatum, int restDay) {
      this.Vorname = vorname;
      this.Nachname = nachname;
      this.AusleihDatum = ausleihdatum;
      this.RestDay = restDay;



    }
  }
}
