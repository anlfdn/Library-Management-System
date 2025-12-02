using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

public enum BuchKategorie {

  Unbekannt,
  Roman,
  Krimi,
  Thriller,
  Historischer_Roman,
  Fantasy,
  Science_Fiction,
  Drama,
  Abenteuer

}






namespace BibliothekBackEnd {
  public class Buch {
    // static belongs to the class, not the instance!
    // when instances read this, they all see the same static number,  because it is not an instance-specific value.
    static int number = 0;  // this is no longer an instance property due to 'static'    

    // bir resmi muzigi videoyu pdf dosyasini bilgisayarda saklamak icin. Dosyanin icerigi bytlara cevrilir.
    // binary veri
    byte[] bildBytes;
    public string Name { get; set; }
    public string Autor { get; set; }
    public string SeiteAnzahl { get; set; }
    public string Sprache { get; set; }
    public string Note { get; set; }

    public string BildStr { get; set; }
    public int Number { get; set; }
    public DateTime? ErscheinungsDatum { get; set; }

    public BuchKategorie? Kategorie { get; set; }

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


    // string(Base64) -> byte[] verisinin metne donusmus hali
    [XmlIgnore()]
    public byte[] BildBytes {

      get {
        if (bildBytes == null && !string.IsNullOrEmpty(this.BildStr)) {

          //   .FromBase64String = yeniden saklanan bir string ifadeli bir resmi dosyayi byte verisine donusturur.
          // Base64String -> byte[]
          
          this.bildBytes = Convert.FromBase64String(this.BildStr);
         
        }
        return bildBytes;

      }
      set {
        //this.buch.BildBytes = File.ReadAllBytes(files[0]);
        this.bildBytes = value;
        // byte[] -> Base64string 
        // cmle buradan yaziliyor.
        this.BildStr = Convert.ToBase64String(bildBytes);
      }

    }







  }
}
