using System.Text;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BibliothekBackEnd {
  public class DataBase {

    [XmlIgnore()]
    public string DateiName { get; set; }


    public List<Buch> buchList = new List<Buch>();
    public List<Bestand> bestandList = new List<Bestand>();
    public List<Standort> standortList  = new List<Standort>();
    public List<Reservierung> reservierungList = new List<Reservierung>();

    public static DataBase GetDatei(string dateiName) {

      XmlSerializer serializer = new XmlSerializer(typeof(DataBase));
      StreamReader reader = new StreamReader(dateiName, Encoding.UTF8);

      DataBase dataBase = (DataBase)serializer.Deserialize(reader);
      dataBase.DateiName = dateiName;
      reader.Close();
      return dataBase;
    }

    public void Speichern() {

      XmlSerializer serializer = new XmlSerializer(typeof(DataBase));
      StreamWriter writer = new StreamWriter(this.DateiName, false, Encoding.UTF8);

      serializer.Serialize(writer, this); // you can use 'this' here; it's used to refer to the current instance

      writer.Close();
    }

  }
}
